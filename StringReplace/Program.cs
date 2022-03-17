using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Hello World!" tärniga (*)

            string helloWorld = "Hello World!";

            helloWorld = helloWorld.Replace('o', '*');
            helloWorld = helloWorld.Replace('!', '1');

            Console.WriteLine(helloWorld); 
        }
    }
}
