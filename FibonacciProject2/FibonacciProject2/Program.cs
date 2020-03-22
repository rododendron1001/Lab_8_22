using System;

namespace FibonacciProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 0;
            int i2 = 1;
            int i;
            int nr = 0;
          
             // 3 incercari la dispozitie 
             
            while (nr < 3)

            {
                Console.WriteLine("Number of elements for the string Fibonacci : ");
                if (int.TryParse(Console.ReadLine(), out int n) && (n > 0))
                {
                    switch (n)
                    {
                        case 1:
                            {
                                Console.WriteLine("Elements of string Fibonacci are : " + i1);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Elements of string Fibonacci are : " + i1 + "," + i2);
                                break;
                            }
                        default:
                            Console.Write("Elements of string Fibonacci are : " + i1 + "," + i2);
                            for (int j = 3; j <= n; j++)
                            {
                                i = i1 + i2;
                                i1 = i2;
                                i2 = i;
                                Console.Write("," + i);
                            }
                            break;
                    }
                    nr = 4;
                }
                else
                {
                    Console.WriteLine(" Number of elements has to be an integer !");
                    nr++;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
