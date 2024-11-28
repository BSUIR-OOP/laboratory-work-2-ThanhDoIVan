using System.Drawing;

namespace ClassLibrary2
{
    public class Polygon:Shape
    {
        public readonly Point[] _curvePoints;
        private readonly Point _point1;
        private readonly Point _point2;
        private readonly Point _point3;
        private readonly Point _point4;
        private readonly Point _point5;

        public Polygon()
        {
            _point1.X = 30;
            _point1.Y = 18;

            _point2.X = 45;
            _point2.Y = 30;

            _point3.X = 37;
            _point3.Y = 50;

            _point4.X = 22;
            _point4.Y = 50;

            _point5.X = 15;
            _point5.Y = 30;    
            
            _curvePoints = new []
            {_point1, _point2, _point3, _point4, _point5};
        }

        public override void Draw(IDrawable drawable)
        {
            drawable.Draw(this);
        }
        
        public override string ToString()
        {
            return "Polygon";
        }

    }
}
