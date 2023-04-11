using System;

namespace Loops_Sawyer_Moira
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks user why they want to make games
            Console.WriteLine("Why do you want to make games?");
            string response = Console.ReadLine();
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");
            //asks user to enter a whole number
            Console.WriteLine("Please enter a whole number!");
            string respnse2 = Console.ReadLine();
            Console.WriteLine($"The sum of the individual digits of {respnse2} is {SumOfDigits(respnse2)}!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sentence">The sentence to count number of spaces in</param>
        /// <returns>Number of spaces in the sentence</returns>
        static int CountNumberOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach(char character in sentence)
            {
                if(character == ' ')
                    numberOfSpaces++;
            }

            return numberOfSpaces;
        }

        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach(char dight in number)
            {
                sum +=(int) Char.GetNumericValue(dight);
            }

            return sum;
        }

    }
}
