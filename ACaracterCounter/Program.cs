using System;

namespace ACaracterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perenime
            //programm kubav, mitu ´a´ tähte on kasutaja ees- ja perekonnanimes kokku


            Console.WriteLine("Sisestada eesinimi");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisestada perenimi");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

            Console.WriteLine(fullName);

            int aCounter = 0;

            for(int i = 0; i < fullName.Length; i ++)
            {
                if (fullName[i] == 'a')
                {
                    aCounter++;
                }
            }
            if (aCounter != 1)
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu täisnimes on ainult 1 'a' täht");
            }
        }
    }
}
