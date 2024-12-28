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

    public static readonly StyledProperty<LucideIconKind?> KindProperty =
        AvaloniaProperty.Register<LucideIcon, LucideIconKind?>(nameof(Kind));

    private Pen? _stroke;
    private Geometry? _geometry;

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
    public LucideIconKind? Kind
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

    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        if (change.Property == KindProperty)
        {
            var kind = change.GetNewValue<LucideIconKind?>();

            _geometry = kind == null
                        ? null
                        : IconToGeometry.CreateGeometry(kind.Value);
        }
        else if (change.Property == ForegroundProperty || change.Property == StrokeWidthProperty)
        {
            var brush = Foreground;
            var width = StrokeWidth;

            if (_stroke == null)
            {
                _stroke = new Pen(brush, width, null, PenLineCap.Round, PenLineJoin.Round);
            }
            else
            {
                _stroke.Brush = brush;
                _stroke.Thickness = width;
            }
        }

        base.OnPropertyChanged(change);
    }

    protected override Size MeasureOverride(Size availableSize) => GetIconSize();

    protected override Size ArrangeOverride(Size finalSize) => GetIconSize();

    public override void Render(DrawingContext context)
    {
        if (_geometry is null)
        {
            return;
        }

        AddScale(context);

        context.DrawRectangle(Brushes.Transparent, null, new Rect(0, 0, Bounds.Width, Bounds.Height));

        context.DrawGeometry(null, _stroke, _geometry);
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
