namespace Generator.Icons;

public class LucideIconInfo
{
    public required string Name { get; init; }

    public required string Geometry { get; init; }

    public required string[] Tags { get; init; }

    public required string[] Categories { get; init; }

    public required string[] Contributors { get; init; }

    public static LucideIconInfo[] ReadArrayFromFile(string path)
    {
        var lines = File.ReadAllLines(path);
        var icons = new List<LucideIconInfo>();

        static string RemovePrefix(string value, string prefix)
        {
            if (value.StartsWith(prefix) == false)
            {
                throw new InvalidOperationException();
            }

            return value[prefix.Length..].Trim();
        }

        for (var i = 0; i < lines.Length; i += 6)
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
    }

    public static void WriteArrayToFile(LucideIconInfo[] icons, string path)
    {
        using var stream = File.Create(path);
        using var writer = new StreamWriter(stream);

        foreach (var icon in icons)
        {
            writer.WriteLine("name:         " + icon.Name);
            writer.WriteLine("geometry:     " + icon.Geometry);
            writer.WriteLine("contributors: " + string.Join(',', icon.Contributors));
            writer.WriteLine("categories:   " + string.Join(',', icon.Categories));
            writer.WriteLine("tags:         " + string.Join(',', icon.Tags));
            writer.WriteLine();
        }
    }
}
