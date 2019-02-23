using System;


namespace The_Calculon
{
    class Program
    {
        
        static void Addition(int x, int y) // Addition method
        {   
            int result = x + y;
            Console.WriteLine($"Result: \t {result}");
        }

        static void Subtraction(int x, int y) // Subtraction method
        {
            int result = x - y;
            Console.WriteLine($"Result: \t {result}");
        }

        static void Multiplication(int x, int y) // Multiplication method
        {
            int result = x * y;
            Console.WriteLine($"Result: \t {result}");
        }

        static void Division(int x, int y) // Division method
        {
            if (y == 0)
                Console.Write("Division by 0 is restricted! \n");
            else
            {
                int result = x / y;
                Console.WriteLine($"Result: \t {result}");
            }
        }

        static void RemDivision(int x, int y) // Remainder of division method
        {
            if (y == 0)
                Console.Write("Division by 0 is restricted! \n");
            else
            {
                int result = x % y;
                Console.WriteLine($"Result: \t {result}");
            }
        }

        static void Factorial(int x) // Factorial method
        {
          
            
            ulong result = 1;

            if ((x == 0) | (x == 1))
                result = 1;

            else if ((x > 1) && (x < 13))
            {
                for (int i = x; i > 1; i--)
                    x *= i - 1;
                ulong helper = (ulong)x;
                result = helper;


                Console.WriteLine($"Result: \t {result}");
            }
            else
                Console.WriteLine("Error: wrong number!");


        }

        static void Power(int x, int y) // Power method
        {
            double result = Math.Pow(x, y);

            Console.WriteLine($"Result: \t {result}");
        }

        static void Sqrt(int x) // Square root method
        {
            double result = 1;
            if (x < 0)
                Console.WriteLine("Inappropriate number!");
            else if (x == 0)
                Console.WriteLine($"Result: \t {0}", x);
            else
            {
                result = Math.Sqrt(x);
                Console.WriteLine($"Result: \t {result}");
            }
        }



