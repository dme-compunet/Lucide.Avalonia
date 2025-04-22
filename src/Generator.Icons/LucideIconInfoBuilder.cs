using System.Text;
using System.Text.Json;

namespace Generator.Icons;

public class LucideIconInfoBuilder
{
    public record Info(string[]? Contributors, string[]? Categories, string[]? Tags);

    private readonly JsonSerializerOptions _options = new()
    {
        PropertyNameCaseInsensitive = true,
    };

    private readonly List<(string Name, Info Info)> _icon = [];

    public void AddIcon(string name, string path)
    {
        path = path.Replace(".svg", ".json");

        var json = File.ReadAllText(path);

        var info = JsonSerializer.Deserialize<Info>(json, _options) ?? throw new JsonException();

        _icon.Add((name, info));
    }

    public string Build()
    {
        var sb = new StringBuilder();

        //sb.AppendLine("namespace Lucide.Avalonia.Metadata;");
        //sb.AppendLine();
        //sb.AppendLine("public class LucideIconInfo");
        //sb.AppendLine("{");
        //sb.AppendLine("    public required LucideIconKind Kind { get; init; }");
        //sb.AppendLine();
        //sb.AppendLine("    public required string[] Contributors { get; init; }");
        //sb.AppendLine();
        //sb.AppendLine("    public required string[] Categories { get; init; }");
        //sb.AppendLine();
        //sb.AppendLine("    public required string[] Tags { get; init; }");
        //sb.AppendLine();
        //sb.AppendLine("    public bool Contains(string? value)");
        //sb.AppendLine("    {");
        //sb.AppendLine("        if (string.IsNullOrEmpty(value))");
        //sb.AppendLine("        {");
        //sb.AppendLine("            return true;");
        //sb.AppendLine("        }");
        //sb.AppendLine();
        //sb.AppendLine("        value = value.ToLower();");
        //sb.AppendLine();
        //sb.AppendLine("        if (Kind.ToString().Contains(value, StringComparison.OrdinalIgnoreCase))");
        //sb.AppendLine("        {");
        //sb.AppendLine("            return true;");
        //sb.AppendLine("        }");
        //sb.AppendLine();
        //sb.AppendLine("        foreach (var category in Categories)");
        //sb.AppendLine("        {");
        //sb.AppendLine("            if (category.Contains(value))");
        //sb.AppendLine("            {");
        //sb.AppendLine("                return true;");
        //sb.AppendLine("            }");
        //sb.AppendLine("        }");
        //sb.AppendLine();
        //sb.AppendLine("        foreach (var tag in Tags)");
        //sb.AppendLine("        {");
        //sb.AppendLine("            if (tag.Contains(value))");
        //sb.AppendLine("            {");
        //sb.AppendLine("                return true;");
        //sb.AppendLine("            }");
        //sb.AppendLine("        }");
        //sb.AppendLine();
        //sb.AppendLine("        return false;");
        //sb.AppendLine("    }");

        sb.AppendLine("""
            namespace Lucide.Avalonia.Metadata;

            public class LucideIconInfo
            {
                public required LucideIconKind Kind { get; init; }

                public required string[] Contributors { get; init; }

                public required string[] Categories { get; init; }

                public required string[] Tags { get; init; }

                public bool Contains(string? value, out int priority)
                {
                    priority = 0;

                    if (string.IsNullOrEmpty(value))
                    {
                        return true;
                    }

                    value = value.ToLower();

                    var kind = Kind.ToString().ToLower();

                    if (kind == value)
                    {
                        return true;
                    }

                    if (kind.StartsWith(value))
                    {
                        priority = 1;
                        return true;
                    }

                    if (kind.Contains(value))
                    {
                        priority = 2;
                        return true;
                    }

                    foreach (var category in Categories)
                    {
                        if (category.Contains(value))
                        {
                            priority = 3;
                            return true;
                        }
                    }

                    foreach (var tag in Tags)
                    {
                        if (tag.Contains(value))
                        {
                            priority = 4;
                            return true;
                        }
                    }

                    return false;
                }
            """);

        sb.AppendLine();
        sb.AppendLine("    public static LucideIconInfo GetIconInfo(LucideIconKind kind)");
        sb.AppendLine("    {");
        sb.AppendLine("        return kind switch");
        sb.AppendLine("        {");

        foreach (var (name, info) in _icon)
        {
            sb.AppendLine($"            LucideIconKind.{name} => new LucideIconInfo");
            sb.AppendLine("            {");
            sb.AppendLine("                Kind = kind,");
            sb.AppendLine($"                Contributors = [{CreateCSharpStringArray(info.Contributors)}],");
            sb.AppendLine($"                Categories = [{CreateCSharpStringArray(info.Categories)}],");
            sb.AppendLine($"                Tags = [{CreateCSharpStringArray(info.Tags)}],");
            sb.AppendLine("            },");
        }

        sb.AppendLine("            _ => throw new InvalidOperationException(),");
        sb.AppendLine("        };");
        sb.AppendLine("    }");
        sb.AppendLine("}");

        return sb.ToString();
    }

    private static string CreateCSharpStringArray(string[]? values)
    {
        if (values == null || values.Length == 0)
        {
            return string.Empty;
        }

        values = [.. values.Select(x => $"\"{x}\"")];

        return string.Join(", ", values);
    }

    public override string ToString() => Build();
}