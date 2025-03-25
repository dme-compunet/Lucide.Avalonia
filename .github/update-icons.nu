def generate-and-commit [] {
    # Clone the lucide library repo
    # git clone https://github.com/lucide-icons/lucide.git
    http get https://github.com/lucide-icons/lucide/archive/refs/heads/main.zip | save lucide-latest.zip
    unzip lucide-latest.zip    
    
    # Run the generator
    dotnet restore ./src/LucideIcons.Generator
    dotnet run --project ./src/LucideIcons.Generator ./lucide-main ./src/Lucide.Avalonia/

    rm lucide-main -r

    # Verify generated code
    dotnet build ./src/Lucide.Avalonia/
    
    # Configure git user details
    git config --global user.name 'github-actions[bot]'
    git config --global user.email 'github-actions[bot]@users.noreply.github.com'
    
    # Add changed files to git
    git add ./src/Lucide.Avalonia/IconToGeometry.cs
    git add ./src/Lucide.Avalonia/LucideIconKind.cs
    git add ./src/Lucide.Avalonia/Metadata/LucideIconInfo.cs
}

def increment-version [version: string] {
    let version_parts = ($version | split row '.')
    
    if ($version_parts | length) != 3 {
        error make {
            msg: 'Invalid version format. Expected X.Y.Z'
        }
    }
    
    let major = ($version_parts | get 0)
    let minor = ($version_parts | get 1)
    let patch = ($version_parts | get 2 | into int) + 1
    
    $"($major).($minor).($patch)"
}

generate-and-commit

# Check if there are staged changes
let has_changes = (git diff --cached --name-only | str length) > 0

if $has_changes {
    git commit -m "🔄 Update Icon Collection"
    git tag (increment-version (git describe --tags --abbrev=0))
    git push --follow-tags

    source create-release.nu
} else {
    print "No changes to commit"
}

