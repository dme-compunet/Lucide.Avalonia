using System.Text.Json;
using Generator.Icons.Utilities;

namespace Generator.Icons;

/// <summary>
/// Generates a text file containing icon definitions and metadata
/// from the original Lucide repository.
/// </summary>
public class GenerateCommand
{
    #region Json

    private record InfoJson(string[] Contributors, string[] Categories, string[] Tags);

    private readonly JsonSerializerOptions _jsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
    };

    #endregion

    /// <summary>
    /// Root path of the original Lucide repository containing SVG icons.
    /// </summary>
    public required string InputPath { get; init; }

    /// <summary>
    /// Output path for the generated text file containing icon definitions.
    /// </summary>
    public required string OutputPath { get; init; }

    public void Execute()
    {
        if (!Directory.Exists(InputPath))
        {
            throw new DirectoryNotFoundException($"The directory '{InputPath}' does not exist.");
        }

        Console.WriteLine("Generating icons...");

        var svgIconsDirectory = Path.Combine(InputPath, "icons");

        EnsureDirectoryExists(svgIconsDirectory);

        var icons = Directory.GetFiles(svgIconsDirectory, "*.svg")
                             .OrderBy(Path.GetFileName)
                             .Select(CreateIconInfo)
                             .ToArray();

        if (icons.Length == 0)
        {
            throw new InvalidOperationException($"No SVG files found in '{svgIconsDirectory}' directory.");
        }

        WriteIcons(icons);
    }

    private void WriteIcons(LucideIconInfo[] icons)
    {
        Console.WriteLine("Writing icons...");

        using var stream = File.Create(OutputPath);
        using var writer = new StreamWriter(stream);

        foreach (var icon in icons)
        {
            writer.WriteLine("name:         " + icon.Name);
            writer.WriteLine("geometry:     " + icon.Geometry);
            writer.WriteLine("contributors: " + string.Join(',', icon.Contributors));
            writer.WriteLine("categories:   " + string.Join(',', icon.Categories));
            writer.WriteLine("tags:         " + string.Join(',', icon.Tags));
            writer.WriteLine();
        }
    }

    private LucideIconInfo CreateIconInfo(string pathToSvg)
    {
        var name = Path.GetFileNameWithoutExtension(pathToSvg);

        var geometry = SvgToGeometryConverter.GenerateFromFile(pathToSvg);
        var infoJsonText = File.ReadAllText(pathToSvg.Replace(".svg", ".json"));
        var info = JsonSerializer.Deserialize<InfoJson>(infoJsonText, _jsonOptions) ?? throw new JsonException();

        return new LucideIconInfo
        {
            Name = name,
            Geometry = geometry,
            Tags = info.Tags,
            Categories = info.Categories,
            Contributors = info.Contributors,
        };
    }
    private static void EnsureDirectoryExists(string directory)
    {
        if (!Directory.Exists(directory))
        {
            throw new DirectoryNotFoundException($"The directory '{directory}' does not exist.");
        }
    }
}