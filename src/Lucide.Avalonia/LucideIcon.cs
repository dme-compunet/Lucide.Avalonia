namespace Lucide.Avalonia;

public class LucideIcon : Control
{
    private const float RawIconSize = 24;

    public static readonly StyledProperty<double> SizeProperty =
        AvaloniaProperty.Register<LucideIcon, double>(nameof(Size), 24);

    public static readonly StyledProperty<IBrush?> ForegroundProperty =
        TextElement.ForegroundProperty.AddOwner<LucideIcon>();

    public static readonly StyledProperty<double> StrokeWidthProperty =
        AvaloniaProperty.Register<LucideIcon, double>(nameof(StrokeWidth), 1.5);

    public static readonly StyledProperty<LucideIconKind> KindProperty =
        AvaloniaProperty.Register<LucideIcon, LucideIconKind>(nameof(Kind));

    private readonly Pen _strokePen;
    private Geometry _geometry;

    public double Size
    {
        get => GetValue(SizeProperty);
        set => SetValue(SizeProperty, value);
    }

    public IBrush? Foreground
    {
        get => GetValue(ForegroundProperty);
        set => SetValue(ForegroundProperty, value);
    }

    public double StrokeWidth
    {
        get => GetValue(StrokeWidthProperty);
        set => SetValue(StrokeWidthProperty, value);
    }
    public LucideIconKind Kind
    {
        get => GetValue(KindProperty);
        set => SetValue(KindProperty, value);
    }


    static LucideIcon()
    {
        AffectsRender<LucideIcon>(KindProperty,
                                  SizeProperty,
                                  ForegroundProperty,
                                  StrokeWidthProperty);

        AffectsMeasure<LucideIcon>(SizeProperty);
    }

    public LucideIcon()
    {
        _geometry = Geometry.Parse(IconToGeometry.CreateGeometryString(Kind));
        _strokePen = new Pen(Foreground, StrokeWidth, null, PenLineCap.Round, PenLineJoin.Round);
    }

    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        if (change.Property == KindProperty)
        {
            var kind = change.GetNewValue<LucideIconKind>();

            _geometry = Geometry.Parse(IconToGeometry.CreateGeometryString(kind));
        }
        else if (change.Property == ForegroundProperty || change.Property == StrokeWidthProperty)
        {
            _strokePen.Brush = Foreground;
            _strokePen.Thickness = StrokeWidth;
        }

        base.OnPropertyChanged(change);
    }

    protected override Size MeasureOverride(Size availableSize) => GetIconSize();

    protected override Size ArrangeOverride(Size finalSize) => GetIconSize();

    public override void Render(DrawingContext context)
    {
        AddScale(context);

        context.DrawRectangle(Brushes.Transparent, null, new Rect(0, 0, Bounds.Width, Bounds.Height));

        context.DrawGeometry(null, _strokePen, _geometry);
    }

    private void AddScale(DrawingContext context)
    {
        if (IsSet(SizeProperty))
        {
            var scale = Size / RawIconSize;

            context.PushTransform(Matrix.CreateScale(scale, scale));
        }
    }

    private Size GetIconSize() => new(Size, Size);
}
