string path = @"C:\Users\mathe\Cursos\udemy-csharp\aulas\58DirectoryEDirectoryInfo\myFolder";

try
{
    //IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // Lê todas as pastas e subpastas a partir do caminho informado
    var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // Lê todas as pastas e subpastas a partir do caminho informado usando
    Console.WriteLine("FOLDERS: ");
    foreach (string f in folders)
    {
        Console.WriteLine(f);
    }
    Console.WriteLine();

    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // Lê todas os arquivos contidos na pasta e subpastas do caminho informado usando
    Console.WriteLine("FILES: ");
    foreach (string f in files)
    {
        Console.WriteLine(f);
    }

    Directory.CreateDirectory(path + @"\newFolder"); // Cria uma nova pasta no caminho informado
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}