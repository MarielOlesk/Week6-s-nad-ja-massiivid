using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed laused "Don't panic" - 0 (nulliga)
            //programm asendab kõik 'a' tähed lauses '4'

            string sentence = "Don't Panic";

            sentence = sentence.Replace('o', '0');
            sentence = sentence.Replace('a', '4');

            Console.WriteLine(sentence);
        }
    }
}
