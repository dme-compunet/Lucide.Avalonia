const project_path = "src/Lucide.Avalonia/Lucide.Avalonia.csproj"

let repo_name = $env.REPO_NAME
let nuget_api_key = $env.NUGET_API_KEY
let version = git describe --tags --abbrev=0

# Build and pack library
dotnet build -c Release $project_path -p:Version=($version)
dotnet pack -c Release $project_path -o . -p:Version=($version)

# Push NuGet package
dotnet nuget push *.nupkg --api-key $nuget_api_key --source https://api.nuget.org/v3/index.json --skip-duplicate

# Create GitHub Release with the tag name
gh release create $version --repo $repo_name --title $version --fail-on-no-commits --generate-notes --verify-tag

# Upload Release assets
gh workflow run release-gallery.yml --field release_tag_name=($version)
