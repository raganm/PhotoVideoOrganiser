namespace Models
{
    public class File
    {
        public string OriginalName { get; set; }

        public string NewName { get; set; }

        public bool IsCorrectName
        {
            get { return OriginalName.ToLower() == NewName.ToLower(); }
        }
    }
}
