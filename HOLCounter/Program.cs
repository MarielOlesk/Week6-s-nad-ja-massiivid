using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on "Hello world"
            //

            string sentence = "Hello World".ToLower();
            int counter = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'h' || sentence[i] == 'o' || sentence[i] == 'l')
                {
                    counter++;
                }
            }
            Console.WriteLine($"Lauses '{sentence}' on h, o ja l tähti kokku {counter}");
        }
    }
}
