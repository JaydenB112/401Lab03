using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.ComponentModel.Design;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menuSelect = false;
            Console.WriteLine("Enter 1 to run Challenge 1");
            Console.WriteLine("Enter 2 to run Challenge 2");
            Console.WriteLine("Enter 3 to run Challenge 3");
            Console.WriteLine("Enter 4 to run Challenge 4");
            Console.WriteLine("Enter 5 to run Challenge 5");
            Console.WriteLine("Enter 6 to run Challenge 6");
            Console.WriteLine("Enter 7 to run Challenge 7");
            Console.WriteLine("Enter 8 to run Challenge 8");
            Console.WriteLine("Enter 9 to run Challenge 9");
            Console.WriteLine("Enter 10 to exit");
            string input = Console.ReadLine();
            while (menuSelect == false)
            {
                if (input == "1")
                {
                    Challenge1();
                }
                else if (input == "2")
                {
                    Challenge2();
                }
                else if (input == "3")
                {
                    Challenge3();
                }
                else if (input == "4")
                {
                    Challenge4();
                }
                else if (input == "5")
                {
                    Challenge5();
                }
                else if (input == "6")
                {
                    Challenge6();
                }
                else if (input == "7")
                {
                    Challenge7();
                }
                else if (input == "8")
                {
                    Challenge8();
                }
                else if (input == "9")
                {
                    Challenge9();
                }


                else if (input == "10")
                {
                    menuSelect = true;
                }
            }
            static void Challenge1()
            {
                Console.Write("Enter 3 Numbers: ");
                string input = Console.ReadLine();
                string[] inputNumbers = input.Split(" ");
                int[] numbers = new int[inputNumbers.Length];
                Console.WriteLine(input);
                if (numbers.Length < 3)
                {
                    throw new Exception("You entered less than 3 numbers, you suck and you're horrible.");
                }
                for (int i = 0; i < inputNumbers.Length; i++)
                {
                    int number = int.Parse(inputNumbers[i]);
                    numbers[i] = number;
                }
                int product = 1;
                for (int i = 0; i < 3; i++)
                {
                    product *= numbers[i];

                }
                Console.WriteLine("The product of these 3 numbers is: {0}", product);
            }

            static void Challenge2()
            {
                Console.Write("Gimmie a number between 2-10");
                string input = Console.ReadLine();
                int numberOfInstances = Convert.ToInt32(input);
                int sum = 0;
                for (int i = 0; i < numberOfInstances; i++)
                {
                    Console.WriteLine($"{i + 1} of {numberOfInstances}- Enter a number: ");
                    string numberEntered = Console.ReadLine();
                    int enteredNumber = Convert.ToInt32(numberEntered);
                    sum += enteredNumber;
                }
                int average = sum / numberOfInstances;
                Console.WriteLine($"This is the average of the numbers you selected {average}.");
            }

            static void Challenge3()
            {


            }

            static void Challenge4()
            {
                int[] numbers = new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 6, 7, 8, 2, 1, 1 };
                int mostSeen = numbers[0];
                int highScore = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    int currentNumber = numbers[i];
                    int timesSeen = 1;
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (currentNumber == numbers[j])
                        {
                            timesSeen++;
                        }
                    }
                    if (timesSeen > highScore)
                    {
                        mostSeen = currentNumber;
                        highScore = timesSeen;
                    }
                }
                Console.WriteLine($"This is the number we see da most : {mostSeen}");
            }

            static void Challenge5()
            {
                int[] numbers = new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 400000000 };
                int highestNumber = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > highestNumber)
                    {
                        highestNumber = numbers[i];
                    }
                }
                Console.WriteLine($"This is the highest number, yipee : {highestNumber}");
            }

            static void Challenge6()
            {
                Console.WriteLine("Gimmie a word");
                string input = Console.ReadLine();
                File.WriteAllText("C:\\Users\\jayde\\Documents\\GitHub\\401Lab03\\Lab03\\words.txt", input);
            }

            static void Challenge7()
            {
                string contents = File.ReadAllText("C:\\Users\\jayde\\Documents\\GitHub\\401Lab03\\Lab03\\words.txt");
                Console.WriteLine(contents);
            }

            static void Challenge8()
            {
                string contents = File.ReadAllText("C:\\Users\\jayde\\Documents\\GitHub\\401Lab03\\Lab03\\words.txt");
                string[] words = contents.Split(' ');
                words[words.Length - 1] = "";
                string updatedContents = "";
                foreach (string word in words)
                {
                    updatedContents += word;
                }
                File.WriteAllText("C:\\Users\\jayde\\Documents\\GitHub\\401Lab03\\Lab03\\words.txt", updatedContents);
            }

            static void Challenge9()
            {
                Console.Write("Gimmies a sentence.");
                string sentence = Console.ReadLine();
                string[] words = sentence.Split(" ");
                for (int i = 0; i < words.Length; i++)
                {
                    int numberOfLetters = words[i].Length;
                    words[i] = $"{words[i]}: {numberOfLetters}";
                    Console.WriteLine($"{words} ");
                }

            }


        }
    }
}