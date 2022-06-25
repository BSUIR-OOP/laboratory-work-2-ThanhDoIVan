using System.Drawing;

namespace ClassLibrary2
{
    public class Ellipse : Shape
    {
        public RectangleF _rect;
        public Ellipse()
        {
            _rect.X = 20;
            _rect.Y = 20;
            _rect.Width = 20;
            _rect.Height = 30;
        }
        
        public override void Draw(IDrawable drawable)
        {
            drawable.Draw(this);
        }

        public override string ToString()
        {
            return "Ellipse";
        }

    }
}