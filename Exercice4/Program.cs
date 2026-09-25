//// la cuisine prépare des bacs de pate : 500 g
//// pour le premier,250 g de plus a chaque bac
//Console.Write("Combien de bacs ?");

//int nbBacs;

//int.TryParse(Console.ReadLine(), out nbBacs);

//// La taille vient de la saisie : new crée
//// nbBacs cases, numerotéés de 0 a nbBacs - 1.
//int[] bacs = new int[nbBacs];


//// Premier parcours  : remplir.
//for (int i = 0; i < nbBacs - 1; i++)
//{
//    bacs[i] = 500 + 250 * i;
//}

//// Second parcourss : afficher
//for (int i = 0; i < nbBacs - 1; i++)
//{
//    Console.WriteLine($"bac {i + 1} : {bacs[i]} g");
//}

int[] t = new int[7];

for (int i = 0; i < t.Length; i++)
{
    t[i] = 0;
}


foreach (var item in t)
{
    Console.WriteLine(item);
}
