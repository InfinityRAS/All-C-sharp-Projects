using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicals
{
    internal class Program
    {
        static void GetAllItems (int [] arr)
        {
            /*
             * arr[0]    --> arr[i]
             * arr[1]
             * arr[2]
             * ...
            */

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static int Average(int [] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];   
            }

            int average = sum / nums.Length;

            return average;
        }

        static int [] StringArrToInt (string [] strNum)
        {
            int[] arr = new int[strNum.Length];
            for (int i = 0; i < strNum.Length; i++)
            {
                arr[i] = Convert.ToInt32(strNum[i]);
            }

            return arr;
        }

        static int FactorialUsingIterative (int num)  // using iterations (iterative method)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;     // factorial = factorial * i;
            }

            return factorial;
        }

        static int FactorialUsingRecursive (int num)
        {
            /* 
             * 5! = 5 * 4 * 3 * 2 * 1
             * 5! = 5 * (4 * 3 * 2 * 1)
             * 5! = 5 * 4!
             * n! = n * (n-1)!
            */

            //return num * FactorialUsingRecursive(num - 1);  // 5 * 4 * 3 * 2 * 1
            int factorial = 1;

            if (num < 1)
            {
                return factorial;
            }
            else
            {
                factorial = num * FactorialUsingRecursive(num - 1);
                return factorial;
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to AAO");
            //int[] nums = { 1, 2, 3 };

            //Console.WriteLine(nums[0]);
            //GetAllItems(nums);
            //Console.WriteLine(Average(nums));

            //Console.WriteLine("Enter the numbers whose average you wanna get (seperate numbers using a ','): ");
            //string strNumsWithComma = Console.ReadLine();    // "1,2,3"

            //string [] strNums = strNumsWithComma.Split(',');
            //int [] nums = StringArrToInt(strNums);
            //Console.WriteLine($"The average is {Average(nums)}");

            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The factorial of the given number is {FactorialUsingRecursive(num)}");

            Human aryan = new Human("Aryan Sisodiya", "Male", 14);
            Console.WriteLine(aryan.gender);
            Console.WriteLine(aryan.age);
            Console.WriteLine(aryan.name);

            Console.ReadLine();
        }
    }
}
