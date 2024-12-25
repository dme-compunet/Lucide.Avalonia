namespace Lucide.Avalonia.Gallery.ViewModels;

[Reactive]
public partial class MainWindowViewModel : ReactiveViewModel
{
    private readonly Lazy<IconViewModel[]> _icons = new(IconViewModel.CreateIconCollection);
    private readonly Lazy<FrozenDictionary<LucideIconKind, LucideIconInfo>> _iconsInfo = new(CreateIconCollectionInfo);

    public partial double Size { get; set; } = 24;

    public partial float StrokeWidth { get; set; } = 1.5f;

    public partial string? SearchText { get; set; }

    public partial IEnumerable<IconViewModel>? Icons { get; set; }

    public MainWindowViewModel()
    {
        this.WhenAnyValue(x => x.Size, x => x.StrokeWidth)
            .Throttle(TimeSpan.FromSeconds(.1))
            .Subscribe(_ => UpdateIcons());

        this.WhenAnyValue(x => x.SearchText)
            .Throttle(TimeSpan.FromSeconds(.2))
            .Subscribe(async x => Icons = await FilterIconsAsync(x));

        Task.Run(() => Icons = _icons.Value);
    }

    public void ResetCommand()
    {
        Size = 24;
        StrokeWidth = 1.5f;
    }

    public void SwitchBaseThemeCommand() => SukiTheme.GetInstance().SwitchBaseTheme();

    private void UpdateIcons()
    {
        if (Icons == null)
        {
            return;
        }

        foreach (var icon in Icons)
        {
            icon.Size = Size;
            icon.StrokeWidth = StrokeWidth;
        }
    }

    private IconViewModel[] FilterIcons(string? value)
    {
        var icons = _icons.Value;
        var result = new List<IconViewModel>(icons.Length);

        if (string.IsNullOrWhiteSpace(value))
        {
            return icons;
        }

        value = value.ToLower();

        foreach (var icon in icons)
        {
            var info = _iconsInfo.Value[icon.Kind];

            if (info.Contains(value))
            {
                result.Add(icon);
            }
        }

        return [.. result];
    }

    private Task<IconViewModel[]> FilterIconsAsync(string? filter) => Task.Run(() => FilterIcons(filter));

    private static FrozenDictionary<LucideIconKind, LucideIconInfo> CreateIconCollectionInfo()
    {
        var kinds = Enum.GetValues<LucideIconKind>();

        var result = new Dictionary<LucideIconKind, LucideIconInfo>(kinds.Length);

        foreach (var kind in kinds)
        {
            result[kind] = LucideIconInfo.GetIconInfo(kind);
        }

        return result.ToFrozenDictionary();
    }
}
