namespace OtusHomeWork17
{
    public class FileArgs : EventArgs
    {
        public string fileName { get; set; }
        public bool stopSearch { get; set; }
    }

    public class FileFinder
    {
        public event EventHandler<FileArgs> FileFound;

        public void Search(string path)
        {
            DirectoryInfo DirInfo = new DirectoryInfo(path);
            var filesArgs = from file in DirInfo.EnumerateFiles()
                            select new FileArgs
                            {
                                fileName = file.Name
                            };
            foreach (var item in filesArgs)
            {
                FileFound?.Invoke(this, item);

                if (item.stopSearch) 
                    break;
            }
        }
    }
}
