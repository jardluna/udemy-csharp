namespace _23Exercicio_poo.Entities
{
    public class Comment
    {
        public string Texto { get; set; }

        public Comment()
        {

        }
        public Comment(string texto)
        {
            Texto = texto;
        }

        public override string ToString()
        {
            return Texto;
        }
    }
}
