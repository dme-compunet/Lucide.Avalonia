Utilities.DownloadSvgIcons();

var root = "lucide/icons";
var destination = "../Lucide.Avalonia/";

var sb = new StringBuilder();

var paths = Directory.GetFiles(root, "*.svg");

if (paths.Length == 0)
{
    throw new InvalidOperationException();
}

var iconKindBuilder = new LucideIconKindBuilder();
var iconInfoBuilder = new LucideIconInfoBuilder();
var iconToGeometryBuilder = new IconToGeometryBuilder();

foreach (var path in paths)
{
    var name = Path.GetFileNameWithoutExtension(path);

    Utilities.NormalizeName(ref name, sb);

    Console.WriteLine(name);

    iconKindBuilder.AddIcon(name);
    iconInfoBuilder.AddIcon(name, path);
    iconToGeometryBuilder.AddIcon(name, path);
}

var iconKindPath = Path.Combine(destination, "LucideIconKind.cs");
var iconInfoPath = Path.Combine(destination, "LucideIconInfo.cs");
var iconToGeometryPath = Path.Combine(destination, "IconToGeometry.cs");

File.WriteAllText(iconKindPath, iconKindBuilder.Build());
File.WriteAllText(iconInfoPath, iconInfoBuilder.Build());
File.WriteAllText(iconToGeometryPath, iconToGeometryBuilder.Build());
