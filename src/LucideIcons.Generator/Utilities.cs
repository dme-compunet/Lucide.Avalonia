namespace LucideIcons.Generator;

public static class Utilities
{
    [ThreadStatic]
    private static StringBuilder? _sb;

    public static void NormalizeName(ref string name)
    {
        if (_sb == null)
        {
            _sb = new StringBuilder();
        }
        else
        {
            _sb.Clear();
        }

        var words = name.Split('-');

        foreach (var word in words)
        {
            _sb.Append(char.ToUpper(word[0]));

            if (word.Length > 1)
            {
                _sb.Append(word[1..]);
            }
        }

        name = _sb.ToString();
    }
}