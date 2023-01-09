using Models;

namespace Service;

public interface IProcessService
{
    /// <summary>
    /// This Gets a File Model from some input stream
    /// </summary>
    /// <returns>The generated model</returns>
    FileModel? GetFileModelFromUser();
    /// <summary>
    /// This Method does the authentication to create a FileModel
    /// </summary>
    /// <param name="model">The model to be written</param>
    /// <returns>
    /// If retruns false it is doing so with a message about why it failed
    /// </returns>
    (bool, string) WriteModel(FileModel model);
}