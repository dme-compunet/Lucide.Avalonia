using System.Text;

namespace Generator.ReleaseNotes;

public static class ChangeNotesGenerator
{
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

        var baseTagIconData = new StringBuilder();
        var headTagIconData = new StringBuilder();

        ProcessRunner.Create("git")
                     .WithArguments($"show {baseTag}:icons/lucide-icons.txt")
                     .WithRedirectOutput(baseTagIconData)
                     .Execute();

        ProcessRunner.Create("git")
                     .WithArguments($"show {headTag}:icons/lucide-icons.txt")
                     .WithRedirectOutput(headTagIconData)
                     .Execute();

        var baseTagIcons = LucideIconInfo.ReadArray(baseTagIconData.ToString());
        var headTagIcons = LucideIconInfo.ReadArray(headTagIconData.ToString());

        return ChangeInfo.Analyze(baseTagIcons, headTagIcons);
    }
}