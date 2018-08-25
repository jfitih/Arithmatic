using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithemtic.cs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ArithmeticMethods.cs
    {
        public class ArithmeticMethods
        {
            //For one this makes nosense to me
            // I know expect alot but this is ridiculous
            /* Illustrates the addition, subtraction,
             * and negation operators
             * Using named arguments we can pass 
             * argumenrts by name so that we do not have to remember
             * their order in the method declaration.
             * Opitional arguments allow us to specify defalt values
             * for arguments. If we call and method and do not pass
             * a value for an opitional argument it will take the default value.
             * For example, in Example presented we could declare the Multiplicative
             * method as 
             * public static void Multiplicative(int x = 25, int y = 14)
             * so that x has the default value of 25 and y has
             * the default value of 14. We could then rewrite Main as
             * public static void Main()
             * {
             * Additive(y: 14, x: 25);
             * Multiplicative();
             * }
             * The Additive method hes arguments passed by name so that we may pass them
             * in a different order than they appear in the declaration.
             * The Multiplicative  method has opitional arugments so even though we do
             * not pass any arguments expilictily, x has the default value of 25 and y is 14.
             */
            public static void Additive(int x, int y)
            {
                int z = x + y;
                int w = x - y;
                int p = -y;
                Console.WriteLine("x + y = {0, 3} x - y = {1, 3} -y = {2, 3} ",
                    x + y, x - y, -y);
            }
            /*Illustrates the multiplication, division, 
             * and remainder operators
             */
            public static void Multiplicative(int x, int y)
            {
                int z = x * y;
                int w = x / 7;
                int p = x % 7;
                Console.WriteLine("x * y= {0, 3} x / 7 = {1, 3} x % 7 = {2, 3} ",
                    x * y, x / 7, x % 7);
            }
                                  
            //Call the methods, which oranizes the code.
            static void Main(string[] args)
            {

                int x = 25;
                int y = 14;
                Additive(x: 25, y: 14);
                Multiplicative(x, y);
                Console.ReadLine();

            }
        }
    }
}