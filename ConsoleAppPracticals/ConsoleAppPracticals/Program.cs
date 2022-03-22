using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPracticals
{
    internal class Program
    {
        static int Average(string str)
        {
            string[] justNums = str.Split(',');
            int[] nums = ArrayStringToInt(justNums);
            //int sum = nums.Sum();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];   // getting the sum: sum = sum + i
            }
            int average = sum / nums.Length;
            return average;
        }

        static int[] ArrayStringToInt(string [] nums)
        {
            int [] array = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                array[i] = Convert.ToInt32(nums[i]);
            }

            return array;
        }

        static int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else if(num < 0)
            {
                //Console.WriteLine("can't find of the given value");
                return -1;
            }
            else
            {
                int fac = 1;
                for (int i = 1; i <= num; i++)
                {
                    fac *= i;   // getting the factorial: fac = fac * i
                }
                return fac;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers whose average you wanna get (all the numbers must be seperated by a ','): ");
            string str = Console.ReadLine();
            Console.WriteLine($"The average is {Average(str)}");

            Console.Write("Enter the number whose factorial you wanna get: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = Factorial(num);
            if (factorial == -1)
            {
                Console.WriteLine("Can't find the factorial of the given number");
            }  
            else
            {
                Console.WriteLine($"The factorial of {num} is {Convert.ToString(Factorial(num))}");
            }

            Console.ReadLine();
        }
    }
}
