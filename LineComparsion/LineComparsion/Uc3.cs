using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparsion
{
    internal class Uc3
    {
        public static void UC3()
        {
            int x1, y1, x2, y2;
            int a1, b1, a2, b2;
            Console.WriteLine("Enter the the values of x1, y1, x2, y2");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            int length1 = (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Enter the the values of a1, b1, a2, b2");
            a1 = Convert.ToInt32(Console.ReadLine());
            b1 = Convert.ToInt32(Console.ReadLine());
            a2 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());
            int length2 = (int)Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));

            int result = length1.CompareTo(length2);

            if (result > 0)
            {
                Console.WriteLine("1st Line is greater than 2nd line");
            }
            else if (result == 0)
            {
                Console.WriteLine("1st Line is equal to 2nd line");
            }
            else
            {
                Console.WriteLine("1st Line is lesser than 2nd line");
            }

            Console.WriteLine("Length of Line is :" + length1);
            Console.WriteLine("Length of Line is :" + length2);
        }
    }
}
