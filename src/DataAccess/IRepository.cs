using Models;

namespace DataAccess;

public interface IRepository
{
    bool WriteModel(FileModel model);
}