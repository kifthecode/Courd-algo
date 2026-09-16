class Program
{
    static void Main()
    {

        int Nombre = 12;
        bool Fini = false;

        do
        {

            Nombre = Nombre + 2;
            if (Nombre % 4 == 0)
            {
                Fini = true;

            }



        } while (!Fini);
        Console.WriteLine(Nombre);



    }

}
