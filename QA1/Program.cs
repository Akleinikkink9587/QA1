using System;

namespace QA1
{
    class Program
    {
        static void Main(string[] args)
        {
            // string that stores selection
            string selection;

            // initialize calss
            Rectangle rectangle = new Rectangle();

            // while keeps menu running
            while (true)
            {
                // menu
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit\n");
                Console.Write("Input : ");
                selection = Console.ReadLine(); // get selection

                // clear
                Console.Clear();

                // select option
                switch (selection)
                {
                    case "1": // get length
                        Console.WriteLine("The rectangle length is " + rectangle.GetLength());
                        break;
                    case "2": // change length
                        Console.WriteLine("\nThe new length is " + rectangle.SetLength(valNum("length")));
                        break;
                    case "3": // get width
                        Console.WriteLine("The rectangle width is " + rectangle.GetWidth());
                        break;
                    case "4": // change width
                        Console.WriteLine("\nThe new width is " + rectangle.SetWidth(valNum("width")));
                        break;
                    case "5": // get perimeter
                        Console.WriteLine("The rectangle perimeter is " + rectangle.GetPerimeter());
                        break;
                    case "6": // get area
                        Console.WriteLine("The rectangle area is " + rectangle.GetArea());
                        break;
                    case "7": // close program
                        return;
                    default: // invalid input
                        Console.WriteLine(selection + " is an invalid input");
                        break;
                }

                Console.Write("\nPress any key to continue..."); // wait to go back to main menu
                Console.ReadKey();
                Console.Clear();
            }

            int valNum(string side)
            {
                // temp string
                string tempS;

                // temp int
                int tempI;

                // while until input is valid
                while (true)
                {
                    // sub menu
                    Console.WriteLine("New rectangle " + side);
                    Console.Write("Input : ");
                    tempS = Console.ReadLine(); // get input
                    try // check for exceptions
                    {
                        tempI = Convert.ToInt32(tempS); // convert from int to string
                        if (!(tempI > 0)) // check if input is bellow 0;
                        {
                            Console.WriteLine("\n" + tempI + " is bellow 1\n");
                        }
                        else
                        {
                            break; // input is valid, reuturn
                        }
                    }
                    catch (Exception) // if the convert threw
                    {
                        Console.WriteLine("\n" + tempS + " is not an integer\n");
                    }
                }
                return tempI; // return the new value
            }
        }
    }
}
