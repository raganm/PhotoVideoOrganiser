using System.IO;

namespace PhotoOrganiser
{
    public class Renamer
    {
        public string Rename(string path, bool analyseOnly)
        {
            var nameGenerator = new NameGenerator();
            var fi = new FileInfo(path);
            var newName = nameGenerator.GenerateNewName(path);
            var destination = Path.Combine(fi.Directory.FullName, newName);

            if (!analyseOnly)
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
