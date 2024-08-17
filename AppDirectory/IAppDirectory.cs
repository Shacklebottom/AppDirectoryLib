
namespace AppDirectoryModule
{
    public interface IAppDirectory
    {
        string RootDirectory { get; }

        void CreateAppDirectory(string path);

        IEnumerable<string> GetDirectoryFiles(string path);
    }
}
