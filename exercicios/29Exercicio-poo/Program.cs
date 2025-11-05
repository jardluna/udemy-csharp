using _29Exercicio_poo.Entities;
using System.Globalization;

Console.WriteLine("=======================================================================================");

Console.Write("Entre com o caminho completo do arquivo: ");
string caminhoDeOrigemDoArquivo = Console.ReadLine();

try
{
    string[] linhas = File.ReadAllLines(caminhoDeOrigemDoArquivo);

    string caminhoDeOrigemDaPasta = Path.GetDirectoryName(caminhoDeOrigemDoArquivo);
    string destinoDeOrigemDaPasta = caminhoDeOrigemDaPasta + @"\out";
    string destinoDeOrigemDoArquivo = destinoDeOrigemDaPasta + @"\summary.csv";

    Directory.CreateDirectory(destinoDeOrigemDaPasta);

    using (StreamWriter sw = File.AppendText(destinoDeOrigemDoArquivo))
    {
        foreach (string linha in linhas)
        {

            string[] campos = linha.Split(',');
            string name = campos[0];
            double price = double.Parse(campos[1], CultureInfo.InvariantCulture);
            int quantity = int.Parse(campos[2]);

            Product prod = new Product(name, price, quantity);

            sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}

Console.WriteLine("=======================================================================================");