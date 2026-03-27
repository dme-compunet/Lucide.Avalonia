using System.Diagnostics;
using System.Text;

namespace Generator.ReleaseNotes;

public ref struct ProcessRunner
{
    private readonly ProcessStartInfo _info;

    private StringBuilder? _output;

    public static ProcessRunner Create(string processPath) => new(processPath);

    private ProcessRunner(string processPath)
    {
        _info = new ProcessStartInfo(processPath);
    }

    public readonly ProcessRunner WithArguments(string arguments)
    {
        _info.Arguments = arguments;
        return this;
    }

    public readonly ProcessRunner WithWorkingDirectory(string workingDirectory)
    {
        _info.WorkingDirectory = workingDirectory;
        return this;
    }

    public ProcessRunner WithRedirectOutput(StringBuilder buffer)
    {
        _info.RedirectStandardOutput = true;
        _output = buffer;

        return this;
    }

    public readonly void Execute()
    {
        var process = Process.Start(_info)
                      ??
                      throw new InvalidOperationException("Failed to start process");

        if (_output != null)
        {
            var output = _output;

            process.OutputDataReceived += (_, args) => output.AppendLine(args.Data);
            process.BeginOutputReadLine();
        }

        process.WaitForExit();

        if (process.ExitCode != 0)
        {
            throw new InvalidOperationException("Process exited with code " + process.ExitCode);
        }
    }
}
