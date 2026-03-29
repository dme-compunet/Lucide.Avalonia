namespace Lucide.Avalonia;

public static class EmbeddedResource
{
    public static Stream Open(string resourceName)
    {
        var assembly = typeof(EmbeddedResource).Assembly;

        var stream = assembly.GetManifestResourceStream($"Lucide.Avalonia.Resources.{resourceName}")
                     ??
                     throw new InvalidOperationException($"Icon resource not found. Ensure '{resourceName}' is set as EmbeddedResource and located in the 'Resources' folder.");

        return new BrotliStream(stream, CompressionMode.Decompress);
    }
}