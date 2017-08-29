using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleIntersection
{
    public class Rectangle
    {
        /*Create a class Rectangle. It should consist of an ID, width, height and the coordinates of its top left corner (horizontal and vertical). Create a method which receives as a parameter another Rectangle, checks if the two rectangles intersect and returns true or false. */

        private string id;
        private double width;
        private double height;
        private double x;
        private double y;

        public Rectangle(string id, double width, double height, double topLeftHoriz, double topRightHoriz)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.x = topLeftHoriz;
            this.y = topRightHoriz;
        }
        public string Id { get; }
        public double Width { get; }
        public double Height { get; }


        public double X { get; }
        public double Y { get; }

        public object InteresectWith(Rectangle rectangle)
        {
            if (this.x <= rectangle.x + rectangle.width && this.x + this.width >= rectangle.x && this.y <= rectangle.height && this.y + this.height >= rectangle.y)
            {
                return true;
            }
            return false;
        }
    }
}
