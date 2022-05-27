using System;
using System.IO;

namespace problem
{

    class Program
    {

        static float circle(int x1, int y1, int x2, int y2, int r1, int r2)
        {
            float distance; 
            distance = (float)Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2))); 
            return distance; 
        }
        public static void Main()
        {

            int x1, x2, y1, y2, r1, r2;
            float distance;

            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            r1 = Convert.ToInt32(Console.ReadLine());

            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            r2 = Convert.ToInt32(Console.ReadLine());
            distance = circle(x1, y1, x2, y2, r1, r2);
            if (distance == (r1 + r2)) 
            {
                Console.WriteLine("YES");
            }
            else if (distance > (r1 + r2))
            {
                Console.WriteLine("NO");
            }
            else 
            {
                Console.WriteLine("YES");
            }
            return;
        }
    }
}