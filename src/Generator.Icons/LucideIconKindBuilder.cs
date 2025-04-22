using System.Text;

namespace Generator.Icons;

public class LucideIconKindBuilder
{
    private readonly List<string> _icon = [];

    public void AddIcon(string name) => _icon.Add(name);

    public string Build()
    {
        var sb = new StringBuilder();

        sb.AppendLine("namespace Lucide.Avalonia;");
        sb.AppendLine();
        sb.AppendLine("public enum LucideIconKind");
        sb.AppendLine("{");

        foreach (var name in _icon)
        {
            sb.AppendLine($"    {name},");
        }

        sb.AppendLine("}");

        return sb.ToString();
    }

    public override string ToString() => Build();
}