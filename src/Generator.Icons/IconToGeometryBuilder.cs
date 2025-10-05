namespace Generator.Icons;

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

        sb.AppendLine("""
            namespace Lucide.Avalonia;

            internal static class IconToGeometry
            {
                private readonly record struct Entry(LucideIconKind Key, string Geometry);

                private static readonly Dictionary<LucideIconKind, Geometry> _geometryCache = [];
                private static readonly FrozenDictionary<LucideIconKind, string> _geometries;

                static IconToGeometry()
                {
                    Entry[] entries =
                    [
            """);

        foreach (var (name, geometry) in _icons)
        {
            sb.AppendLine($"            new(LucideIconKind.{name}, \"{geometry}\"),");
        }

        sb.AppendLine("""
                    ];

                    _geometries = entries.ToFrozenDictionary(x => x.Key, x => x.Geometry);
                }

                public static string GetGeometryData(LucideIconKind icon) => _geometries[icon];

                public static Geometry CreateGeometry(LucideIconKind icon)
                {
                    if (_geometryCache.TryGetValue(icon, out var geometry))
                    {
                        return geometry;
                    }

                    geometry = Geometry.Parse(GetGeometryData(icon));

                    _geometryCache.Add(icon, geometry);

                    return geometry;
                }
            }
            """);

        return sb.ToString();
    }
}