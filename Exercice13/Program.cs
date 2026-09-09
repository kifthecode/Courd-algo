/*
1. Consigne

Les élections législatives, en Guignolerie Septentrionale, obéissent à la règle suivante :

lorsque l'un des candidats obtient plus de 50% des suffrages, il est élu dès le premier tour.
en cas de deuxième tour, peuvent participer uniquement les candidats ayant obtenu au moins 12,5% des voix au premier tour.
Vous devez écrire un algorithme qui permette la saisie des scores de quatre candidats au premier tour.
Cet algorithme traitera ensuite le candidat numéro 1 (et uniquement lui) : il dira s'il est élu, battu, s'il se trouve en ballottage favorable 
(il participe au second tour en étant arrivé en tête à l'issue du premier tour) ou défavorable (il participe au second tour sans avoir été en tête au premier tour).


Pseudo-code
 
 
 
 
 */


class Program
{
    static void Main()
    {

        Console.Write(" Candidat 1 :");
        double candidat1 = double.Parse(Console.ReadLine());

        Console.Write("Candidat 2 :");
        double candidat2 = double.Parse(Console.ReadLine());

        Console.Write(" Candidat 3 :");
        double candidat3 = double.Parse(Console.ReadLine());

        Console.Write(" Candidat 4 :");
        double candidat4 = double.Parse(Console.ReadLine());




        if (candidat1 > 50)

        {
            Console.WriteLine(" Vous etes élu :");
        }

        else if (candidat2 > 50 || candidat3 > 50 || candidat4 > 50 || candidat1 < 12.5)

        {
            Console.WriteLine(" Vous etes Battu :");

        }

        else if (candidat1 > candidat2 && candidat1 > candidat3 && candidat1 > candidat4)

        {

            Console.WriteLine(" Ballotage favorable :");

        }

        else

            Console.WriteLine(" Ballottage défavorable :");


    }
}

