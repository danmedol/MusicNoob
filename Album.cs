public class Album
{
    public string Nome{get; set;}
    public int Plays{get; set;}
    
    public Album(string nome, int plays)
    {
        Nome = nome;
        Plays = plays;
    }
}
