using DataAccess;
using Models;

namespace Service;

public class ProcessService : IProcessService
{
    private readonly IRepository _repo;
    private readonly TextReader _reader;

    public ProcessService(TextReader reader, IRepository repo)
    {
        _repo = repo;
        _reader = reader;
    }

    public FileModel? GetFileModelFromUser()
    {
        Console.Write("File Name: ");
        string? path = _reader.ReadLine();
        if (path == null) return null;
        ICollection<string> lines = new List<string>();
        Console.WriteLine("Enter text, On UNIX use Ctrl+d to stop on Windows use Ctrl+z:");
        string text = _reader.ReadToEnd();
        FileModel model = new FileModel
        {
            Path = path,
            Text = text
        };
        return model;
    }

    public (bool, string) WriteModel(FileModel model)
    {
        if (!Path.HasExtension(model.Path)) return (false, "File requires extension");
        if (_repo.WriteModel(model))
        {
            return (true, "");
        }
        return (false, "model cannot be written");
    }
}