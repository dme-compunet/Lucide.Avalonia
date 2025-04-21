using System.Text;
using System.Text.RegularExpressions;

namespace Generator.ReleaseNotes;

public partial class ChangeInfo
{
    public required string[] AddedIcons { get; init; }

    public required string[] ModifiedIcons { get; init; }

    public string MarkdownText => CreateMarkdown();

    public static ChangeInfo Analyze(GitDiff iconToGeometryDiff)
    {
        var addedLines = iconToGeometryDiff.AddedLines;
        var removedLines = iconToGeometryDiff.RemovedLines;

        var addedIcons = addedLines.Select(ExtractIconName).ToArray();
        var removedIcons = removedLines.Select(ExtractIconName).ToArray();

        var newIcons = addedIcons.Except(removedIcons).ToArray();
        var modifiedIcons = removedIcons.Intersect(addedIcons).ToArray();

        return new ChangeInfo
        {
            AddedIcons = newIcons,
            ModifiedIcons = modifiedIcons
        };
    }

    private string CreateMarkdown()
    {
        var builder = new StringBuilder();

        if (AddedIcons.Length > 0)
        {
            builder.AppendLine("## New icons 🎨");

            foreach (var addedIcon in AddedIcons)
            {
                var link = CreateLinkToWeb(addedIcon);

                builder.AppendLine($"- The `{addedIcon}` icon is added ({link})");
            }

            builder.AppendLine();
        }

        if (ModifiedIcons.Length > 0)
        {
            builder.AppendLine("## Modified Icons 🔨");

            foreach (var modifiedIcon in ModifiedIcons)
            {
                var link = CreateLinkToWeb(modifiedIcon);

                builder.AppendLine($"- The `{modifiedIcon}` icon is modified ({link})");
            }

            builder.AppendLine();
        }

        return builder.ToString();
    }

    private static string CreateLinkToWeb(string iconName)
    {
        var name = NormalizeName(iconName);
        var link = $"https://lucide.dev/icons/{name}";

        return $"[{name}]({link})";
    }

    /// <summary>
    /// Change 'IconName' to 'icon-name'
    /// </summary>
    /// <param name="name">The icon name to normalize (PascalCase)</param>
    /// <returns>The normalized icon name (kebab-case)</returns>
    private static string NormalizeName(string name)
    {
        var result = new StringBuilder();

        result.Append(char.ToLower(name[0]));

        for (var i = 1; i < name.Length; i++)
        {
            var character = name[i];

            if (char.IsUpper(character) || char.IsNumber(character))
            {
                result.Append('-');
                result.Append(char.ToLower(character));
            }
            else
            {
                result.Append(character);
            }
        }

        return result.ToString();
    }

    private static string ExtractIconName(string line)
    {
        var match = IconNameRegex().Match(line);

        if (match.Success == false)
        {
            throw new Exception("Could not extract icon name");
        }

        return match.Groups[1].Value;
    }

    [GeneratedRegex(@"LucideIconKind\.(\w+)")]
    private static partial Regex IconNameRegex();
}