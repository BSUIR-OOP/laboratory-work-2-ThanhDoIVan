using System.Drawing;

namespace ClassLibrary2
{
    public class Trapezium:Shape
    {
        public Point _point1;
        public Point _point2;
        
        public Trapezium()
        {
            _point1.X = 10;
            _point1.Y = 50;
            _point2.X = 40;
            _point2.Y = 50;
        }

        public override void Draw(IDrawable drawable)
        {
            drawable.Draw(this);
        }
        public override string ToString()
        {
            return "Trapezium";
        }

    }
}
