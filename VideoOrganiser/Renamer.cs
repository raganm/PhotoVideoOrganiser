using System.IO;

namespace VideoOrganiser
{
    public class Renamer
    {
        public string Rename(string path, bool performRenaming)
        {
            var nameGenerator = new NameGenerator();
            var fi = new FileInfo(path);

            var newName = nameGenerator.GenerateNewName(path);

            var destination = Path.Combine(fi.Directory.FullName, newName);

            if (performRenaming)
            {
                if (!File.Exists(destination))
                {
                    File.Move(path, destination);
                }
            }

            return destination;
        }
    }
}
