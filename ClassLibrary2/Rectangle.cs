namespace ClassLibrary2
{
    public class Rectangle : Shape
    {
        public readonly int _startX;
        public readonly int _startY;
        public readonly int _width;
        public readonly int _height;


        public Rectangle()
        {
            _startX = 10;
            _startY = 10;
            _width = 40;
            _height = 30;
        }
        
        public override void Draw(IDrawable drawable)
        {
            drawable.Draw(this);
        }

        public override string ToString()
        {
            return "Rectangle";
        }

    }
}
