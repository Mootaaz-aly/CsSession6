using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsSession6
{
    internal class Program
    {

        class Person
        {
            public string name = "m";
        }

        static void Main(string[] args)
        {
            #region Q1&Q2

            /*Explain the difference between passing(Reference type parameters)
            by value and by reference then write a suitable c# example.*/

            /*void val(Person p) //Pass by value
            {
                p.name = "Mootaaz";  // This will affect original variable
                p = new Person();    // New object assigned but not affect
                p.name = "New Person";
            }
            
            static void reff(ref Person p) //Pass by refrence
            {
                p.name = "Moot";  // This will affect original variable
                p = new Person(); // This will affect original variable too
                p.name = "New";
            }*/
            #endregion

            #region Q3

            /*3 - Write a c# Function that accept 4 parameters from user and return result
            of summation and subtracting of two numbers*/

            /*int operation(int a, int b,bool sm, bool sub)
            {
                if (sm && !sub)
                {
                    return a + b ;
                }
                else if(sub && !sm) 
                {
                    return a - b;
                }
                else
                {
                    return -1;
                }
            }

            int n, nn;
            bool summ = false; bool subb = false;
            Console.Write("Enter the first Number: ");
            int.TryParse(Console.ReadLine(), out n);

            Console.Write("Enter the Second Number: ");
            int.TryParse(Console.ReadLine(), out nn);

            Console.WriteLine("Do you want to sum? [Y/N]");
            char c; char.TryParse(Console.ReadLine(), out c);

            if (c == 'y' || c == 'Y')
            {
                summ = true;
            }
            else
            {
                Console.WriteLine("Do you want to subtract? [Y/N]");
                char cc; char.TryParse(Console.ReadLine(), out cc);

                if (cc == 'y' || cc == 'Y')
                    subb = true;
            }

            int res = operation(n, nn, summ, subb);

            if(res == -1)
                Console.WriteLine("Invalid Inputs");
            else
                Console.WriteLine($"The resault of Operation is : {res}");*/
            // Trying to handle all cases (:


            #endregion

            #region q3

            //3 - Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int operation(int a, int b,bool sm, bool sub)
            //{
            //    if (sm)
            //    {
            //        return a + b ;
            //    }
            //    if(sub) 
            //    {
            //        return a - b;
            //    }
            //    return -1;

            //}

            #endregion

            #region q3

            //3 - Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int operation(int a, int b,bool sm, bool sub)
            //{
            //    if (sm)
            //    {
            //        return a + b ;
            //    }
            //    if(sub) 
            //    {
            //        return a - b;
            //    }
            //    return -1;

            //}

            #endregion

            #region Q4

            /*Write a program in C# Sharp to create a function to calculate
            the sum of the individual digits of a given number.*/

            /*int SumDig(int n)
            {
                int sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                return sum;
            }

            Console.Write("Enter the Number to sum digits: ");
            int n; int.TryParse(Console.ReadLine(), out n);
            Console.Clear();
            Console.WriteLine($"Sum of Digits is {SumDig(n)}");*/

            #endregion

            #region Q5

            /*Create a function named "IsPrime", which receives an integer number
            and retuns true if it is prime, or false if it is not.*/

            /*bool isPrime (int n)
            {
                if (n < 2)
                    return false;

                for (int i = 2; i <= n / 2; ++i)
                {
                    if(n % i == 0)
                        return false;
                }
                return true;
            }

            Console.Write("Enter a Number: ");
            int num; int.TryParse(Console.ReadLine(), out num);
            Console.Clear();
            Console.WriteLine($"The Number is: {(isPrime(num) ? "Prime" : "Not Prime")}");*/

            #endregion

            #region Q6

            /*Create a function named MinMaxArray, to return the minimum and maximum
            values stored in an array, using reference parameters.*/

            /*int mi = 0; int ma = 0;
            void MinMaxArray (int[] arr, ref int min, ref int max)
            {
                min = arr[0]; max = arr[0];

                for (int i = 1; i < arr.Length; ++i)
                {
                    if (arr[i] < min)
                        min = arr[i];
                    if (arr[i] > max)
                        max = arr[i];
                }
            }

            Console.Write("Enter the Size of Array: ");
            int s; int.TryParse(Console.ReadLine(), out s);

            Console.Write("Enter the array elements: ");
            int[] arr = new int[s];
            for(int i = 0; i < s; ++i)
            {
                int.TryParse(Console.ReadLine(), out arr[i]);
            }

            MinMaxArray(arr, ref mi, ref ma);

            Console.Clear();
            Console.WriteLine($"The max number is: {mi}");
            Console.WriteLine($"The min number is: {ma}");*/

            #endregion

            #region Q7

            /*long facto (int n)
            {
                int temp = 1;
                for(int i =2; i<=n; ++i)
                {
                    temp *= i;
                }
                return temp;
            }

            Console.Write("Enter a number: ");
            int n; int.TryParse(Console.ReadLine(), out n);

            long f = facto(n);
            Console.Clear();
            Console.WriteLine($"The factorial of {n} is {f}");*/

            #endregion

            #region Q8

            /*Create a function named "ChangeChar" to modify a letter in a certain position(0 based)
            of a string, replacing it with a different letter*/

            /*string ChangeChar(string s, int i, char c)
            {
                if (i < 0 || i >= s.Length)
                {
                    return "Index out of range";
                }

                //Convertt the string to array
                char[] arr = s.ToCharArray();
                arr[i] = c;

                return new string(arr);
            }

            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            Console.Write("Enter index to change (0-based): ");
            int i; int.TryParse(Console.ReadLine(), out i);

            Console.Write("Enter new character: ");
            char c; char.TryParse(Console.ReadLine(), out c);

            string ss = ChangeChar(s, i, c);
            Console.WriteLine("Modified string: " + ss);*/

            #endregion
        }
    }
}
