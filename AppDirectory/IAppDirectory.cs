
namespace AppDirectoryModule
{
    public interface IAppDirectory
    {
        string RootDirectory { get; }

        string AppDir { get; }

        void CreateAppDirectory(string path);

        void CreateAppDirectories(string[] paths);

        string GetAppDirectory();
    }
}
