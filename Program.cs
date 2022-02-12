using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _297assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();

            }

        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Return a string without the Whitespaces");
            Console.WriteLine("2) Reverse a string");
            Console.WriteLine("3) Display the quotient and remainder");
            Console.WriteLine("4) Find the logarithm of a specified number to base 10");
            Console.WriteLine("5) Find the logarithm of a specified number to a specified base");
            Console.WriteLine("6) Display the minimum and maximum of the two numbers");
            Console.WriteLine("7) Find the specified number to the specified power");
            Console.WriteLine("8) Find the roots of a quadratic equation");
            Console.WriteLine("9) Find the square root of the given number");
            Console.WriteLine("10) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1"://1.	Return a string without the Whitespaces
                    RemoveWhitespace();
                    return true;
                case "2"://2.	Reverse a string
                    ReverseString();
                    return true;
                case "3"://3.   Display the quotient and remainder
                    displayQuotientAndRemainder();
                    return true;
                case "4"://4.   Find the log of a specified number to base 10
                    logBase10();
                    return true;
                case "5"://5.   Find the log of a specified number with a specified base
                    findLog();
                    return true;
                case "6"://6/   Find min and max
                    DisplayMinMax();
                    return true;
                case "7"://7.   Find the speicifed number to a specified power
                    findExp();
                    return true;
                case "8"://8.   Find roots
                    findRoots();
                    return true;
                case "9": // Sqrt-Square Root. This function returns the square root of the given number.
                    SquareRoot();
                    return true;
                case "10":
                    return false;
                default:
                    return true;
            }
        }

        /// <summary>
        /// This method captures user input as a string
        /// </summary>
        /// <returns>The <see cref="System.String"/returns>
        private static string CaptureInput()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// 2.	Reverse a string
        /// </summary>
        private static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Reverse String");

            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }
        /// <summary>
        /// 1.	Return a string without the Whitespaces
        /// </summary>

        private static void RemoveWhitespace()
        {
            Console.Clear();
            Console.WriteLine("Remove Whitespace");

            DisplayResult(CaptureInput().Replace(" ", ""));
        }

        /// <summary>
        /// Displays the result as a modified string
        /// </summary>
        /// <param name="message">The <see cref="System.String"/> message to display.</param>
        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

        /// <summary>
        /// Displays the quotient and remainder of two values
        /// </summary>
        private static void displayQuotientAndRemainder()
        {
            int numerator, denominator, quotient, remainder;
            Console.Write("Enter a numerator: ");
            numerator = int.Parse(Console.ReadLine());
            Console.Write("\nEnter a denominator: ");
            denominator = int.Parse(Console.ReadLine());

            quotient = numerator / denominator;
            remainder = numerator % denominator;

            Console.WriteLine($"The quotient is: {quotient} and the remainder is: {remainder}");

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        /// <summary>
        /// Finds the log base 10 of a specified number
        /// </summary>
        private static void logBase10()
        {
            double logResult;
            Console.Write("Enter a number to find the log of: ");
            double num = double.Parse(Console.ReadLine());
            logResult = Math.Log10(num);
            Console.WriteLine($"The log of {num} is: {logResult}");

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        /// <summary>
        /// Finds the log of a specified number with a specified base
        /// </summary>
        private static void findLog()
        {
            double num, logBase, result;
            Console.Write("Enter a number to find the log of: ");
            num = double.Parse(Console.ReadLine());
            Console.Write("\nEnter a base of the logarithm: ");
            logBase = double.Parse(Console.ReadLine());

            result = Math.Log(num, logBase);

            Console.WriteLine($"The log of {num} with base {logBase} is: {result}");

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        /// <summary>
        /// Finds the minimum and maximum of two numbers
        /// </summary>
        private static void DisplayMinMax()
        {
            double num1, num2, min, max;

            Console.Write("Enter the first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("\nEnter the second number: ");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                max = num1;
                min = num2;
            }

            else
            {
                max = num2;
                min = num1;
            }

            Console.WriteLine($"The maximum is: {max} and the minimum is {min}");

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        /// <summary>
        /// Finds the specified exponent of a specified number
        /// </summary>
        private static void findExp()
        {
            double num, exp, result;
            Console.Write("Enter a number: ");
            num = double.Parse(Console.ReadLine());
            Console.Write("\nEnter an exponent: ");
            exp = double.Parse(Console.ReadLine());

            result = Math.Pow(num, exp);

            Console.WriteLine($"The result is {result}");

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        /// <summary>
        /// Finds the roots of a quadratic equation
        /// </summary>
        private static void findRoots()
        {
            double x1, x2, a, b, c, d;
            Console.Write("Enter the coefficient of A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\nEnter the coefficient of B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("\nEnter the coefficient of C: ");
            c = double.Parse(Console.ReadLine());

            d = (Math.Pow(b, 2) - (4 * a * c));

            if (d == 0)
            {
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.WriteLine($"Roots are: {x1} and {x2}");
            }

            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(d)) / (2.0 * a);

                Console.WriteLine($"Roots are: {x1} and {x2}");
            }

            else
            {
                Console.WriteLine("There are no real roots");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        /// <summary>
        /// 9. Sqrt-Square Root. This function returns the square root of the given number.
        /// </summary>

        private static void SquareRoot()
        {
            Console.Clear();
            Console.WriteLine("Find the square root of the given number");
            Console.Write("Enter the number: ");
            double number7 = double.Parse(Console.ReadLine());
            Console.WriteLine("Square root of {0} is {1}.", number7, Math.Sqrt(number7));
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}
