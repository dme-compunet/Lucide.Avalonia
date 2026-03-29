using Generator.ReleaseNotes;

if (args.Length == 0)
{
    throw new InvalidOperationException("No arguments were provided.");
}

var tagName = args[0];

var changeInfo = ChangeNotesGenerator.Generate(tagName);

Console.WriteLine("===== Release Notes Preview =====");

Console.WriteLine(changeInfo.MarkdownText);

await GitHubReleaseNotesUpdater.UpdateReleaseNotes(tagName, changeInfo.MarkdownText);
