using Models;
using Service;
using DataAccess;

// Initialize the Data Access Layer by createing a repo object
IRepository repo = new FileRepository();

// Initialize the Bussiness Layer by creating a service object
// Console.In is passed here because we want to Use STDIN to get input from user
// We also pass the repo because that is the repository we want to use
IProcessService service = new ProcessService(Console.In, repo);

FileModel? model = service.GetFileModelFromUser();
if (model == null)
{
    Console.WriteLine("Unable create Model, No filename provided");
    Environment.Exit(1);
}
else
{
    // This method call will run all the checks on the service layer and then do the writting to the file
    (bool, string) ret = service.WriteModel(model);
    if (ret.Item1)
    {
        // All checks passed and the file was written
        Console.WriteLine("File written Successfully!");
        // Good exit code
        Environment.Exit(0);
    }
    else
    {
        // A check failed or failed to write
        Console.WriteLine($"Failed to write: {ret.Item2}");
        // Bad exit code
        Environment.Exit(2);
    }
}