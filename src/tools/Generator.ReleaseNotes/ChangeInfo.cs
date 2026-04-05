using System.Text;

namespace Generator.ReleaseNotes;

public class ChangeInfo
{
    public required string[] AddedIcons { get; init; }

    public required string[] RemovedIcons { get; init; }

    public required string[] ModifiedIcons { get; init; }

    public string MarkdownText => CreateMarkdown();

    public static ChangeInfo Analyze(LucideIconInfo[] oldIcons, LucideIconInfo[] newIcons)
    {
        var oldIconNames = oldIcons.Select(i => i.Name).ToHashSet();
        var newIconNames = newIcons.Select(i => i.Name).ToHashSet();

        var oldIconGeometry = oldIcons.ToDictionary(i => i.Name, i => i.Geometry);

        var modifiedIcons = newIcons
            .Where(i => oldIconGeometry.TryGetValue(i.Name, out var oldGeometry) && oldGeometry != i.Geometry)
            .Select(i => i.Name)
            .ToArray();

        return new ChangeInfo
        {
            AddedIcons = [.. newIconNames.Except(oldIconNames)],
            RemovedIcons = [.. oldIconNames.Except(newIconNames)],
            ModifiedIcons = modifiedIcons
        };
    }

    private string CreateMarkdown()
    {
        var builder = new StringBuilder();

        if (AddedIcons.Length > 0)
        {
            builder.AppendLine("## New icons 🎨");

            foreach (var icon in AddedIcons)
            {
                var link = CreateLinkToWeb(icon);

                builder.AppendLine($"- The `{icon}` icon is added ({link})");
            }

            builder.AppendLine();
        }

        if (RemovedIcons.Length > 0)
        {
            builder.AppendLine("## Removed Icons 🗑️");

            foreach (var icon in RemovedIcons)
            {
                builder.AppendLine($"- The `{icon}` icon is removed");
            }

            builder.AppendLine();
        }

        if (ModifiedIcons.Length > 0)
        {
            builder.AppendLine("## Modified Icons 🔨");

            foreach (var icon in ModifiedIcons)
            {
                var link = CreateLinkToWeb(icon);

                builder.AppendLine($"- The `{icon}` icon is modified ({link})");
            }

            builder.AppendLine();
        }

        return builder.ToString();
    }

    private static string CreateLinkToWeb(string iconName)
    {
        var name = PascalToKebab(iconName);
        var link = $"https://lucide.dev/icons/{name}";

        return $"[{name}]({link})";
    }

    private static string PascalToKebab(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return input;
        }

        var sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            var c = input[i];

            if (char.IsUpper(c) && i > 0)
            {
                sb.Append('-');
            }

            sb.Append(char.ToLower(c));
        }

        return sb.ToString();
    }
}