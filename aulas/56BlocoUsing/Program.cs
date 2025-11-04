string path = @"C:\Users\mathe\Cursos\udemy-csharp\aulas\56BlocoUsing\teste1.txt";

try
{
    /*using (FileStream fs = new FileStream(path, FileMode.Open))
    {
        using (StreamReader sr = new StreamReader(fs))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
    }*/

    using (StreamReader sr = File.OpenText(path)) // Forma alternativa de ler o arquivo sem precisar instanciar o FileStream
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred: " + e.Message);
}