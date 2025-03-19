const LUCIDE_VERSION_CACHE_PATH = '.github/lucide-version'

def get-cache-version [] { 
    open $LUCIDE_VERSION_CACHE_PATH 
}

def get-latest-version [] { 
    http get https://api.github.com/repos/lucide-icons/lucide/releases | get 0.name 
}

def create-new-tag [lucide_version: string] {
    print 'Saving version to cache...'
    $lucide_version | save -f $LUCIDE_VERSION_CACHE_PATH

    git add $LUCIDE_VERSION_CACHE_PATH
    git commit -m "🔄 Update Lucide version"

    print 'Creating new tag...'
    git tag (increment-patch (git describe --tags --abbrev=0))
}

# Increment the patch number in a semantic version (X.Y.Z)
def increment-patch [version: string] {
    # Split the version string into components
    let version_parts = ($version | split row '.')
    
    if ($version_parts | length) != 3 {
        error make {
            msg: 'Invalid version format. Expected X.Y.Z'
        }
    }
    
    let major = ($version_parts | get 0)
    let minor = ($version_parts | get 1)
    let patch = ($version_parts | get 2 | into int) + 1
    
    # Return the new version string
    $"($major).($minor).($patch)"
}

print 'Checking Lucide version updates...'

let cache_version = get-cache-version
let latest_version = get-latest-version

print $'Cache version: ($cache_version)'
print $'Latest version: ($latest_version)'

if $cache_version == $latest_version {
    error make {
        msg: 'No new version available'
    }
}
print 'New version detected'

create-new-tag $latest_version