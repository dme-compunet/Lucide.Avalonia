namespace Lucide.Avalonia;

internal static class IconMetadataProvider
{
    private static readonly Lazy<FrozenDictionary<LucideIconKind, LucideIconMetadata>> _data = new(Initialize);

    public static LucideIconMetadata GetMetadata(LucideIconKind icon) => _data.Value[icon];

    private static FrozenDictionary<LucideIconKind, LucideIconMetadata> Initialize()
    {
        using var stream = EmbeddedResource.Open("metadata.bin");
        using var reader = new BinaryReader(stream);

        try
        {
            var count = Enum.GetNames<LucideIconKind>().Length;
            var dictionary = new Dictionary<LucideIconKind, LucideIconMetadata>(count);

            for (var index = 0; index < count; index++)
            {
                var key = (LucideIconKind)index;

                var contributors = reader.ReadString();
                var categories = reader.ReadString();
                var tags = reader.ReadString();

                var metadata = new LucideIconMetadata
                {
                    Kind = key,
                    Contributors = contributors.Split(','),
                    Categories = categories.Split(","),
                    Tags = tags.Split(",")
                };

                dictionary.Add(key, metadata);
            }

            return dictionary.ToFrozenDictionary();
        }
        catch (Exception ex)
        {
            throw new InvalidDataException("The icon binary file is corrupted or in an invalid format.", ex);
        }
    }
}
