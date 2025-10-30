
FileStream fs = null;

try
{
    fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
    StreamReader sr = new StreamReader(fs);
    string line = sr.ReadLine();
    Console.WriteLine(line);
}
catch (FileNotFoundException e)
{
    Console.WriteLine("Error! - " + e.Message);
}
finally
{
    if(fs != null)
    {
        fs.Close();
    }
}