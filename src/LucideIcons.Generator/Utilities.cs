namespace LucideIcons.Generator;

public static class Utilities
{
    public static void NormalizeName(ref string name, StringBuilder builder)
    {
        builder.Clear();

        var words = name.Split('-');

        foreach (var word in words)
        {
            builder.Append(char.ToUpper(word[0]));

            if (word.Length > 1)
            {
                builder.Append(word[1..]);
            }
        }

        name = builder.ToString();
    }

    public static void DownloadSvgIcons()
    {
        if (Directory.Exists("lucide/icons"))
        {
            Console.WriteLine("The icons already exist, to re-download delete the folder 'lucide'");
            return;
        }

        RunCommand("git", "clone --no-checkout https://github.com/lucide-icons/lucide.git");
        RunCommand("git", "sparse-checkout init --cone", "lucide");
        RunCommand("git", "sparse-checkout set icons", "lucide");
        RunCommand("git", "checkout", "lucide");
    }

    public static void RunCommand(string executable, string? arguments = null, string? location = null)
    {
        var info = new ProcessStartInfo(executable);

        if (string.IsNullOrEmpty(arguments) == false)
        {
            info.Arguments = arguments;
        }

        if (string.IsNullOrEmpty(location) == false)
        {
            info.WorkingDirectory = location;
        }

        var process = Process.Start(info) ?? throw new InvalidOperationException();

        process.WaitForExit();

        if (process.ExitCode != 0)
        {
            throw new InvalidOperationException();
        }
    }
}