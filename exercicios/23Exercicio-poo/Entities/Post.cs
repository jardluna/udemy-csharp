namespace _23Exercicio_poo.Entities
{
    public class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comentarios { get; private set; } = new List<Comment>();

        public Post()
        {

        }
        public Post(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AdicionarComentario(Comment comentario)
        {
            Comentarios.Add(comentario);
        }
        public void RemoverComentario(Comment comentario)
        {
            Comentarios.Remove(comentario);
        }
    }
}
