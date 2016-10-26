using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab3
{
    class Program
    {

        private static int convToInt(string input)
        {
            // Name: convToInt
            // Description: This method checks to make sure the value is an integer.
            // Input: This method takes a string as input.  This string should be an integer
            // Output: If the input is a valid integer, it returns the input converted to integer.
            //         If the input is invalid, it returns a 0 in integer format.

            try
            {
                // Attempt to convert the user's input into an integer
                int output = Convert.ToInt32(input);
                return output;
            }

            // Check for various error conditionss, and if you find something return 0
            catch (OverflowException)
            {
                Console.WriteLine("\nThe conversion from string to number overflowed.\n");
                return 0;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nThe string is not formatted as a number.\n");

                return 0;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The string is null.");
                return 0;
            }
            catch (Exception)
            {
                Console.WriteLine("You did something wrong.  Not sure what.\n");
                return 0;
            }
        }

        private static double convToDouble(string input)
        {
            // Name: convToDouble
            // Description: This method checks to make sure the value is a double
            // Input: This method takes a string as input.  This string should be a valid double.
            // Output: If the input is a valid double, it returns the input converted to double.
            //         If the input is invalid, it returns a 0 in double format.
            try
            {
                // Verify user input is in correct format 
                double output = Convert.ToSingle(input);
                return output;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nThe conversion from string to number overflowed.\n");
                return 0;
            }

            // Check for various error conditionss, and if you find something return 0
            catch (FormatException)
            {
                Console.WriteLine("\nThe string is not formatted as a number.\n");

                return 0;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The string is null.");
                return 0;
            }
            catch (Exception)
            {
                Console.WriteLine("You did something wrong.  Not sure what.\n");
                return 0;
            }
        }

        static void printSquaredCubed(float input)
        {
            // Format the title information for output
            string numberTitle = "Number".PadRight(20);
            string squaredTitle = "Squared".PadRight(20);
            string cubedTitle = "Cubed".PadRight(20);
            string underline = "========".PadRight(20);

            // Print the title
            Console.WriteLine(numberTitle + squaredTitle + cubedTitle);
            Console.WriteLine(underline + underline + underline);

            // Square and cube numbers until the number input
            for (float i = 1; i <= input; i++)
            {
                // Square the number
                float squared = (i * i);
                // Cube the number
                float cubed = (i * i * i);
                // Print the base number, squared number, and cubed number
                string numberS = i.ToString().PadRight(20);
                string squaredS = squared.ToString().PadRight(20);
                string cubedS = cubed.ToString().PadRight(20);
                Console.WriteLine(numberS+squaredS+cubedS);
             }
        }

        static void Main(string[] args)
        {
            // Loop until the user inputs "n"
            string keepGoing = "y";
            while (keepGoing.ToLower() != "n" && keepGoing.ToLower() != "no")
            {
                // Get user inpout for the number of times the square and cube calculations should be done
                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine("Enter an integer:");
                string input = Console.ReadLine();
                // Convert the string input to a double.  I do this for the error checking available in
                // the try and catch available from System 
                double maxd = convToDouble(input);
                Console.WriteLine("This is what was output" + maxd);
                // Convert the double to a float.  This is for maximum calculations.
                float maxf = (float)maxd;

                // As long as input is valid, print the squared and cubed numbers.
                if (maxf != 0)
                {
                    printSquaredCubed(maxf);
                }

                // Ask user if they want to continue.  If they type "n" or "N" or "no" or "NO", they will drop out of loop
                Console.WriteLine("\nContinue? (y/n) ");
                keepGoing = Console.ReadLine();

            }
        }
    }
}

