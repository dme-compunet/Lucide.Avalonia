using Octokit;

namespace Generator.ReleaseNotes;

public static class GitHubReleaseNotesUpdater
{
    public static async Task UpdateReleaseNotes(string tagName, string releaseNotesMarkdown)
    {
        Console.WriteLine("Updating GitHub release notes...");

        var token = Environment.GetEnvironmentVariable("GITHUB_TOKEN");
        var repositoryId = long.Parse(Environment.GetEnvironmentVariable("REPOSITORY_ID")
                                      ??
                                      throw new InvalidOperationException());
        
        var github = new GitHubClient(new ProductHeaderValue("release-notes-updater"))
        {
            Credentials = new Credentials(token)
        };

        var release = await github.Repository.Release.Get(repositoryId, tagName);

        var updateRelease = release.ToUpdate();

        updateRelease.Body = releaseNotesMarkdown + release.Body;

        _ = await github.Repository.Release.Edit(repositoryId, release.Id, updateRelease);

        Console.WriteLine("Release notes updated successfully.");
    }
}