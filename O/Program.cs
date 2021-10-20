using System;
using System.Drawing;

namespace O
{
    public class Circle
    {
        public double Radius { get; set; }
    }
    public class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
    }

    public class AreaCalculator
    {
        public double TotalArea(object[] arrObjects)
        {
            double area = 0;
            foreach (var obj in arrObjects)
            {
                if (obj is Rectangle objRectangle)
                {
                    area += objRectangle.Height * objRectangle.Width;
                }
                else
                {
                    var objCircle = (Circle)obj;
                    area += objCircle.Radius * objCircle.Radius * Math.PI;
                }
            }
            return area;
        }
    }
}
