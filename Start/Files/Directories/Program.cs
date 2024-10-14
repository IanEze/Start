// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Creating and Deleting Directories

const string dirname = "TestDir";
// Create a Directory if it doesn't already exist
if (!Directory.Exists(dirname)) {
Directory.CreateDirectory(dirname);
}
else {
Directory.Delete(dirname);
}
// Get the path for the current directory
string curpath = Directory.GetCurrentDirectory();
Console.WriteLine($"Current directory is {curpath}");
// Just like with files, you can retrieve info about a directory
DirectoryInfo di = new DirectoryInfo(curpath);
Console.WriteLine($"{di.Name}");
Console.WriteLine($"{di.Parent}");
Console.WriteLine($"{di.CreationTime}");
Console.WriteLine("---------------");
// Enumerate the contents of directories
Console.WriteLine("Just directories:");
List<string> thedirs = new List<string>(Directory.EnumerateDirectories(curpath));
foreach (string dir in thedirs) {
Console.WriteLine(dir);
}
Console.WriteLine("---------------");