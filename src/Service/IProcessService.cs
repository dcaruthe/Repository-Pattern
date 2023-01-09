using Models;

namespace Service;

public interface IProcessService
{
    FileModel GetFileModelFromUser();
    bool WriteModel(FileModel model);
}