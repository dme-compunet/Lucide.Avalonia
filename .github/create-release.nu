const project_path = "src/Lucide.Avalonia/Lucide.Avalonia.csproj"
const gallery_project_path = "src/Lucide.Avalonia.Gallery/Lucide.Avalonia.Gallery.csproj"

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

# Build and zip gallery (native-aot)
dotnet publish $gallery_project_path -c Release -r win-x64 -o bin/
7z a icons-gallery.7z bin\*.exe bin\*.dll

# Add gallery to GitHub Release assets
gh release upload $version "icons-gallery.7z#'Icons-Gallery (NativeAOT)'"