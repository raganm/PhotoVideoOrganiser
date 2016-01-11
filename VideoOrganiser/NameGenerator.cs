using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace VideoOrganiser
{
    public class NameGenerator
    {
        public string GenerateNewName(string workingCopyOfFile)
        {
            var fi = new FileInfo(workingCopyOfFile);
            var dateTaken = GetDateTimeTaken(workingCopyOfFile);
            var size = fi.Length;
            string newName;
            try
            {
                newName = string.Format("{2} - {0}{1}", size, fi.Extension, dateTaken.ToString("yyyy-MM-dd HH.mm.ss"));
            }
            catch (Exception)
            {
                newName = string.Format("Unable to get date time information {2} - {0}{1}", size, fi.Extension, Guid.NewGuid().ToString());
            }

            return newName.ToLower();
        }

        public DateTime GetDateTimeTaken(string path)
        {
            var fi = new FileInfo(path);

            return fi.LastWriteTime;
        }
    }
}

