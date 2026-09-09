/*
 Première version
Consigne
Cet algorithme est destiné à prédire l'avenir, et il doit être infaillible !
Il lira au clavier l’heure et les minutes, et il affichera l’heure qu’il sera une minute plus tard. Par exemple, si l'utilisateur tape 21 puis 32, l'algorithme doit répondre :
"Dans une minute, il sera 21 heure(s) 33".
NB : on suppose que l'utilisateur entre une heure valide. Pas besoin donc de la vérifier.
 
 - pseudo-code
 
 
 
 
 
 */



class Program
{
    static void Main()
    {
        Console.Write("Heures :");
        int heure = int.Parse(Console.ReadLine());

        Console.Write("Minutes :");
        int minute = int.Parse(Console.ReadLine());

        if (minute == 60)
        {

            minute = minute % 1;

        }


        else if (heure < 23)
        {
            heure = +0;
            minute = +0;
        }


        else
        {
            heure = +1;
            minute = +1;
        }


        Console.WriteLine("Dans une minute il sera : " + heure + " heure  " + minute);

    }
}

