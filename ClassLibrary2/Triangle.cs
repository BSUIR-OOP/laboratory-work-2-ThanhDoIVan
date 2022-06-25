using System.Drawing;

namespace ClassLibrary2
{
    public class Triangle:Shape
    {
       public Point _frstPoint;
       public Point _scndPoint;
       public Point _thrdPoint;

        public Triangle()
        {

            _frstPoint.X = 10;
            _frstPoint.Y = 10;
            _scndPoint.X = 37;
            _scndPoint.Y = 30;
            _thrdPoint.X = 15;
            _thrdPoint.Y = 50;
        }

        public override void Draw(IDrawable drawable)
        {
            drawable.Draw(this);
        }
        
        public override string ToString()
        {
            return "Triangle";
        }


    }
}
