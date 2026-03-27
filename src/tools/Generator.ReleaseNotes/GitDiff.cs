using System.Text;

namespace Generator.ReleaseNotes;

public class GitDiff
{
    public static GitDiff Run(string baseCommit, string headCommit, string path)
    {
        var output = new StringBuilder();

        ProcessRunner.Create("git")
            .WithArguments($"diff {baseCommit} {headCommit} -- {path}")
            .WithRedirectOutput(output)
            .Execute();

        return new GitDiff(output.ToString());
    }

    public string[] AddedLines { get; }

    public string[] RemovedLines { get; }

    private GitDiff(string diff)
    {
        var lines = diff.Split(['\n', '\r']);

        var added = new List<string>();
        var removed = new List<string>();

        foreach (var line in lines)
        {
            if (line.StartsWith('+') && line.StartsWith("+++") == false)
            {
                added.Add(line);
            }

            if (line.StartsWith('-') && line.StartsWith("---") == false)
            {
                removed.Add(line);
            }
        }

        AddedLines = [.. added];
        RemovedLines = [.. removed];
    }
}