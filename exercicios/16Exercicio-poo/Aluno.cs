namespace _16Exercicio_poo
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double Nota4;

        public double NotaFinal()
        {
            return (Nota1 + Nota2 + Nota3 + Nota4) / 4;
        }
        public bool AprovadoOuReprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NotaRestante()
        {
            if (AprovadoOuReprovado())
            {
                return 0;
            }
            else
            {
                return 60 - NotaFinal();
            }
        }
    }
}
