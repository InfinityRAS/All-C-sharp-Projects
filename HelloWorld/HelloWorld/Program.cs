using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Greet(string firstName, string surName = "Sisodiya") // default parameters
        {
            Console.WriteLine($"Good morning, {firstName} {surName}");
        }

        static float Average(int a, int b, int c)
        {
            float sum = a + b + c;
            return sum / 3;
        }

        static float Average(int a, int b)
        {
            float sum = a + b;
            return sum / 2;
        }

        static void Main(string[] args)
        {
            //int aryan = 34; // integer variable

            /*
                Data types in C#
                integer - int harry;    --> 4 byte
                floating point number - float that; --> 4 byte
                character - char a = 'a';       --> 2 byte
                boolean - bool isGreat = true;  --> 1 bit
                string - string inp = "harry";  --> 2 bytes per character
                long - big intergers - long aryan; --> 8 bytes
                double - big floats - double aryan; --> 8 bytes
             */

            //Console.WriteLine("Hello world!");
            //Console.Write("Hello Harry");
            //Console.WriteLine("I love C# and the number" + aryan);

            //string inp = Console.ReadLine();
            //Console.WriteLine(inp);

            // data types examples
            //int a = 23;
            //float b = 34.4F;    // not 34.4 unless it will mark it as a double
            //double c = 34.4D;
            //bool isGreat = true;
            //char d = 'a';   // must be in single quotes
            //string e = "this is a string";

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(isGreat);
            //Console.WriteLine(a + b);

            //typecasting
            //int a = (int) 3.4;  // double into integer

            //there are two types of typecasting
            //1. implicit casting
            // bonus: char to int to long to float to double
            //int x = 3;
            //double y = x;
            //Console.WriteLine(y);
            //Console.WriteLine(x);

            //2. explicit casting
            //int z = (int)3.5;
            //Console.WriteLine(z);

            //3. using some methods
            //float varr = Convert.ToInt32(3.55);
            //string sx = Convert.ToString(varr); 

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hey Hello " + name);

            //Console.Write("how many candies do you want?: ");
            //string can = Console.ReadLine();
            //Console.WriteLine("you will get 4 more candies. hence the number of candies you are gonna get are: " + (Convert.ToInt32(can) + 4));

            /* operators in C#
                Arithmetic operators    +,-,*,/
                assignment operators    =, +=, *=, /=, -=
                logical operators       &&, !, ||
                comparison operators    >,<,<=,>=, !=, ==
            */

            //int a = 4;
            //int b = 5;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a / b);

            //assigment operators
            //int a = 1;
            //int b = 2;
            //b += 4; // b = b + 4
            //Console.WriteLine(b);
            //b *= 4; // b = b * 4
            //Console.WriteLine(b);
            //b /= 4; // b = b / 4
            //Console.WriteLine(b);
            //b -= 4; // b = b - 4
            //Console.WriteLine(b);
            //Console.WriteLine(a);

            //logical operators
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);
            //Console.WriteLine(false && true);

            //Console.WriteLine(true||false);
            //Console.WriteLine(true||true);
            //Console.WriteLine(false||false);
            //Console.WriteLine(false||true); 

            //Console.WriteLine(!false);
            //Console.WriteLine(!true);

            //comparasion operators
            //Console.WriteLine(324 > 25);
            //Console.WriteLine(324 < 25);
            //Console.WriteLine(324 <= 25);
            //Console.WriteLine(324 >= 25);
            //Console.WriteLine(324 != 25);
            //Console.WriteLine(324 == 25);

            //Math class
            //int a = Math.Max(34, 454);
            //Console.WriteLine(a);

            //int b = Math.Min(34, 454);
            //Console.WriteLine(b);

            //double c = Math.Sqrt(9);
            //Console.WriteLine(c);

            //double d = Math.Abs(9);     // modulus
            //Console.WriteLine(d);

            // stings
            //string hello = "hello world this is aryan";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello + "You are nice");
            //Console.WriteLine(string.Concat(hello, "You're nice"));

            // string interpolation  - $"{variable_here}"
            //string name = "Aryan";
            //string candies = "5";
            //Console.WriteLine($"My name is {name} and i'm gonna eat {candies} candies");

            //string hello = "hello world this is aryan";
            // Console.WriteLine(hello[0]);
            //Console.WriteLine(hello.IndexOf("hello"));
            //Console.WriteLine(hello.Substring(5));  // takes out new string from given index
            //Console.WriteLine(hello);

            //Console.Write("Enter your age: ");
            //string stringAge = Console.ReadLine();
            //int age = Convert.ToInt32(stringAge);
            //bool isBanned = false;

            //if (isBanned)
            //{
            //    Console.WriteLine("You can't drive, you are a banned user!");
            //}
            //else if (age < 2)
            //{
            //    Console.WriteLine("You can't drive, you are just born!");
            //}
            //else if (age < 10)
            //{
            //    Console.WriteLine("please finish your high school first!");
            //}
            //else if (age >= 75)
            //{
            //    Console.WriteLine("You can't drive, you're too old to drive!");
            //}
            //else if (age >= 100 && age < 500)
            //{
            //    Console.WriteLine("You're a special kinda person!!");
            //}
            //else if (age >= 500)
            //{
            //    Console.WriteLine("You're not a human!");
            //}
            //else if (age > 18)
            //{
            //    Console.WriteLine("You can drive!");
            //}
            //else
            //{
            //    Console.WriteLine("You can't drive!");
            //}

            //int age = 79;
            //switch (age)
            //{
            //    case 18:
            //        Console.WriteLine("Please wait for a year!");
            //        break;

            //    case 20:
            //        Console.WriteLine("you're 20");
            //        break;

            //    default:
            //        Console.WriteLine("enjoy driving!");
            //        break;
            //}

            //loops in c#

            //while loops

            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //do while loop
            //int i = 0;

            //do {
            //    Console.WriteLine(i);
            //    i++;
            //} while (i > 5);

            //for loop
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //break and continue
            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 2)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //    //break;
            //}

            //break: it will exit the loop
            //continue: it will skip that particular iteration 

            //Greet("Aryan", "Sisodiya");
            //float avr = Average(1, 2, 3);
            //Console.WriteLine(avr);

            //float avr2 = Average(1, 3); // method overloading - means that it understood that we wanna execute the program with 2 parameters not the 3 one
            //Console.WriteLine(avr2);

            //OOPS - classes and objects
            //DRY - DO NOT REPEAT YOURSELF

            Player tommy = new Player();
            Console.WriteLine(tommy.getHealth());
            tommy.ChangeHealth(45);
            Console.WriteLine(tommy.getHealth());

            Console.ReadLine();
        }
    }
}
