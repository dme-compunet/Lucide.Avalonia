using System.Text;

namespace LucideIcons.Generator;

public class IconToGeometryBuilder
{
    private readonly List<(string Name, string Geometry)> _icons = [];

    public void AddIcon(string name, string path)
    {
        var geometry = GeometryDataGenerator.CreateFromFile(path);

        _icons.Add((name, geometry));
    }

    public string Build()
    {
        var sb = new StringBuilder();

        sb.AppendLine("namespace Lucide.Avalonia;");
        sb.AppendLine();
        sb.AppendLine("internal static class IconToGeometry");
        sb.AppendLine("{");
        sb.AppendLine("    public static string CreateGeometryString(LucideIconKind kind)");
        sb.AppendLine("    {");
        sb.AppendLine("        return kind switch");
        sb.AppendLine("        {");

        foreach (var icon in _icons)
        {
            sb.AppendLine($"            LucideIconKind.{icon.Name} => \"{icon.Geometry}\",");
        }

        sb.AppendLine("            _ => throw new InvalidOperationException()");
        sb.AppendLine("        };");
        sb.AppendLine("    }");
        sb.AppendLine("}");

        return sb.ToString();
    }

    public override string ToString() => Build();
}