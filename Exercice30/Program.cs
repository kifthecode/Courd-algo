// Correction des erreurs CS1002, CS0131 et CS8604

// Un tableau de 8 entiers
int[] entiers = new int[8];
//Un tableau de 10 chaines de caractères initialisé au moment de la déclarati
string[] chaines = { "", "", "", "", "", "", "", "", "", "" };
//Un tableau de 5 notes (réel)
double[] prix = new double[5];



for (int i = 0; i < entiers.Length; i++)
{
    Console.WriteLine("Veuillez entrer un nombre entier ({0}/8) :", i + 1);
    string? saisie = Console.ReadLine();
    // Correction CS8604 : Vérification de la nullité de la saisie
    while (string.IsNullOrWhiteSpace(saisie) || !int.TryParse(saisie, out entiers[i]))
    {
        Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entier valide :");
        saisie = Console.ReadLine();
    }
}



// Remplacement du type de la variable de boucle 'i' de string à int pour corriger CS0019 et CS0023
for (int i = 0; i < chaines.Length; i++)
{
    Console.WriteLine("Veuillez entrer 10 prenoms ({0}/10) :", i + 1);
    string? saisie = Console.ReadLine();
    // Correction de la logique de saisie pour les prénoms (pas de int.TryParse ici)
    while (string.IsNullOrWhiteSpace(saisie))
    {
        Console.WriteLine("Entrée invalide. Veuillez entrer un vrai prenom valide :");
        saisie = Console.ReadLine();
    }


    chaines[i] = saisie;
}


for (int i = 0; i < prix.Length; i++)
{
    Console.WriteLine("Veuillez entrer un prix ({0}/5) :", i + 1);
    string? saisie = Console.ReadLine();
    //Correction: Vérification de la nullité et conversion en double
    while (string.IsNullOrWhiteSpace(saisie) || !double.TryParse(saisie, out prix[i]))
    {
        Console.WriteLine("Entrée invalide. Veuillez entrer un prix valide :");
        saisie = Console.ReadLine();
    }
}



Console.WriteLine("Voici le tableau des entiers :");
for (int i = 0; i < entiers.Length; i++)
{
    Console.WriteLine(entiers[i]);
}

Console.WriteLine("Voici le tableau des prenoms :");
for (int i = 0; i < chaines.Length; i++)
{
    Console.WriteLine(chaines[i]);
}

Console.WriteLine("Voici le tableau des notes :");
for (int i = 0; i < prix.Length; i++)
{
    Console.WriteLine(prix[i]);
}

