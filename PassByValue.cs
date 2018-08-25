using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValue.cs
{
    class PassByValue
    {
        //Returns the cube of its argument
        public static int Cube(int aNumber) {
            int result = aNumber * aNumber * aNumber;
            aNumber += 5;
            return result;
        }
        /*Show that the value in the caller
         * does not change'
         */
        static void Main(string[] args)
        {
            int x = 12;  // this is the original code for this
            int value = Cube(x);
            Console.WriteLine("The cube of {0} is {1}", x, value);
            int y = 3;  // this was added to see what was going on
            int value1 = Cube(y); // Must change the value to value1 or it will read value
            Console.WriteLine("The cube of {0} is {1}", y, value1);
            int a = 9;  //Must change variable to (?) or it will read the old one
            int value2 = Cube(a);
            Console.WriteLine("The cube of {0} is {1}", a, value2);
            int b = 6;
            int value3 = Cube(b);
            Console.WriteLine("The cube of {0} is {1}", b, value3);
            int c = 2;
            int value4 = Cube(c);
            Console.WriteLine("The cube of {0} is {1}", c, value4);
            Console.ReadLine(); // Must add to keep on or screen blinks out.
        }     //So if you do aNumber * aNumber it would square it.
    }
}
