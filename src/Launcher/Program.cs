using Models;
using Service;
using DataAccess;

IRepository repo = new FileRepository();
IProcessService service = new ProcessService(Console.In, repo);

FileModel? model = service.GetFileModelFromUser();
if (model == null)
{
    Console.WriteLine("Unable create Model, No filename provided");
    Environment.Exit(1);
}
else
{
    (bool, string) ret = service.WriteModel(model);
    if (ret.Item1)
    {
        Console.WriteLine("File written Successfully!");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine($"Failed to write: {ret.Item2}");
        Environment.Exit(2);
    }
}