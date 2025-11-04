string sourcePath = @"C:\Users\mathe\Cursos\udemy-csharp\aulas\57StreamWriter\teste1.txt";
string targetPath = @"C:\Users\mathe\Cursos\udemy-csharp\aulas\57StreamWriter\teste2.txt";

try
{
    string[] lines = File.ReadAllLines(sourcePath);

    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}