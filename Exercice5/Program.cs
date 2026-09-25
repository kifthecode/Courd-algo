// Un tableau de 8 entiers nommé entiers
int[] entiers = new int[8];

// un tableau de 10 chaînes de caractères nommé chaines
string[] chaines = new string[10];

// un tableau de 5 doubles nommé prix
double[] prix = new double[5];

// Remplir entiers
for (int i = 0; i < entiers.Length; i++)
{
    Console.Write($"Entrez l'entier {i + 1} : ");
    entiers[i] = int.Parse(Console.ReadLine());
}

// Remplir chaines
for (int i = 0; i < chaines.Length; i++)
{
    Console.Write($"Entrez la chaîne {i + 1} : ");
    chaines[i] = Console.ReadLine();
}

// Remplir prix
for (int i = 0; i < prix.Length; i++)
{
    Console.Write($"Entrez le prix {i + 1} : ");
    prix[i] = double.Parse(Console.ReadLine());
}

// Appeler la fonction pour afficher les tableaux
AfficherTableaux(entiers, chaines, prix);





void AfficherTableaux(int[] tab1, string[] tab2, double[] tab3)
{
    Console.WriteLine("\nAffichage des tableaux :");
    Console.WriteLine("\nTableau d'entiers :");
    for (int i = 0; i < tab1.Length; i++)
    {
        Console.WriteLine(tab1[i]);
    }

    Console.WriteLine("\nTableau de chaînes :");
    for (int i = 0; i < tab2.Length; i++)
    {
        Console.WriteLine(tab2[i]);
    }

    Console.WriteLine("\nTableau de prix :");
    for (int i = 0; i < tab3.Length; i++)
    {
        Console.WriteLine(tab3[i]);
    }
}