namespace Lucide.Avalonia;

internal static class IconGeometryProvider
{
    private static readonly Dictionary<LucideIconKind, Geometry> _cache = [];
    private static readonly Lazy<FrozenDictionary<LucideIconKind, string>> _data = new(Initialize);

    public static string GetGeometryData(LucideIconKind icon) => _data.Value[icon];

    public static Geometry GetGeometry(LucideIconKind icon)
    {
        if (_cache.TryGetValue(icon, out var geometry))
        {
            return geometry;
        }

        geometry = Geometry.Parse(GetGeometryData(icon));

        _cache.Add(icon, geometry);

        return geometry;
    }

    private static FrozenDictionary<LucideIconKind, string> Initialize()
    {
        using var stream = EmbeddedResource.Open("icons.bin");
        using var reader = new BinaryReader(stream);

        try
        {
            var count = Enum.GetNames<LucideIconKind>().Length;
            var dictionary = new Dictionary<LucideIconKind, string>(count);

            for (var index = 0; index < count; index++)
            {
                var key = (LucideIconKind)index;
                var path = reader.ReadString();

                dictionary.Add(key, path);
            }

            return dictionary.ToFrozenDictionary();
        }
        catch (Exception ex)
        {
            throw new InvalidDataException("The icon binary file is corrupted or in an invalid format.", ex);
        }
    }
}