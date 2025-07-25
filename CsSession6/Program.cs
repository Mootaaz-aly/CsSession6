using System.Buffers.Text;
using System.ComponentModel;
using System.IO.Pipelines;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsSession6
{
    internal class Program
    {

        static void Main(string[] args)
        {

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

            /*Create a function named "ChangeChar" to modify a letter
            in a certain position(0 based) of a string, replacing it with a different letter*/

            

            #endregion
        }
    }
}
