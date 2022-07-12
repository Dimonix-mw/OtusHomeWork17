using OtusHomeWork17;

var path = Directory.GetCurrentDirectory();
var filesName = new List<string>();

var fileFinder = new FileFinder();
fileFinder.FileFound += (s, e) =>
{
    Console.WriteLine($"Найден файл => {e.fileName}");
    filesName.Add(e.fileName);
    e.stopSearch = filesName.Count >= 3;
};

fileFinder.Search(path);

var fileNameMaxLength = filesName.GetMax<string>((f) => f.Length);

Console.WriteLine($"Файл с самым длинным названием => {fileNameMaxLength}");