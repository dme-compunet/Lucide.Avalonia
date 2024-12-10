namespace Lucide.Avalonia.Gallery.Services;

public class ClipboardService
{
    private readonly IClipboard? _clipboard;

    public static ClipboardService Instance { get; } = new();

    public ClipboardService()
    {
        if (Application.Current?.ApplicationLifetime
            is IClassicDesktopStyleApplicationLifetime lifetime)
        {
            _clipboard = lifetime.MainWindow?.Clipboard;
        }
    }

    public async Task SetClipboardAsync(string value)
    {
        if (_clipboard != null)
        {
            await _clipboard.SetTextAsync(value);
        }
    }
}
