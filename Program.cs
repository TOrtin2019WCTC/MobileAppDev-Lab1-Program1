using System;

namespace MobileApp_Lab1_Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 3-9");
            int ans = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n\n");


            string position;

            for (int i = 1; i <= ans; i++)
            {
                for (int j = 1; j <= ans; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }
            do
            {

                Console.WriteLine("\n");
                Console.WriteLine("1. horizontal");
                Console.WriteLine("2. vertical");
                Console.WriteLine("3. Diagonal left");
                Console.WriteLine("4. Diagonal right");
                Console.WriteLine("5. exit");
                position = Console.ReadLine();
                Console.WriteLine("\n");


                switch (position)
                {

                    case "1":
                        for (int i = ans; i >= 1; i--)
                        {
                            for (int j = 1; j <= ans; j++)
                            {
                                Console.Write(i * j + "\t");
                            }
                            Console.WriteLine();
                        }


                        break;


                    case "2":

                        for (int i = 1; i <= ans; i++)
                        {
                            for (int j = ans; j >= 1; j--)
                            {
                                Console.Write(i * j + "\t");
                            }
                            Console.WriteLine();
                        }

                        break;

                    case "3":
                        for (int i = ans; i >= 1; i--)
                        {
                            for (int j = ans; j >= 1; j--)
                            {
                                Console.Write(i * j + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "4":
                        for (int i = 1; i <= ans; i++)
                        {
                            for (int j = 1; j <= ans; j++)
                            {
                                Console.Write(i * j + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "5":
                        break;
                }





            } while (!position.Equals("5"));
        }
    }
}

