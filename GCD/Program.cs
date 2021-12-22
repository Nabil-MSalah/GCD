using System;

namespace GCD
{
    internal class Program
    {
        //Finding GCD (Greatest Common Divisor) by Iteration(loop)
        public static int Gcd(int a, int b)
        {
            //intialize temp
            int temp=0;
            while (a != 0 && b != 0)
            {
                //Make a Temporery copy of a
                temp = a;
                a = b;//assign a to b to put the new greatest number in a again
                if (temp % b == 0)//to prevent b from modification in case its the divisor
                    break;
                b = temp % b;//new value to try as a divisor
            }
            return b;
        }
        // the recursive Method of gcd finding
        public static int gCDRe( int a,  int b)
        {
            //my base case that involves finding a=0 or b=0 after last reminder
            if (b == 0)
            {
                return a;//return the gcd
            }
            else
            {
                return gCDRe(b, a % b);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers Two Get Their GCD");
            int in1;
            int in2 ;
            bool isValid = false;//become true when you enter valid int
            bool isValid2 = false;//become true when you enter valid int
            //to confirm that the input is an integer
            do
            {
                Console.WriteLine("The first One: ");
                //return true in case the input is int and assign it to in1
                if (int.TryParse(Console.ReadLine(), out in1))
                    isValid = true;
                Console.WriteLine("The Second One: ");
                //return true in case the input is int and assign it to in2
                if (int.TryParse(Console.ReadLine(), out in2))
                    isValid2 = true;
            } while (!(isValid && isValid2));
            //runng my method and return ans to my console in iterative way
            Console.WriteLine("Their GCD (by iteration) Is: "+ Gcd(in2,in1));
            //runng my method and return ans to my console in recursve
            Console.WriteLine("Their GCD (by recursion) Is: "+ gCDRe(in1,in2));
        }
    }
}
