using System.Text;

namespace Generator.ReleaseNotes;

public static class ChangeNotesGenerator
{
    private const string IconToGeometryPath = "src/Lucide.Avalonia/IconToGeometry.cs";

    public static ChangeInfo Generate(string headTag)
    {
        var baseTag = new StringBuilder();

        ProcessRunner
            .Create("git")
            .WithArguments($"describe --tags --abbrev=0 {headTag}^")
            .WithRedirectOutput(baseTag)
            .Execute();

        return Generate(headTag, baseTag.ToString().Trim());
    }

    private static ChangeInfo Generate(string headTag, string baseTag)
    {
        Console.WriteLine($"baseTag: {baseTag}");
        Console.WriteLine($"headTag: {headTag}");

        Console.WriteLine("Generating icons changes...");

        var diff = GitDiff.Run(baseTag, headTag, IconToGeometryPath);

        return ChangeInfo.Analyze(diff);
    }
}