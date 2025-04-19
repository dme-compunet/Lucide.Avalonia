namespace Lucide.Avalonia.Gallery.ViewModels;

[Reactive]
public partial class IconViewModel(LucideIconKind kind)
{
    public LucideIconKind Kind { get; } = kind;

    public partial double Size { get; set; } = 24;

    public partial double StrokeWidth { get; set; } = 1.5;

    public string Tip => $"{Kind}";

    public void CopyNameCommand() => SetClipboard($"{Kind}");

    public void CopyXamlCommand() => SetClipboard($"<LucideIcon Kind=\"{Kind}\"/>");

    public void CopyExtensionCommand() => SetClipboard($"{{LucideIconContent {Kind}}}");

    //private string BuildTipText()
    //{
    //    var sb = new StringBuilder();

    //    var info = LucideIconInfo.GetIconInfo(Kind);

    //    sb.AppendLine($"{Kind}");
    //    sb.AppendLine();
    //    sb.AppendLine("Contributors:");

    //    foreach (var contributor in info.Contributors)
    //    {
    //        sb.AppendLine($"    {contributor}");
    //    }

    //    sb.AppendLine();
    //    sb.AppendLine("Categories:");

    //    foreach (var category in info.Categories)
    //    {
    //        sb.AppendLine($"    {category}");
    //    }

    //    sb.AppendLine();
    //    sb.AppendLine("Tags:");

    //    foreach (var tag in info.Tags)
    //    {
    //        sb.AppendLine($"    {tag}");
    //    }

    //    return sb.ToString();
    //}

    private static async void SetClipboard(string text)
    {
        await ClipboardService.Instance.SetClipboardAsync(text);

        NotificationService.Singleton.ShowNotification("Icon Copied!", $"The text \"{text}\" has been copied to clipboard.");
    }

    public static IconViewModel[] CreateIconCollection()
    {
        var kinds = Enum.GetValues<LucideIconKind>();

        var icons = new IconViewModel[kinds.Length];

        for (int i = 0; i < kinds.Length; i++)
        {
            icons[i] = new IconViewModel(kinds[i]);
        }

        return icons;
    }
}
