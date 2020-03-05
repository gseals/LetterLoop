using System;

namespace LetterLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a random sequence of characters.");
            string randomCharacters = Console.ReadLine();

            var upper = randomCharacters.ToUpper();
            var lower = randomCharacters.ToLower();
            string finalString = "";

            for (var i = 0; i < randomCharacters.Length; i++)
            {
                for (var j = 0; j<i+1; j++)
                {
                    if (j == 0)
                    {
                        finalString += upper[i];
                    }
                    else
                    {
                        finalString += lower[i];
                    }
                }
                if (i < randomCharacters.Length - 1)
                {
                    finalString += "-";
                }
            }
            Console.WriteLine(finalString);
            Console.Read(); 
        }
    }
}