        static void Main(string[] args)
        {
            /* input checkers */

            bool isInt1;
            bool isInt2;


            Console.WriteLine("\t \t \t \t \t \tWelcome to the Calculon! \n");
            Console.WriteLine("\t \t \t \t  Choose operation by writing the number of it: \t \n");
            Console.WriteLine("\t \t \t WARINING: The Calculon works only with integers! \t \n");

            while (true) //Infinite loop to keep program working until it is manualy closed
            {

                Console.WriteLine("1) Addition (a+b) \n");
                Console.WriteLine("2) Subtraction (a-b) \n");
                Console.WriteLine("3) Multiplication (a*b)\n");
                Console.WriteLine("4) Division (a/b) \n");
                Console.WriteLine("5) Remainder of the division (a%b) \n");
                Console.WriteLine("6) Factorial (a!) \n");
                Console.WriteLine("7) Power (a^) \n");
                Console.WriteLine("8) Square root (√a) \n");

                Console.WriteLine("If you want to terminate, enter \"stop\". \n");



                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": //Addition
                        Console.WriteLine("Enter the 1st number: \t");
                        string num1 = Console.ReadLine();
                        isInt1 = int.TryParse(num1, out int actualNum1);

                        if (isInt1)
                        {
                            Console.WriteLine("Enter the 2nd number: \t");
                            string num2 = Console.ReadLine();
                            isInt2 = int.TryParse(num2, out int actualNum2);

                            if (isInt2)
                            {
                                Addition(actualNum1, actualNum2);
                            }
                            else
                                Console.WriteLine("Error: wrong type!");

                        }
                        else
                            Console.WriteLine("Error: wrong type!");
                        break;
                        

                    case "2": //Subtraction
                        Console.WriteLine("Enter the 1st number: \t");
                        string num3 = Console.ReadLine();
                        isInt1 = int.TryParse(num3, out int actualNum3);

                        if (isInt1)
                        {
                            Console.WriteLine("Enter the 2nd number: \t");
                            string num4 = Console.ReadLine();
                            isInt2 = int.TryParse(num4, out int actualNum4);

                            if (isInt2)
                            {
                                Subtraction(actualNum3, actualNum4);
                            }
                            else
                                Console.WriteLine("Error: wrong type!");

                        }
                        else
                            Console.WriteLine("Error: wrong type!");
                        break;

                    case "3": //Multiplication
                        Console.WriteLine("Enter the 1st number: \t");
                        string num5 = Console.ReadLine();
                        isInt1 = int.TryParse(num5, out int actualNum5);

                        if (isInt1)
                        {
                            Console.WriteLine("Enter the 2nd number: \t");
                            string num6 = Console.ReadLine();
                            isInt2 = int.TryParse(num6, out int actualNum6);

                            if (isInt2)
                            {
                                Multiplication(actualNum5, actualNum6);
                            }
                            else
                                Console.WriteLine("Error: wrong type!");

                        }
                        else
                            Console.WriteLine("Error: wrong type!");
                        break;

                    case "4": //Divison
                        Console.WriteLine("Enter the 1st number: \t");
                        string num7 = Console.ReadLine();
                        isInt1 = int.TryParse(num7, out int actualNum7);

                        if (isInt1)
                        {
                            Console.WriteLine("Enter the 2nd number: \t");
                            string num8 = Console.ReadLine();
                            isInt2 = int.TryParse(num8, out int actualNum8);

                            if (isInt2)
                            {
                                Division(actualNum7, actualNum8);
                            }
                            else
                                Console.WriteLine("Error: wrong type!");

                        }
                        else
                            Console.WriteLine("Error: wrong type!");
                        break;

                    case "5": //Remainder of division
                        Console.WriteLine("Enter the 1st number: \t");
                        string num9 = Console.ReadLine();
                        isInt1 = int.TryParse(num9, out int actualNum9);

                        if (isInt1)
                        {
                            Console.WriteLine("Enter the 2nd number: \t");
                            string num10 = Console.ReadLine();
                            isInt2 = int.TryParse(num10, out int actualNum10);

                            if (isInt2)
                            {
                                RemDivision(actualNum9, actualNum10);
                            }
                            else
                                Console.WriteLine("Error: wrong type!");

                        }
                        else
                            Console.WriteLine("Error: wrong type!");
                        break;

                    case "6": //Factorial
                        Console.WriteLine("Enter number: \t");
                        string num11 = Console.ReadLine();
                        isInt1 = int.TryParse(num11, out int actualNum11);

                        if (isInt1)
                            Factorial(actualNum11);
                        else
                            Console.WriteLine("Error: wrong type!");
                        break;

                    case "7": //Power
                        Console.WriteLine("Enter number: \t");
                        string num12 = Console.ReadLine();
                        isInt1 = int.TryParse(num12, out int actualNum12);

                        if (isInt1)
                        {
                            Console.WriteLine("Enter degree: \t");
                            string num13 = Console.ReadLine();
                            isInt2 = int.TryParse(num13, out int actualNum13);

                            if (isInt2)
                            {
                                Power(actualNum12, actualNum13);
                            }
                            else
                                Console.WriteLine("Error: wrong type!");

                        }
                        else
                            Console.WriteLine("Error: wrong type!");
                        break;

                    case "8": //Square root
                        Console.WriteLine("Enter number: \t");
                        string num14 = Console.ReadLine();
                        isInt1 = int.TryParse(num14, out int actualNum14);

                        if (isInt1)
                            Sqrt(actualNum14);
                        else
                            Console.WriteLine("Error: wrong type!");
                        break;

                    case "stop":
                        Console.WriteLine("\t \t \t The Calculon is terminated. Press any key to exit... \n");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Unknown symbol, error! \n");
                        break;

                }

                    while (true) //Reusability without reopening app
                        {
                            Console.WriteLine("Would you like to make an another operation? Y - \"Yes\" N - \"No\" \n");
                            string decision = Console.ReadLine();
                            decision.ToLower();

                            if (decision == "y")
                                break;

                            else if (decision == "n")
                                Environment.Exit(0);

                            else
                                Console.WriteLine("Wrong command!");
                                continue;
                        }
                
                    

                
            }
            

        }
    }
}
