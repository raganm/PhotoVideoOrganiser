namespace PhotoOrganiser
{
    public class PhotoAnalysis
    {
        public string OriginalName { get; set; }

        public string NewName { get; set; }

        public bool IsCorrectName
        {
            get { return OriginalName.ToLower() == NewName.ToLower(); }
        }
    }
}