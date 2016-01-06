using System;
using System.IO;
using ExifLib;

namespace PhotoOrganiser
{
    public class NameGenerator
    {
        public string GenerateNewName(string path)
        {
            var fi = new FileInfo(path);

            if (fi.Exists)
            {
                var size = fi.Length / 1024;
                string newName;
                try
                {
                    var date = GetDateTimeTaken(fi.FullName);
                    newName = string.Format("{2} - {0}{1}", size, fi.Extension, date.ToString("yyyy-MM-dd HH.mm.ss"));
                }
                catch (Exception)
                {
                    newName = string.Format("Unable to get date time information {2} - {0}{1}", size, fi.Extension, Guid.NewGuid().ToString());
                }



                return newName.ToLower();
            }

            return string.Empty;
        }

        public DateTime GetDateTimeTaken(string path)
        {
            var date = new DateTime();

            using (var reader = new ExifReader(path))
            {
                // Extract the tag data using the ExifTags enumeration
                DateTime datePictureTaken;
                if (reader.GetTagValue<DateTime>(ExifTags.DateTime,
                                                out datePictureTaken))
                {
                    // Do whatever is required with the extracted information
                    date = datePictureTaken;
                }

                // Extract the tag data using the ExifTags enumeration
                if (reader.GetTagValue<DateTime>(ExifTags.DateTimeDigitized,
                                                out datePictureTaken))
                {
                    // Do whatever is required with the extracted information
                    date = datePictureTaken;
                }
            }



            return date;
        }
    }
}
