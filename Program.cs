using System;

namespace CSharp.LabExercise2
{
    
    class Program
    {
        static void Number1()
        {
            int[] number = new int[5];
            int counter = 0;
            
            while(counter < number.Length)
            {
                Console.Write("Enter numer: ");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                

                if(inputNumber >= 10 && inputNumber <= 100)
                {
                    if (Array.Exists(number, element => element == inputNumber))
                    {
                        Console.WriteLine(inputNumber + " has already been entered");
                    }
                    else
                    {
                        number[counter] = inputNumber;
                        counter++;

                        foreach(int index in number)
                        {
                            if (index > 0)
                            {
                                Console.Write("{0}  ", index);
                            }
                        }
                        Console.Write("\n");
                    }
                }
                else
                {
                    Console.WriteLine("Number must be between 10 and 100.");
                }
            }

            Console.Write("Continue? y/n: ");
            string choice = Console.ReadLine();
            if (choice == "y" || choice == "Y")
            {
                Number1();
            }
            else if (choice == "n" || choice == "N")
            {
                Console.Clear();
                Main();
            }

        }

        public class Lasagna
        {
            public int ExpectedOvenTimeInMinutes()
            {
                return 40;
            }

            public int RemainingOvenTimeInMinutes(int minutes)
            {
                return 40 - minutes;
            }

            public int PreparationTimeInMinutes(int layers)
            {
                return 2 * layers;
            }

            public int ElapsedTimeinMinutes(int layers, int time)
            {
                return (2 * layers) + time;
            }
        }
        static void Number2()
        {
            var lasagna = new Lasagna();
            Console.WriteLine($"Expected Oven Time in Minutes: {lasagna.ExpectedOvenTimeInMinutes()}");
            Console.WriteLine($"Remaining Oven Time in Minutes: {lasagna.RemainingOvenTimeInMinutes(30)}");
            Console.WriteLine($"Lasagna preparation in Minutes: {lasagna.PreparationTimeInMinutes(2)}");
            Console.WriteLine($"Lasagna elapsed time in Minutes: {lasagna.ElapsedTimeinMinutes(3, 20)}");

            Console.Write("Continue? y/n: ");
            string choice = Console.ReadLine();
            if (choice == "y" || choice == "Y")
            {
                Number2();
            }
            else if (choice == "n" || choice == "N")
            {
                Console.Clear();
                Main();
            }
        }


        static void Main()
        {
            Console.WriteLine("CSHARP LAB EXERCISE 2 BY MIKKO ANGELO DACASIN");
            Console.WriteLine("[1] NUMBER 1 PROBLEM");
            Console.WriteLine("[2] NUMBER 2 PROBLEM");
            Console.WriteLine("[3] EXIT");
            Console.Write("Enter Problem Number: ");
            int problemNumber = Convert.ToInt32(Console.ReadLine());

            if (problemNumber == 1)
            {
                Console.Clear();
                Number1();
            }
            else if (problemNumber == 2)
            {
                Console.Clear();
                Number2();
            }
            else if (problemNumber == 3)
            {
                Environment.Exit(-1);
            }
            //Number1();
            //Number2();
        }
    }
}
