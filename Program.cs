using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentSaturday13
{
    public class FactorialCalculator
    {
        public static int CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Task 1");
                Console.WriteLine("Hello, World!");//task1
                Console.WriteLine("Task 2");
                Console.WriteLine("enter input for greeting");
                string me = Console.ReadLine();
                Console.WriteLine($"Hello,{me}");
                Console.WriteLine("Task 3");
                Console.WriteLine("enter input 1");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter input 2");
                int n2 = int.Parse(Console.ReadLine());
                int add = n1 + n2;
                int sub = n1 - n2;
                int mult = n1 * n2;
                Console.WriteLine($"Addition:{add}");
                Console.WriteLine($"Subtraction:{sub}");
                Console.WriteLine($"Multiplication:{mult}");
                Console.WriteLine("Task 4");
                Console.WriteLine("enter number tocheck even or odd");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("number is even");
                }
                else
                {
                    Console.WriteLine("number is odd");
                }
                Console.WriteLine("task 5");
                int i = 0;
                while (i <= 10)
                {
                    Console.WriteLine(i);
                    i++;

                }
                Console.WriteLine("task 6");
                Console.WriteLine("enter array length");


                int len = int.Parse(Console.ReadLine());
                int[] arr = new int[len];

                for (int j = 0; j < len; j++)
                {
                    Console.WriteLine($"enter value {j}");
                    arr[j] = int.Parse(Console.ReadLine());
                }

                double sum = arr.Sum();
                double avg=sum/len;

                Console.WriteLine("Sum of the array elements: " + sum);
                Console.WriteLine("Average of the array elements: " + avg);






                Console.WriteLine("task7");

                try
                {
                    Console.Write("Enter a positive integer: ");
                    int nump = int.Parse(Console.ReadLine());

                    if (nump < 0)
                    {
                        Console.WriteLine("Please enter a positive integer.");
                    }
                    else
                    {
                        int factorial = CalculateFactorial(nump);
                        Console.WriteLine($"The factorial of {nump} is: {factorial}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive integer.");
                }
                Console.WriteLine("task8");





                int age=0;
                bool isValidInput = false;

                while (!isValidInput)
                {
                    Console.Write("Please enter your age: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out age))
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer for age.");
                    }
                }

                if (age < 18)
                {
                    Console.WriteLine("You are a minor.");
                }
                else if (age >= 18 && age < 65)
                {
                    Console.WriteLine("You are an adult.");
                }
                else
                {
                    Console.WriteLine("You are a senior.");
                }

                Console.ReadKey();
            }
        }
    }
}
