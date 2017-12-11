using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamLection11Task2
{
    public class Rectangle
    {
        Point[] point = new Point[4];

        public Rectangle(){}

        public Rectangle(Point p1, Point p2, Point p3, Point p4)
        {
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;
        }

        public bool ifParallel()
        {
            if (point[0] == point[1] || point[0] == point[2] || point[0] == point[3] || point[1] == point[2] || point[1] == point[3] || point[2] == point[3])
                return false;

            if ((((point[0].x == point[2].x && point[1].y == point[3].y) && (point[2].x == point[3].x && point[0].y == point[3].y))) || ((point[0].x == point[1].x && point[1].y == point[2].y) && (point[2].x == point[3].x && point[0].y == point[3].y)))
                return true;

            return false;
        }

        public static string ShowRectangle(Rectangle rect1)
        {
            return $"p1({rect1.point[0].x};{rect1.point[0].y}) p2({rect1.point[1].x};{rect1.point[1].y}) p3({rect1.point[2].x};{rect1.point[2].y}) p4({rect1.point[3].x};{rect1.point[3].y})";
        }


        public Rectangle Move(int x, int y)
        {
            return new Rectangle(new Point(point[0].x + x, point[0].y + y), new Point(point[1].x + x, point[1].y + y), new Point(point[2].x + x, point[2].y + y), new Point(point[3].x + x, point[3].y + y));
        }

        public static Rectangle operator *(Rectangle rect, int k)
        {
            return new Rectangle(new Point(rect.point[0].x * k, rect.point[0].y * k), new Point(rect.point[1].x * k, rect.point[1].y * k), new Point(rect.point[2].x * k, rect.point[2].y * k), new Point(rect.point[3].x * k, rect.point[3].y * k));
        }


        public Rectangle SmallestRectangle(Rectangle rect1)
        {

            return new Rectangle(new Point(xMax(this,rect1), yMax(this,rect1)), new Point(xMax(this, rect1), yMin(this, rect1)), new Point(xMin(this, rect1), yMax(this, rect1)), new Point(xMin(this, rect1), yMin(this, rect1)));
        }

        private static int yMax(Rectangle rect1, Rectangle rect2)
        {
            var yMax = rect1.point.Max(y => y.y) > rect2.point.Max(y => y.x) ? rect1.point.Max(y => y.y) : rect2.point.Max(y => y.y);
            return yMax;
        }


        private static int yMin(Rectangle rect1, Rectangle rect2)
        {
            var yMin = rect1.point.Min(y => y.y) < rect2.point.Min(y => y.x) ? rect1.point.Min(y => y.x) : rect2.point.Min(y => y.x);
            return yMin;
        }

        private static int xMax(Rectangle rect1, Rectangle rect2)
        {
            var xMax = rect1.point.Max(x => x.x) > rect2.point.Max(x => x.x) ? rect1.point.Max(x => x.x) : rect2.point.Max(x => x.x);
            return xMax;
        }

        private static int xMin(Rectangle rect1,Rectangle rect2)
        {
            var xMin = rect1.point.Min(x => x.x) < rect2.point.Min(x => x.x) ? rect1.point.Min(x => x.x) : rect2.point.Min(x => x.x);
            return xMin;
        }


    }
}
