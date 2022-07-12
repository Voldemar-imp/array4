using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userInputArray = new int[0];        
            string userInput;
            int userInputSum = 0;
            bool areContinue = true;

            while (areContinue)
            {
                int[] tempUserInputArray = new int[userInputArray.Length + 1];

                for (int i = 0; i < userInputArray.Length; i++)
                {
                    tempUserInputArray[i] = userInputArray[i];
                }

                Console.WriteLine("Введите число или комманду:  exit - для выхода, sum - для вывода суммы чисел в массиве");
                userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    areContinue = false;
                }
                else if (userInput == "sum")
                {
                    for (int i = 0; i < userInputArray.Length; i++)
                    {
                        userInputSum += userInputArray[i];
                    }

                    Console.WriteLine("Сумма чисел в массиве = " + userInputSum);
                }
                else
                {
                    tempUserInputArray[tempUserInputArray.Length - 1] = Convert.ToInt32(userInput);
                    userInputArray = tempUserInputArray;
                    Console.WriteLine("Сейчас массив содержит следующие числа: ");

                    for (int i = 0; i < userInputArray.Length; i++)
                    {
                        Console.Write(userInputArray[i] + " ");
                    }
                }

                    Console.ReadKey();
                    Console.Clear();                
            }
        }
    }
}
