using Models;

namespace Service;

public interface IProcessService
{
    FileModel? GetFileModelFromUser();
    (bool, string) WriteModel(FileModel model);
}