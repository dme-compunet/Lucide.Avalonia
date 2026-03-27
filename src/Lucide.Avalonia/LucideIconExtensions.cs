namespace Lucide.Avalonia;

public static class LucideIconExtensions
{
    public static string GetGeometryData(this LucideIconKind kind) => IconGeometryProvider.GetGeometryData(kind);

    public static LucideIconMetadata GetMetadata(this LucideIconKind kind) => IconMetadataProvider.GetMetadata(kind);
}