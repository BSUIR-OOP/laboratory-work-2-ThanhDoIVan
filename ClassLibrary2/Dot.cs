
namespace ClassLibrary2
{
    public class Dot : Shape
    {
        public readonly int _pointX;
        public readonly int _pointY;
        public readonly int _height;
        public readonly int _weidth;
      

        public Dot()
        {
            _pointX = 20;
            _pointY = 20;
            _height = 1;
            _weidth = 1;
        }      
     
        public override void Draw(IDrawable drawable)
        {
            drawable.Draw(this);
        }

        public override string ToString()
        {
            return "Dot";
        }
    }
}
