string sourcePath = @"C:\Users\mathe\Cursos\udemy-csharp\aulas\54FileEFileInfoEIOException\teste1.txt";
string targetPath = @"C:\Users\mathe\Cursos\udemy-csharp\aulas\54FileEFileInfoEIOException\teste2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);

    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string i in lines)
    {
        Console.WriteLine(i);
    }
}
catch (IOException e) // Super classe
{
    Console.WriteLine("An error occurred: " + e.Message);
}