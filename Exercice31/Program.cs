// Le congelateur a vaccins de la clinique :
// cinq releves = temperature, en °c.
int[] releves = { -18, -21, -19, -17, -22 };
int seuil = -18;
int nbAlertes = 0;

// Le plus chaud part de la premierer case jamais
// de 0 : toutes les valeurs sont négatives.
int plusChaud = releves[0];
int rangPlusChaud = 1;

for (int i = 0; i < releves.Length; i++)
{

    // Un compteur : les relevés au-dessus du seuil.
    if (releves[i] > seuil)
    {
        nbAlertes++;
    }

    // Le plus chaud vu jusqu'ici, et son rang :
    // le rang compte a partir de 1, l'indice de 0
    if (releves[i] > plusChaud)
    {

        plusChaud = releves[i];
        rangPlusChaud = i + 1;

    }



}

Console.WriteLine($"Relevés trop chauds : {nbAlertes}");
Console.WriteLine($"Le plus chaud : {plusChaud} °c, relevé {rangPlusChaud}");
