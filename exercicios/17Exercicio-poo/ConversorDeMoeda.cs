namespace _17Exercicio_poo
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double Calculo(double cotacao, double dolar)
        {
            double dolarMaisIof = ((dolar / 100) * Iof) + dolar;
            return dolarMaisIof * cotacao;
        }
    }
}
