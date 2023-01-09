using DataAccess;
using Models;

namespace Service;

public class ProcessService : IProcessService
{
    private readonly IRepository _repo;

    public ProcessService(IRepository repo)
    {
        _repo = repo;
    }

    public FileModel GetFileModelFromUser()
    {
        throw new NotImplementedException();
    }

    public bool WriteModel(FileModel model)
    {
        throw new NotImplementedException();
    }
}