using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_6
{
    class Program
    {
        static void Students()
        {
            Console.WriteLine("TARGIL 1");
            Console.WriteLine("please enter number of students");
            int students = Convert.ToInt32(Console.ReadLine());
            double[] stud = new double[students];
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < stud.Length; i++)
            {
                Console.WriteLine("please enter a grade");
                stud[i] = Convert.ToDouble(Console.ReadLine());
                sum = sum + stud[i];
            }
            Console.WriteLine("the sum of grades is: " + sum);
            avg = sum / students;
            Console.WriteLine("the avg of grades is: " + avg);
        }
        static void Matrix_5x5()
        {
            Console.WriteLine("TARGIL 2");
            int[,] matrix = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 11);
                }
            }
            Console.WriteLine("please enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int z = 0; z < matrix.GetLength(1); z++)
                {
                    if (x == matrix[y, z])
                    {
                        Console.WriteLine("the line is: " + y);
                        Console.WriteLine("the row is: " + z);
                    }
                }
            }
        }
        static void Matrix_3x3()
        {
            Console.WriteLine("TARGIL 3");
            int[,] matrix = new int[3, 3];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 2);
                }
            }
            int Try = 0;
            while (true)
            {
                Console.WriteLine("please enter a line number");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter a row number");
                int y = Convert.ToInt32(Console.ReadLine());
                if (matrix[x, y] == 1)
                {
                    Console.WriteLine("boom!");
                    matrix[x, y] = 0;
                    Try++;
                }
                else if (matrix[x, y] == 0)
                {
                    Console.WriteLine("miss!");
                    Try++;
                }
                int sum = 0;
                for (int a = 0; a < matrix.GetLength(0); a++)
                {
                    for (int b = 0; b < matrix.GetLength(1); b++)
                    {
                        if (matrix[a, b] == 1)
                        {
                            sum++;
                        }
                    }
                }
                if (sum == 0)
                {
                    break;
                }
            }
            Console.WriteLine("number of trying: " + Try);
        }
        static void Main(string[] args)
        {
            Students();
            Matrix_5x5();
            Matrix_3x3();
        }
    }
}
