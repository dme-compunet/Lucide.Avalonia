using Generator.Icons;

if (args[0] == "build")
{
    var command = new BuildCommand
    {
        InputPath = args[1],
        OutputPath = args[2]
    };

    command.Execute();
}
else if (args[0] == "generate")
{
    var command = new GenerateCommand
    {
        InputPath = args[1],
        OutputPath = args[2],
    };

    command.Execute();
}
else
{
    Console.WriteLine("Unknown command: " + args[0]);
}