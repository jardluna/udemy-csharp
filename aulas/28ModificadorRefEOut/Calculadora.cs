namespace _28ModificadorRefEOut
{
    internal class Calculadora
    {
        //Modificador Ref - Referência a variável a1 para a b1 (b1 passa a "apontar" para a1) 
        public static void Triplo(ref int b1)
        {
            b1 *= 3;
        }

        //Modificador Out - Referência a variável result da classe Calculadora para a result da Classe Program que não foi iniciada.
        public static void Triplo(int origem, out int result)
        {
            result = origem * 3;
        }
    }
}
