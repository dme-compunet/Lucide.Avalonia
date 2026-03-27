using Generator.Icons;

//var c = new GenerateCommand
//{
//    InputPath = @"D:\source\github\lucide",
//    OutputPath = @"D:\source\github\lucide\ggg\lucide-icons.txt",
//};

//c.Execute();

//return;

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