
using System;

namespace ConsoleProgram
{
    class Program
    {

        static void Add()
        {
            int? num1 = null;
            int? num2 = null;

            while (num1 == null)
            {
                Console.Write("Enter first num: ");
                string input1 = Console.ReadLine();

                if (int.TryParse(input1, out int parsedNum1))
                {
                    num1 = parsedNum1;
                }
                else
                {
                    Console.WriteLine("Yanlis reqem daxil edildi");
                }
            }

            while (num2 == null)
            {
                Console.Write("Enter second num: ");
                string input2 = Console.ReadLine();

                if (int.TryParse(input2, out int parsedNum2))
                {
                    num2 = parsedNum2;
                }
                else
                {
                    Console.WriteLine("Yanlis reqem daxil edildi");
                }
            }
            int? total = num1 + num2;
            Console.WriteLine(num1+" + "+num2+"="+total);
            Console.ReadKey();


        }
        static void Mult()
        {
            int? num1 = null;
            int? num2 = null;

            while (num1 == null)
            {
                Console.Write("Enter first num: ");
                string input1 = Console.ReadLine();

                if (int.TryParse(input1, out int parsedNum1))
                {
                    num1 = parsedNum1;
                }
                else
                {
                    Console.WriteLine("Yanlis reqem daxil edildi");
                }
            }

            while (num2 == null)
            {
                Console.Write("Enter second num: ");
                string input2 = Console.ReadLine();

                if (int.TryParse(input2, out int parsedNum2))
                {
                    num2 = parsedNum2;
                }
                else
                {
                    Console.WriteLine("Yanlis reqem daxil edildi");
                }
            }
            int? total = num1 * num2;
            Console.WriteLine(num1 + " * " + num2 + "=" + total);
            Console.ReadKey();


        }
        static void Div()
        {
            double? num1 = null;
            double? num2 = null;

            while (num1 == null)
            {
                Console.Write("Enter first num: ");
                string input1 = Console.ReadLine();

                if (double.TryParse(input1, out double parsedNum1))
                {
                    num1 = parsedNum1;
                }
                else
                {
                    Console.WriteLine("Yanlis reqem daxil edildi");
                }
            }

            while (num2 == null)
            {
                Console.Write("Enter second num: ");
                string input2 = Console.ReadLine();

                if (double.TryParse(input2, out double parsedNum2))
                {
                    num2 = parsedNum2;
                }
                else
                {
                    Console.WriteLine("Yanlis reqem daxil edildi");
                }
            }
            double? total = num1 / num2;
            Console.WriteLine(num1 + " / " + num2 + "=" + total);
            Console.ReadKey();


        }
        static void Subt()
        {
            int? num1 = null;
            int? num2 = null;

            while (num1 == null)
            {
                Console.Write("Enter first num: ");
                string input1 = Console.ReadLine();

                if (int.TryParse(input1, out int parsedNum1))
                {
                    num1 = parsedNum1;
                }
                else
                {
                    Console.WriteLine("Yanlis reqem daxil edildi");
                }
            }

            while (num2 == null)
            {
                Console.Write("Enter second num: ");
                string input2 = Console.ReadLine();

                if (int.TryParse(input2, out int parsedNum2))
                {
                    num2 = parsedNum2;
                }
                else
                {
                    Console.WriteLine("Yanlis reqem daxil edildi");
                }
            }
            int? total = num1 - num2;
            Console.WriteLine(num1 + " - " + num2 + "=" + total);
            Console.ReadKey();


        }

        static void Main(string[] args)
        {
            string[] menu = { "Add", "Mult", "Div", "Subt" };
            int index = 0;
            while (true)
            {
                Console.Clear();
                Console.Write("\n\n\n\n\n\n\n\n\n");
                for (int i = 0; i < menu.Length; i++)
                {
                    if (i == index)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\t\t\t" + menu[i] + "\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("\t\t\t\t\t\t\t" + menu[i] + "\n");
                    }

                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (index != 0)
                    {
                        index--;
                    }
                    else
                    {
                        index = menu.Length;
                    }
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (index != menu.Length)
                    {
                        index++;
                    }
                    else
                    {
                        index = 0;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }


                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    switch (index)
                    {
                        case 0:
                            {
                                Add();
                        break;      
                            }
                        case 1:
                            {
                                Mult();
                                break;
                            }
                        case 2:
                            {
                                Div();
                                break;
                            }
                        case 3:
                            {
                                Subt();
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }



            }



        }
    }
}