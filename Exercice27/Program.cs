Personne p = new Personne("Laydi");


public class Personne
{

    public string Nom;
    public Personne(string nom)
    {
        Nom = nom;
        Console.WriteLine($"{Nom} vient de naitre !");
    }

}