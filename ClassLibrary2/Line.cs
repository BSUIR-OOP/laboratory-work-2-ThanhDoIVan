using System.Drawing;

namespace ClassLibrary2
{
    public class Line:Shape
    {
       public Point Start;
       public Point Finish;

        public Line()
        {
            Start.X = 5;
            Start.Y = 5;
            Finish.X = 45;
            Finish.Y = 20;
        }

        public override void Draw(IDrawable drawable)
        {
            drawable.Draw(this);
        }

        public override string ToString()
        {
            return "Line";
        }

    }
}
