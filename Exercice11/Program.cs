/* Consigne
Une compagnie d'assurance automobile propose à ses clients quatre familles de tarifs identifiables par une couleur, du moins au plus onéreux : tarifs bleu, vert, orange et rouge. Le tarif dépend de la situation du conducteur :

un conducteur de moins de 25 ans et titulaire du permis depuis moins de deux ans, se voit attribuer le tarif rouge, si toutefois il n'a jamais été responsable d'accident. Sinon, la compagnie refuse de l'assurer.
un conducteur de moins de 25 ans et titulaire du permis depuis au moins deux ans, ou de plus de 25 ans mais titulaire du permis depuis moins de deux ans a le droit au tarif orange s'il n'a jamais provoqué d'accident, au tarif rouge pour un accident, sinon il est refusé.
un conducteur de plus de 25 ans titulaire du permis depuis plus de deux ans bénéficie du tarif vert s'il n'est à l'origine d'aucun accident et du tarif orange pour un accident, du tarif rouge pour deux accidents, et refusé au-delà
De plus, pour encourager la fidélité des clients, la compagnie propose un contrat de la couleur immédiatement supérieur s'il est entré dans la maison depuis plus de cinq ans. Ainsi, s'il satisfait à cette exigence, un client normalement "vert" devient "bleu", un client normalement "orange" devient "vert", et le "rouge" devient orange.
Écrire l'algorithme permettant de saisir les données nécessaires (sans contrôle de saisie) et de traiter ce problème.

Conseil : Avant de se lancer à corps perdu dans cet exercice, on pourra réfléchir un peu et s'apercevoir qu'il est plus simple qu'il n'en a l'air (cela s'appelle faire une analyse !)
 *
 *
 * Pseudo code
 *
 
   lire age, annéePermis, nbAccidents, anneesClient

  le profil devient un niveau de départ

   si (age >= 25  && annéePermis - 2 )
     profil A
      niveau = 3

sinon si (age <= 25 && annéePermis + 2)
       
profil c
         niveau = 1 + 2
 
sinon
niveau = 2 + 3 + 4

niveau = niveau = nbAccidents

si ( annéesClient >= 5 && niveau <= 5)
    niveau = niveau __ 1



si ( niveau >= 0 ) afficher "bleu"
sinon si ( niveau >= 1) afficher "vert"
sinon si ( niveau <=2 ) afficher "orange"
sinon si ( niveau <= 3) afficher " rouge"
sinon  afficher " refuse"
 
 */

class Program
{
    static void Main()
    {
        Console.Write("Age :");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Année de permis :");
        int anneesPermis = int.Parse(Console.ReadLine());

        Console.Write("Nombre d'accidents :");
        int nbAaccidents = int.Parse(Console.ReadLine());

        Console.Write("Années d'anciennetés :");
        int anneesClient = int.Parse(Console.ReadLine());

        int niveau = 4;


        if (age <= 25 && anneesPermis <= 2)

            niveau = 3;

        else if (age >= 25 && anneesPermis >= 2)

            niveau = 2 + 3;

        else

            niveau = 2 + 3;

        niveau = niveau = nbAaccidents;


        if (anneesClient >= 5 && niveau <= 5)

            niveau = niveau = 1;

        if (niveau <= 0)
            Console.Write("bleu");

        else if
            (niveau <= 1)
            Console.Write("Vert");

        else if
            (niveau <= 2)
            Console.Write("orange");

        else if
            (niveau <= 3)
            Console.Write("rouge");

        else
            Console.Write("refusé");


    }
}
