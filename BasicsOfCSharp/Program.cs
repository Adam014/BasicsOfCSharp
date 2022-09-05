using System;

namespace BasicsOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /// program vykresli nasledujici obrazek
            /// 
            ///  * * * * * * * 0
            ///  * * * * * * * 0
            ///  0 0 0 0 0 0 0 0   
            ///  * * 0 * * 0 * 0
            ///  * * * 0 0 * * 0


            Console.WriteLine("///");
            Console.WriteLine("Vykreslovani\n");
            for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j == 7 || i == 2 || i + j == 8 || i - j == 1)
                        {
                            Console.Write("0 ");
                        }
                        else
                        {
                            Console.Write("* ");
                        }
                    }
                Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            ///drawing a shape
            ///

                Console.WriteLine("   /|");
                Console.WriteLine("  / |");
                Console.WriteLine(" /  |");
                Console.WriteLine("/___|");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("///");
                Console.WriteLine("Strings\n");

            ///strings
            ///

                string phrase = "Hi how are you";
                Console.Write("1. "); Console.WriteLine(phrase.Length);
                Console.Write("2. "); Console.WriteLine(phrase.ToUpper());
                Console.Write("3. "); Console.WriteLine(phrase.ToLower());
                Console.Write("4. "); Console.WriteLine(phrase.Contains("how"));
                Console.Write("5. "); Console.WriteLine(phrase.IndexOf("u"));
                // if in IndexOf the char is not in the string, it will show -1
                Console.Write("6. "); Console.WriteLine(phrase.Substring(7, 3));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("///");
                Console.WriteLine("Numbers\n");

            ///numbers
            ///

                Console.Write("7. "); Console.WriteLine(Math.Abs(-40));
                //na druhou apod.
                Console.Write("8. "); Console.WriteLine(Math.Pow(3, 5));
                Console.Write("9. "); Console.WriteLine(Math.Sqrt(36));
                Console.Write("10. "); Console.WriteLine(Math.Max(70, 71));
                Console.Write("11. "); Console.WriteLine(Math.Min(70, 71));
                Console.Write("12. "); Console.WriteLine(Math.Round(4.6));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("///");
                Console.WriteLine("Getting user input\n");

            ///getting user input
            ///

                Console.WriteLine("13. ");
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your age: ");
                string age = Console.ReadLine();
                Console.WriteLine("Welcome " + name + "! You are " + age + " years old.");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("///");
                Console.WriteLine("Methods\n");

            ///methods
            ///

                SayHi("Lukas", 18);

                Console.WriteLine("///\n");
                int cubedNumber = cube(5);
                Console.WriteLine(cubedNumber);
                cube(5);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("///");   
                Console.WriteLine("If statements\n");

            //if statements

                Console.WriteLine("///");
                Console.WriteLine("If Statements\n");

                bool isMale = false;
                bool isTall = true;
                // || (or) nebo && (and)

                if (isMale && isTall)
                {
                    Console.WriteLine("You are a tall male.");
                }
                else if (isMale && !isTall)
                {
                    Console.WriteLine("You are a short male.");
                }
                else if (!isMale && isTall) 
                {
                    Console.WriteLine("You are not a male, but you are tall. ");
                }
                else
                {
                    Console.WriteLine("You are not male and not tall.");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            /// more if statement, comparisons
            /// 


            Console.WriteLine("///");
                Console.WriteLine("More If statements, comparisons\n");

                Console.Write("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(num1, num2));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            /// better calculator
            /// 

                Console.WriteLine("///");
                Console.WriteLine("Calculator\n");

                Console.Write("Enter a number: ");
                double cislo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter a number2: ");
                double cislo2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operator (+, -, /, *): ");
                string op = Console.ReadLine();

                if (op == "+")
                {
                    Console.WriteLine("Result is {0}.", cislo + cislo2);
                }
                else if (op == "-")
                {
                    Console.WriteLine("Result is {0}.", cislo - cislo2);
                }   
                else if (op == "/")
                {
                    Console.WriteLine("Result is {0}.", cislo / cislo2);
                }
                else if (op == "*")
                {
                    Console.WriteLine("Result is {0}.", cislo * cislo2);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong operator!");
                    Console.ResetColor();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            /// guessing game
            ///

                Console.WriteLine("///");
                Console.WriteLine("Guessing Game\n");

                string secretword = "sussyballs";
                string guess = "";
                int guesscount = 0;
                int guesslimit = 3;
                bool outOfGuesses = false;

                while (guess != secretword && !outOfGuesses)
                {
                    if (guesscount < guesslimit)
                    {
                        Console.Write("Enter guess: ");
                        guess = Console.ReadLine();
                        guesscount++;
                    }
                    else
                    {
                        outOfGuesses = true;
                    }
                }
                if (outOfGuesses)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win!");
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            /// for loops
            /// 

                Console.WriteLine("///");
                Console.WriteLine("For Loops\n");

                int[] luckyNumbers = { 2, 4, 8, 16, 32, 64, 128 };
           
                for (int z = 0; z < luckyNumbers.Length; z++)
                {
                    Console.WriteLine(luckyNumbers[z]);
                }
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            /// building an exponent method 
            ///


                Console.WriteLine("///");
                Console.WriteLine("Building an exponent method\n");

                Console.WriteLine(GetPow(3,2));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            /// building 2d arrays
            ///

                Console.WriteLine("///");
                Console.WriteLine("Building 2d arrays\n");

                int[,] numberGrid = {
                    {1, 2 },
                    {3, 4 },
                    {5, 6 }
                };
                int[,] myArray = new int[2, 3];

                Console.WriteLine(numberGrid[1, 1]);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            /// Exception handling
            /// 

                Console.WriteLine("///");
                Console.WriteLine("Exception handling\n");

                try
                {
                    Console.Write("Enter a number: ");
                    int cislo3 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter a number: ");
                    int cislo4 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(cislo3 / cislo4);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            /// classes & objects (constructors)
            /// 

                Console.WriteLine("///");
                Console.WriteLine("Classes & Objects\n");

                Book book1 = new Book("Harry Potter", "JK Rowling", 600);
                Book book2 = new Book("Lord Of the Rings", "Tolkein", 800);

                Console.WriteLine(book2.title);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            /// object methods
            /// 

                Console.WriteLine("///");
                Console.WriteLine("Object methods\n");

                Student student1 = new Student("Jim", "Business", 2.8);
                Student student2 = new Student("Pam", "Art", 3.6);

                Console.WriteLine(student1.HasHonors());
                Console.WriteLine(student2.HasHonors());

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            /// Getters and setters
            /// 

                Console.WriteLine("///");
                Console.WriteLine("Getters and setters\n");

                Movie avengers = new Movie("The Avengers", "Joss Whedon", "Dog");
                Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
                // rating for movies = G, PG, PG-13, R, NR

                Console.WriteLine(avengers.Rating);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            /// Static Class Attributes
            /// 

                Console.WriteLine("///");
                Console.WriteLine("Static Class Attributes\n");

                Song holiday = new Song("Holiday", "Green Day", 200);
                // print that first song was created
                Console.WriteLine(Song.songCount);
                Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
                // created method 
                Console.WriteLine(kashmir.getSongCount());
  

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            /// Static methods & classes
            /// 

                Console.WriteLine("///");
                Console.WriteLine("Static methods & classes\n");

                UsefulTools.SayHi("Mike");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to continue!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            /// Inheritance
            /// 

                Console.WriteLine("///");
                Console.WriteLine("Inheritance\n");

                Chef chef = new Chef();
                chef.MakeChicken();

                ItalianChef italianchef = new ItalianChef();
                italianchef.MakeSpecialDish();

            Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHit ENTER to exit!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            //reading code and stop window to closing

            Console.ReadKey();
        }
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + "!, you are years " + age + " old!\n");
        }
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
        static int GetMax(int number1, int number2)
        {
            int result2;
            if (number1 > number2)
            {
                result2 = number1;
            }
            else
            {
                result2 = number2;
            }

            return result2;
        }
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int a = 0; a < powNum; a++)
            {
                result = result * baseNum;
            }

            return result;
        }
    }
}
