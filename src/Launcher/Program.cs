using Models;
using Service;
using DataAccess;

IRepository repo = new FileRepository();
IProcessService service = new ProcessService(repo);

FileModel model = service.GetFileModelFromUser();
bool check = service.WriteModel(model);
if (check)
{
    Console.WriteLine("File was written successfully");
    Environment.Exit(0);
}
else
{
    Console.WriteLine("Failed to write file");
    Environment.Exit(1);
}