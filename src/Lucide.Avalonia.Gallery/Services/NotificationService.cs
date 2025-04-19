using SukiUI.Toasts;

namespace Lucide.Avalonia.Gallery.Services;

public class NotificationService
{
    public static NotificationService Singleton { get; } = new();

    public SukiToastManager ToastManager { get; } = new();

    public void ShowNotification(string title, string message)
    {
        ToastManager.CreateSimpleInfoToast()
                    .WithTitle(title)
                    .WithContent(message)
                    .Queue();
    }
}
