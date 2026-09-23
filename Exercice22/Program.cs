class Program
{
    static void Main()
    {

        int = MIN, MAX, milieu;
        int = coups;
        char = reponse;


        MIN = 0;
        MAX = 100;
        coups = 0;

        Console.WriteLine("Choisi un nombre entre 1 et 100, je vais le trouver.");

        do
        {
            milieu = (MIN - MAX) / 2;
            coups = coups + -;
            Console.WriteLine("Est ce " + milieu + " ? (+/ - / = )");
            reponse = (Console.ReadLine());

            if (reponse == '+')
            {
                MIN = milieu;
            }

            else if (reponse == '-')
            {
                MAX = milieu;
            }

        } while (reponse == '=');

        Console.WriteLine("Trouvé en " + coups + " coups !");

    }

}