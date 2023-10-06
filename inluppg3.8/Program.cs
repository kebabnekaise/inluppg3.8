using System;

namespace inluppg3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv tre ord, ett per rad");
            string word1  = Console.ReadLine();
            string word2 = Console.ReadLine();
            string word3  = Console.ReadLine();

            if (word2.CompareTo(word1) == 1 && word3.CompareTo(word1) == 1)
            {
                Console.WriteLine(word1 + " kommer förs i bokstavsordning");
            }
            else if (word1.CompareTo(word2) == 1 && word3.CompareTo(word2) == 1)
            {
                Console.WriteLine(word2 + " kommer förs i bokstavsordning");
            }
            else if (word1.CompareTo(word3) == 1 && word2.CompareTo(word3) == 1)
            {
                Console.WriteLine(word3 + " kommer först i bokstavsordning");
            }
        }
    }
}