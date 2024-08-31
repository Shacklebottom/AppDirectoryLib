
namespace AppDirectoryModule
{
    public interface IAppDirectory
    {
        string RootDirectory { get; }

        void CreateAppDirectory(string path);

        void CreateAppDirectories(string[] paths);

        IEnumerable<string> GetDirectoryFiles(string path);
    }
}
