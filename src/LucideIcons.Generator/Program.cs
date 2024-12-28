Console.WriteLine("Starting the icon generation process...");

if (args.Length != 2)
{
    ExitWithError("Two arguments are required: <lucide-repository-path> and <generated-cs-files-path>.");
}

var lucideRepositoryPath = args[0];
var generatedCsFilesPath = args[1];

if (Directory.Exists(generatedCsFilesPath) == false)
{
    ExitWithError($"The directory '{generatedCsFilesPath}' does not exist.");
}

lucideRepositoryPath = Path.Combine(lucideRepositoryPath, "icons");

if (Directory.Exists(lucideRepositoryPath) == false)
{
    ExitWithError($"The directory '{lucideRepositoryPath}' does not exist.");
}

var paths = Directory.GetFiles(lucideRepositoryPath, "*.svg");

if (paths.Length == 0)
{
    ExitWithError("No SVG files found in the specified directory.");
}

paths = [.. paths.OrderBy(path => Path.GetFileNameWithoutExtension(path))];

var iconKindBuilder = new LucideIconKindBuilder();
var iconInfoBuilder = new LucideIconInfoBuilder();
var iconToGeometryBuilder = new IconToGeometryBuilder();

foreach (var path in paths)
{
    var name = Path.GetFileNameWithoutExtension(path);

    Utilities.NormalizeName(ref name);

    Console.WriteLine($"Creating icon: {name}");

    iconKindBuilder.AddIcon(name);
    iconInfoBuilder.AddIcon(name, path);
    iconToGeometryBuilder.AddIcon(name, path);
}

var iconKindPath = Path.Combine(generatedCsFilesPath, "LucideIconKind.cs");
var iconInfoPath = Path.Combine(generatedCsFilesPath, "Metadata", "LucideIconInfo.cs");
var iconToGeometryPath = Path.Combine(generatedCsFilesPath, "IconToGeometry.cs");

Console.WriteLine("Writing generated files...");

File.WriteAllText(iconKindPath, iconKindBuilder.Build());
File.WriteAllText(iconInfoPath, iconInfoBuilder.Build());
File.WriteAllText(iconToGeometryPath, iconToGeometryBuilder.Build());

Console.WriteLine("Icon generation process completed.");

static void ExitWithError(string message)
{
    Console.Error.WriteLine(message);

    Environment.Exit(1);
}