Console.Write("Entrez un nombre entier :");

int N = int.Parse(Console.ReadLine());
long fact = 1;

for (int i = 2; i <= N; i++)
{

    fact = fact * i;

}
Console.WriteLine("La factorielle est de  = " + fact);