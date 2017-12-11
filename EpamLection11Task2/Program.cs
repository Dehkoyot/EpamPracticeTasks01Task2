using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamLection11Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(new Point(0, 0), new Point(0, 4), new Point(4, 4), new Point(4, 0));
            Rectangle rect2 = new Rectangle(new Point(1, 0), new Point(1, 3), new Point(2, 3), new Point(2, 0));

            Console.WriteLine("Paralel : {0}", rect1.ifParallel());
            Console.WriteLine("Paralel : {0}", rect2.ifParallel());

            Console.WriteLine("The smallest rectangle is  {0}", Rectangle.ShowRectangle(rect1.SmallestRectangle(rect2)));

            Console.WriteLine("Moved rectangle  {0}", Rectangle.ShowRectangle(rect1.Move(7, 8)));

            Console.WriteLine("Changed size  {0}", Rectangle.ShowRectangle(rect1 * 3));
                              
            Console.ReadKey();
        }
    }
}
