
namespace AppDirectoryModule
{
    public class AppDirectory : IAppDirectory
    {
        public string RootDirectory { get; private set; }

        public AppDirectory(string rootDir)
        {
            RootDirectory = rootDir;

            CreateAppDirectory(rootDir);
        }

        public void CreateAppDirectory(string path)
        {
            if (Directory.Exists(path)) return;

            Directory.CreateDirectory(path);
        }

        public void CreateAppDirectories(string[] paths)
        {
            var currentDirectories = Directory.GetDirectories(RootDirectory);
            var newDirectories = paths.Where(p => !currentDirectories.Contains(p));

            if (!newDirectories.Any()) return;

            foreach (string path in newDirectories)
            {
                Directory.CreateDirectory(path);
            }
        }
        public IEnumerable<string> GetDirectoryFiles(string path)
        {
            return Directory.EnumerateFiles(path);
        }
    }
}
