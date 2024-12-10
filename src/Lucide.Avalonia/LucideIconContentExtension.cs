namespace Lucide.Avalonia;

public class LucideIconContentExtension : MarkupExtension
{
    public LucideIconKind Kind { get; set; }

    public double? Size { get; set; }

    public double? StrokeWidth { get; set; }

    public LucideIconContentExtension() { }

    public LucideIconContentExtension(LucideIconKind kind) => Kind = kind;

    public LucideIconContentExtension(LucideIconKind kind, double size)
    {
        Kind = kind;
        Size = size;
    }

    public LucideIconContentExtension(LucideIconKind kind, double size, double strokeWidth)
    {
        Kind = kind;
        Size = size;
        StrokeWidth = strokeWidth;
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        var icon = new LucideIcon
        {
            Kind = Kind,
        };

        if (Size.HasValue)
        {
            icon.Size = Size.Value;
        }

        if (StrokeWidth.HasValue)
        {
            icon.StrokeWidth = StrokeWidth.Value;
        }

        return icon;
    }
}