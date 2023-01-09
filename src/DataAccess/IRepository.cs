using Models;

namespace DataAccess;

public interface IRepository
{
    /// <summary>
    /// This Method is used by the Service Layer to write files to a given repository
    /// </summary>
    /// <param name="model">The file to be written</param>
    /// <returns>True if file was written successfully</returns>
    bool WriteModel(FileModel model);
}