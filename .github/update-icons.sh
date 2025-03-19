git config --global user.name 'github-actions[bot]'
git config --global user.email 'github-actions[bot]@users.noreply.github.com'
git add ./src/Lucide.Avalonia/IconToGeometry.cs
git add ./src/Lucide.Avalonia/LucideIconKind.cs
git add ./src/Lucide.Avalonia/Metadata/LucideIconInfo.cs
if [ -n "$(git diff --cached --name-only)" ]; then
    git commit -m "🔄 Update Icon Collection"
    nu .github/create-tag.nu
    git push origin master --follow-tags
else
    echo "No changes to commit"
fi