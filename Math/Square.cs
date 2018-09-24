using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProject
{
    class Square
    {
        private int input1;
        private int input2;
        private string[] intInputsArray;
        private double result = 0;

        private ConsoleKeyInfo cki;

        public Square()
        {
            do
            {
                DisplayMenu();
                
                cki = Console.ReadKey(true);

                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        SquareArea();
                        break;
                    case "2":
                        SquareCircumference();
                        break;
                    case "3":
                        RectangleArea();
                        break;
                    case "4":
                        RectangleCircumference();
                        break;
                    case "5":
                        Pythagoras();
                        break;
                    default:
                        Console.WriteLine("FUCK DIG!");
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Indtast ønskede nummer eller tryk (Esc) for at afslutte:");

            ArrayList collection = new ArrayList();
            collection.Add("Square area");
            collection.Add("Square circumferences");
            collection.Add("Rectangle area");
            collection.Add("Rectangle circumference");
            collection.Add("Pythagoras");

            int i = 0;
            foreach (object VARIABLE in collection)
            {
                i++;
                Console.Write(i + ") ");
                Console.WriteLine(VARIABLE);
            }
        }

        public void SquareArea()
        {
            Console.WriteLine();
            Console.WriteLine("Skriv længden:");
            Console.Write("> ");
            double a = Convert.ToDouble(Console.ReadLine());
            double c = a * a;
            Console.Clear();

            Console.WriteLine("Result = " + c);
            Console.WriteLine();
        }

        public void SquareCircumference()
        {
            Console.WriteLine();
            Console.WriteLine("Skriv længden:");
            Console.Write("> ");
            double a = Convert.ToDouble(Console.ReadLine());
            double c = a * 4;
            Console.Clear();

            Console.WriteLine("Result = " + c);
            Console.WriteLine();
        }

        public void RectangleCircumference()
        {
            Console.WriteLine();
            Console.WriteLine("Skriv længden og bredden (LxB):");
            Console.Write("> ");

            string[] intInputs = Console.ReadLine().Split();
            int inputa = Convert.ToInt32(intInputs[0]);
            int inputb = Convert.ToInt32(intInputs[1]);

            double c = 2 * (inputa + inputb);
            Console.Clear();

            Console.WriteLine("Result = " + c);
            Console.WriteLine();
        }

        public void RectangleArea()
        {
            Console.WriteLine();
            Console.WriteLine("Skriv længden og bredden (LxB):");
            Console.Write("> ");

            string[] intInputs = Console.ReadLine().Split();
            int inputa = Convert.ToInt32(intInputs[0]);
            int inputb = Convert.ToInt32(intInputs[1]);

            double c = inputa * inputb;
            Console.Clear();

            Console.WriteLine("Result = " + c);
            Console.WriteLine();
        }

        public void Pythagoras()
        {
            Console.WriteLine();
            Console.WriteLine("    |\\");
            Console.WriteLine("    | \\");
            Console.WriteLine(" \"b\"|  \\ \"c\"");
            Console.WriteLine("    |   \\");
            Console.WriteLine("    |____\\");
            Console.WriteLine("      \"a\"");

            Console.WriteLine("Vil du finde a, b eller c?");

            cki = Console.ReadKey(true);

            switch (cki.KeyChar.ToString())
            {
                case "a":
                    Console.WriteLine("Skriv (c b):");
                    ReadTwoInputs();

                    result = Math.Sqrt(input1 * input1 - input2 * input2);
                    Console.Clear();

                    Console.WriteLine("√(" + input1 + "^2" + "-" + input2 + "^2)");
                    break;
                case "b":
                    Console.WriteLine("Skriv (c a):");
                    ReadTwoInputs();

                    result = Math.Sqrt(input1 * input1 - input2 * input2);
                    Console.Clear();

                    Console.WriteLine("√(" + input1 + "^2" + "-" + input2 + "^2)");
                    break;
                case "c":
                    Console.WriteLine("Skriv (a b):");
                    ReadTwoInputs();

                    result = Math.Sqrt(input1 * input1 + input2 * input2);
                    Console.Clear();

                    Console.WriteLine("√(" + input1 + "^2" + "+" + input2 + "^2)");
                    break;
                default:
                    Console.WriteLine("Go fuck yourself!!!");
                    break;
            }


            if (result != 0) Console.WriteLine("Result = " + result);
            else Console.WriteLine("Du skulle vælge mellem a, b eller c - Prøv igen!");
            
            Console.WriteLine();
        }

        public void ReadTwoInputs()
        {
            Console.Write("> ");

            intInputsArray = Console.ReadLine().Split();
            input1 = Convert.ToInt32(intInputsArray[0]);
            input2 = Convert.ToInt32(intInputsArray[1]);
        }
    }
}
