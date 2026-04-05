using System.Diagnostics;

namespace Generator.ReleaseNotes;

public class LucideIconInfo
{
    public required string Name { get; init; }

    public required string Geometry { get; init; }

    public required string[] Tags { get; init; }

    public required string[] Categories { get; init; }

    public required string[] Contributors { get; init; }

    public static LucideIconInfo[] ReadArray(string data)
    {
        var lines = data.Split(["\r\n", "\n"], StringSplitOptions.None);
        var icons = new List<LucideIconInfo>();

        static string RemovePrefix(string value, string prefix)
        {
            if (value.StartsWith(prefix) == false)
            {
                throw new InvalidOperationException();
            }

            return value[prefix.Length..].Trim();
        }

        for (var i = 0; i + 5 < lines.Length; i += 6)
        {
            var nameLine = lines[i];
            var geometryLine = lines[i + 1];
            var contributorsLine = lines[i + 2];
            var categoriesLine = lines[i + 3];
            var tagsLine = lines[i + 4];

            var name = RemovePrefix(nameLine, "name:");
            var geometry = RemovePrefix(geometryLine, "geometry:");
            var contributors = RemovePrefix(contributorsLine, "contributors:");
            var categories = RemovePrefix(categoriesLine, "categories:");
            var tags = RemovePrefix(tagsLine, "tags:");

            var icon = new LucideIconInfo
            {
                Name = name,
                Geometry = geometry,
                Contributors = contributors.Split(','),
                Categories = categories.Split(','),
                Tags = tags.Split(',')
            };

            icons.Add(icon);
        }

        return [.. icons];

        throw new NotImplementedException();
    }
}