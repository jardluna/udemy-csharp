string path = @"C:\Users\mathe\Cursos\udemy-csharp\aulas\55FileStreamEStreamReader\teste1.txt";
//FileStream fs = null;
StreamReader sr = null;

try
{
    /*fs = new FileStream(path, FileMode.Open);
    sr = new StreamReader(fs);*/

    sr = File.OpenText(path); // Forma alternativa de ler um arquivo sem precisar instanciar o FileStream

    while (!sr.EndOfStream) // Lê todo o conteúdo do arquivo
    {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error accured: " + e.Message);
}
finally
{
    //if (fs != null) fs.Close();
    if (sr != null) sr.Close();
}



