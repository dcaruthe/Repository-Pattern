using Moq;
using Service;
using DataAccess;
using Models;

namespace Tests;

public class ServiceTests
{
    public static string A = "";
    public static string B = "";
    public IProcessService CreateService()
    {
        var repo = new Mock<IRepository>();

        repo.Setup(repo => repo.WriteModel(It.IsAny<FileModel>())).Returns((FileModel model) =>
        {
            // Since were not testing if the data layer works
            return true;
        });

        var input = new Mock<TextReader>();
        input.Setup(input => input.ReadLine()).Returns(() =>
        {
            return A;
        });

        input.Setup(input => input.ReadToEnd()).Returns(() =>
        {
            return B;
        });

        return new ProcessService(input.Object, repo.Object);
    }

    [Fact]
    public void CanWriteProperInput()
    {
        // Arrange
        IProcessService service = CreateService();
        A = "test.txt";
        B = "This can be written";

        // Act
        FileModel model = service.GetFileModelFromUser()!;
        (bool, string) worked = service.WriteModel(model);

        // Assert
        Assert.True(worked.Item1);

        //Cleanup
        A = "";
        B = "";
    }

    [Fact]
    public void CantWriteImproperInput()
    {
        // Arrange
        IProcessService service = CreateService();
        A = "test";
        B = "This can't be written";

        // Act
        FileModel model = service.GetFileModelFromUser()!;
        (bool, string) worked = service.WriteModel(model);

        // Assert
        Assert.False(worked.Item1);

        //Cleanup
        A = "";
        B = "";
    }
}