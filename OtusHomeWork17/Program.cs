using OtusHomeWork17;
const int needCountFileSearch = 3;
var path = Directory.GetCurrentDirectory();
var filesName = new List<string>();
var fileFinder = new FileFinder();

fileFinder.FileFound += (s, e) =>
{
    Console.WriteLine($"Найден файл => {e.fileName}");
    filesName.Add(e.fileName);
    e.stopSearch = filesName.Count >= needCountFileSearch;
};

fileFinder.Search(path);

if (filesName.Count > 0)
{
    var fileNameMaxLength = filesName.GetMax<string>(f => f.Length);
    Console.WriteLine($"Файл с самым длинным названием => {fileNameMaxLength}");
} else
{
    Console.WriteLine($"В дирректории {path} нет файлов.");
}



