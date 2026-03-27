namespace Lucide.Avalonia;

public class LucideIconMetadata
{
    public required LucideIconKind Kind { get; init; }

    public required string[] Contributors { get; init; }

    public required string[] Categories { get; init; }

    public required string[] Tags { get; init; }

    public bool Contains(string? value, out int priority)
    {
        priority = 0;

        if (string.IsNullOrEmpty(value))
        {
            return true;
        }

        value = value.ToLower();

        var kind = Kind.ToString().ToLower();

        if (kind == value)
        {
            return true;
        }

        if (kind.StartsWith(value))
        {
            priority = 1;
            return true;
        }

        if (kind.Contains(value))
        {
            priority = 2;
            return true;
        }

        foreach (var category in Categories)
        {
            if (category.Contains(value))
            {
                priority = 3;
                return true;
            }
        }

        foreach (var tag in Tags)
        {
            if (tag.Contains(value))
            {
                priority = 4;
                return true;
            }
        }

        return false;
    }
}
