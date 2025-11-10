using _64InterfaceIComparable.Entities;

string path = @"C:\Users\mathe\Cursos\udemy-csharp\aulas\64InterfaceIComparable\file.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<Employee> list = new List<Employee>();
        while (!sr.EndOfStream)
        {
            list.Add(new Employee(sr.ReadLine())); // Lê o conteúdo do arquivo e adiciona na lista
        }
        list.Sort(); // Colocar os valores contidos na lista em ordem alfabética
        foreach (Employee item in list)
        {
            Console.WriteLine(item);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}