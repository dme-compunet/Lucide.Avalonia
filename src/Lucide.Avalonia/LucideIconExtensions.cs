namespace Lucide.Avalonia;

public static class LucideIconExtensions
{
    public static string GetGeometryData(this LucideIconKind kind) => IconToGeometry.GetGeometryData(kind);
}
