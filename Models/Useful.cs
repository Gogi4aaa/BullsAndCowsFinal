using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCowsFinal.Models
{
    public class Useful
    {
        public bool HasSameSymbols(string number)
        {
            for (int i = 0; i < number.Length - 1; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] == number[j])
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        public bool IsInputCorrect(string number)
        {
            if (number.Length != 4) return false;

            if (HasSameSymbols(number)) return false;

            if (!int.TryParse(number, out _)) return false;

            if (number[0] == '0') return false;

            return true;
        }

        public int[] CheckNumbers(string firstNumber, string secondNumber)
        {
            int bulls = 0;
            int cows = 0;
            int[] bullsAndCows = new int[2];
            for (int i = 0; i < firstNumber.Length; i++)
            {
                for (int j = 0; j < firstNumber.Length; j++)
                {
                    if (firstNumber[i] == secondNumber[j])
                    {
                        if (i == j)
                        {
                            bulls++;
                        }
                        else
                        {
                            cows++;
                        }
                    }
                }
            }

            for (int i = 0; i < bullsAndCows.Length; i++)
            {
                bullsAndCows[i] = bulls;
                bullsAndCows[i + 1] = cows;
                i++;
            }

            return bullsAndCows;
        }

        public string TakeInput()
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            while (!IsInputCorrect(input))
            {
                Console.WriteLine();
                Console.WriteLine("Wrong input!");
                Console.WriteLine();
                Console.Write("> ");
                input = Console.ReadLine();
            }

            return input;
        }
    }
}
