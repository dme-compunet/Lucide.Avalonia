using SukiUI.Toasts;

namespace Lucide.Avalonia.Gallery.ViewModels;

[Reactive]
public partial class MainWindowViewModel : ReactiveViewModel
{
    private readonly Lazy<IconViewModel[]> _allIconsLazy = new(IconViewModel.CreateIconCollection);
    private readonly Lazy<FrozenDictionary<LucideIconKind, LucideIconInfo>> _iconsInfo = new(CreateIconCollectionInfo);

    public SukiToastManager ToastManager { get; } = NotificationService.Singleton.ToastManager;

    public partial bool IsBusy { get; set; }

    public partial double Size { get; set; } = 24;

    public partial float StrokeWidth { get; set; } = 1.8f;

    public partial string? SearchText { get; set; }

    public partial IconViewModel[]? Icons { get; set; }

    public MainWindowViewModel()
    {
        this.WhenAnyValue(x => x.Size, x => x.StrokeWidth)
            .Throttle(TimeSpan.FromSeconds(.1))
            .Subscribe(_ => UpdateIcons());

        this.WhenAnyValue(x => x.SearchText)
            .Throttle(TimeSpan.FromSeconds(.4))
            .Subscribe(FilterIconsAsync);

        Task.Run(() =>
        {
            Icons = _allIconsLazy.Value;
        });
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

    private void FilterIcons(string? value)
    {
        var icons = _allIconsLazy.Value;

        var queue = new PriorityQueue<IconViewModel, int>(icons.Length);

        if (string.IsNullOrWhiteSpace(value))
        {
            Icons = icons;

            return;
        }

        value = value.ToLower();

        foreach (var icon in icons)
        {
            var info = _iconsInfo.Value[icon.Kind];

            if (info.Contains(value, out var priority))
            {
                queue.Enqueue(icon, priority);
            }
        }

        var list = new List<IconViewModel>(queue.Count);

        while (queue.Count > 0)
        {
            list.Add(queue.Dequeue());
        }

        Icons = [.. list];
    }

    private async void FilterIconsAsync(string? filter)
    {
        IsBusy = true;

        await Task.Delay(100);

        await Task.Run(() =>
        {
            FilterIcons(filter);
        });

        IsBusy = false;
    }

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
