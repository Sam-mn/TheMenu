﻿using System.ComponentModel;

namespace TheMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool stopTheApp = false;

            do
            {
                ShowMainMeny();
                var input = Console.ReadLine()!;
                switch (input)
                {
                    case "0":
                        stopTheApp = true;
                        break;
                    case "1":
                        checkTheAge();
                        break;
                    case "2":
                        repeatTenTimes();
                        break;
                    case "3":
                        getTheThirdWord();
                        break;
                    default:
                        Console.WriteLine("Incorrect input, try again.");
                        break;

                }

            } while (!stopTheApp);
        }

        private static void getTheThirdWord()
        {
            Console.Write("Enter a sentence of at least 3 words: ");
            string input = Console.ReadLine();

            var words = input.Split(" ");

            if(words.Length >= 3)
            {
                Console.WriteLine($"The third word is: {words[2]}");
            }
            else
            {
                Console.WriteLine($"The sentence must contain at least 3 words. TRY AGAIN");
                getTheThirdWord();
            }

        }

        private static void repeatTenTimes()
        {
            Console.Write("Write a text: ");
            string text = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}. {text}");
                if (i < 10)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        private static void checkTheAge()
        {
            Console.WriteLine("How many people are you?");
            int num = int.Parse(Console.ReadLine()!);
            int thePrice = 0;

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine($"Could you write your age for number {i + 1}?");
                int age = int.Parse(Console.ReadLine()!);

                if (age < 5) {
                    Console.WriteLine("Too yung to bay");
                    thePrice += 0;
                }
                else if (age < 20)
                {
                    Console.WriteLine("youth price: 80kr");
                    thePrice += 80;
                }
                else if (age > 64)
                {
                    Console.WriteLine("Pensioner price: 90kr");
                    thePrice += 90;
                }
                else if(age > 100)
                {
                    Console.WriteLine("If you are over 100 and still alive, we will pay for you");
                    thePrice += 0;
                }
                else
                {
                    Console.WriteLine("Standard price: 120kr");
                    thePrice += 120;
                }
            }

            Console.WriteLine($"Antal personer: {num}");
            Console.WriteLine($"Price: {thePrice}");
        }

        private static void ShowMainMeny()
        {
            Console.WriteLine("You are now in the main menu, and you can chose a number between 0 and 2 to test our function.");
            Console.WriteLine("0. Close the program");
            Console.WriteLine("1. Youth or pensioner");
            Console.WriteLine("2. Try repeat function");
            Console.WriteLine("3. The third word");

        }
    }
}