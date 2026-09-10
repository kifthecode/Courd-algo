/*
 Consigne
Écrivez un algorithme qui après avoir demandé un numéro de jour, de mois et d'année à l'utilisateur, renvoie s'il s'agit ou non d'une date valide.

Cet exercice est certes d'un manque d'originalité affligeant, mais après tout, en algorithmique comme ailleurs, 
il faut connaître ses classiques ! Et quand on a fait cela une fois dans sa vie, on apprécie pleinement
l'existence d'un type numérique « date » dans certains langages...).

Il n'est sans doute pas inutile de rappeler rapidement que le mois de février compte 28 jours, sauf si l'année est bissextile, auquel cas il en compte 29. 
L'année est bissextile si elle est divisible par quatre. Toutefois, 
les années divisibles par 100 ne sont pas bissextiles, mais les années divisibles par 400 le sont. 
 
 
 Pseudo code :

Lire jour, mois, année
 
 
 
 
 
 
 
 
 
 
 
 
 */


class Program
{
    static void Main()
    {

        Console.Write(" Jour :");
        int jour = int.Parse(Console.ReadLine());

        Console.Write(" Mois :");
        int mois = int.Parse(Console.ReadLine());

        Console.Write(" Année :");
        int année = int.Parse(Console.ReadLine());


        int nbJours = 31;



        if (mois >= 1 || mois >= 12)

        {

            Console.WriteLine(" date non valide ");

        }


        if (mois >= 4 || mois >= 6 || mois >= 9 || mois >= 11)

        {

            nbJours = 30;

        }


        else if (mois < 2)


            if (mois == 2)

                nbJours = 28;

            else
            {

                nbJours = 29;

            }



        else

        {

            nbJours = 31;

        }


        if (jour >= 1 || jour == nbJours)


        {

            Console.WriteLine(" date valide ");

        }

        else

        {

            Console.WriteLine(" date non valide ");

        }



    }

}
