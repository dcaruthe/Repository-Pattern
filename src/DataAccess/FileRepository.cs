using Models;

namespace DataAccess;

public class FileRepository : IRepository
{
    public bool WriteModel(FileModel model)
    {
        try
        {
            if (File.Exists(model.Path))
            {
                File.Delete(model.Path);
            }
            var file = File.Create(model.Path);
            file.Close();
            File.WriteAllText(model.Path, model.Text);
            return true;
        }
        catch (IOException)
        {
            return false;
        }
    }
}