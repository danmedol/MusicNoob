public class Artista
{
    public string Nome{get; set;}
    public string Bio{get; set;}
    public int Ouvintes{get; set;}
    public int Plays{get; set;}

    public Artista(string nome, string bio, int ouvintes, int plays)
    {
        Nome = nome;
        Bio = bio;
        Ouvintes = ouvintes;
        Plays = plays;
    }

}