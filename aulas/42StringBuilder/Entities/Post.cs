using System.ComponentModel;
using System.Text;

namespace _23Exercicio_poo.Entities
{
    public class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comentarios { get; set; } = new List<Comment>();

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.AppendLine(" Likes - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comments: ");
            foreach (Comment item in Comentarios)
            {
                sb.AppendLine(item.Texto);
            }
            return sb.ToString();
        }
    }
}
