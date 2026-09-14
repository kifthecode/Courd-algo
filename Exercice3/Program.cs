class Program
{
    static void Main()
    {

        Console.Write("entre un nombre entier : ");
        int N = int.Parse(Console.ReadLine());

        int somme = 0;
        int i = 1;

        while (i <= N)
        {


            somme = somme + i;
            i = i + 1;


        }



        Console.WriteLine($"Le somme des nombres de 1 a {N} est {somme} ");


    }

}