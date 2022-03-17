using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendes on pikes, kas ees- või perekonnanimi. 
            Console.WriteLine("Sisestada eesinimi");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisestada perenimi");
            string lastName = Console.ReadLine();

            if(firstName.Length > lastName.Length)
            {
                Console.WriteLine("Eesnimi on pikem!");
            }
            else if(firstName.Length < lastName.Length)
            {
                Console.WriteLine("Perenimi on pikem!");
            }
            else
            {
                Console.WriteLine("Eesnimi on samapikk kui perenimi");
            }

        }
    }
}
