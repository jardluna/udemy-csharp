namespace _27ModificadorParams
{
    class Calculadora
    {
        //Função para calcular sem o uso do modificador Params
        public static int SomaSemMod(int[] n)
        {
            int soma = 0;
            for (int i = 0; i < n.Length; i++)
            {
                soma += n[i];
            }
            return soma;
        }

        //Função para calcular COM o uso do modificador Params
        public static int SomaComMod(params int[] n)
        {
            int soma = 0;
            for (int i = 0; i < n.Length; i++)
            {
                soma += n[i];
            }
            return soma;
        }
    }
}
