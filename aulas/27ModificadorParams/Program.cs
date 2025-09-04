using _27ModificadorParams;

namespace aula
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculando com o uso de Vetor SEM o modificador Params
            Console.WriteLine(Calculadora.SomaSemMod(new int[] {6, 5, 4, 3, 2, 1}));

            //Calculando com o uso de Vetor COM o modificador Params
            Console.WriteLine(Calculadora.SomaComMod(9, 8, 7, 6, 5, 4));
        }
    }
}