using _23Exercicio_poo.Entities;

Console.WriteLine("======================================================================");

Console.Write("Título: ");
string titulo = Console.ReadLine();
Console.Write("Conteúdo: ");
string conteudo = Console.ReadLine();
Console.Write("Likes: ");
int likes = int.Parse(Console.ReadLine());
Console.Write("Quantos cometários: ");
int quant = int.Parse(Console.ReadLine());
Console.WriteLine();

Post post = new Post(DateTime.Now, titulo, conteudo, likes);
Comment comment = new Comment();

Console.WriteLine("*** Comentários abaixo ***");
for(int i = 0; i < quant; i++)
{
    string comentario = Console.ReadLine();
    comment = new Comment(comentario);
    post.AdicionarComentario(comment);

}
Console.WriteLine();

Console.WriteLine(post.Titulo);
Console.WriteLine($"{post.Likes} likes - {post.Momento}");
Console.WriteLine(post.Conteudo);
Console.WriteLine("Comentários: ");
foreach (Comment item in post.Comentarios)
{
    Console.WriteLine(item);
}

Console.WriteLine("======================================================================");