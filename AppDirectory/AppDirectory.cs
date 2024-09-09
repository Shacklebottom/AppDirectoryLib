
namespace AppDirectoryModule
{
    public abstract class AppDirectory : IAppDirectory
    {
        public string RootDirectory { get; private set; }

        public string AppDir => GetAppDirectory();

        public AppDirectory(string rootDir)
        {
            RootDirectory = rootDir;

            CreateAppDirectory(rootDir);

            CreateAppDirectory(AppDir);
        }

        //override this method!
        public abstract string GetAppDirectory();

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
    }
}
