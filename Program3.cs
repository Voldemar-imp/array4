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
            bool areContinue = true;

            while (areContinue)
            {    
                Console.WriteLine("Введите число или комманду:  exit - для выхода, sum - для вывода суммы чисел в массиве");
                userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    areContinue = false;
                }
                else if (userInput == "sum")
                {
                    int userInputSum = 0;

                    for (int i = 0; i < userInputArray.Length; i++)
                    {
                        userInputSum += userInputArray[i];
                    }

                    Console.WriteLine("сума чисел в массиве = " + userInputSum);
                }
                else
                {
                    int[] tempUserInputArray = new int[userInputArray.Length + 1];

                    for (int i = 0; i < userInputArray.Length; i++)
                    {
                        tempUserInputArray[i] = userInputArray[i];
                    }

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
