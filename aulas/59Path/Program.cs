string path = @"C:\Users\mathe\Cursos\udemy-csharp\aulas\59Path\teste1.txt";

Console.WriteLine();
Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path)); // Mostra o caminho até a pasta que contém o arquivo
Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar); // Mostra o caractere de separação do caminho do arquivo
Console.WriteLine("PathSeparator: " + Path.PathSeparator);
Console.WriteLine("GetFileName: " + Path.GetFileName(path)); // Mostra o nome do arquivo contido na pasta
Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path)); // Mostra o nome do arquivo contido na pasta sem a sua extensão
Console.WriteLine("GetExtension: " + Path.GetExtension(path)); // Mostra a extensão do arquivo
Console.WriteLine("GetFullPath: " + Path.GetFullPath(path)); // Mostra todo o caminho do arquivo
Console.WriteLine("GetTempPat: " + Path.GetTempPath()); // Mostra a pasta temporaria do sistema aonde podem ser manipulados dados de forma temporaria
Console.WriteLine();