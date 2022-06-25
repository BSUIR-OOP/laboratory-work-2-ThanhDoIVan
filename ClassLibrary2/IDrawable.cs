namespace ClassLibrary2
{
    public interface IDrawable
    {
        void Draw(Dot shape);
        void Draw(Ellipse shape);
        void Draw(Line shape);
        void Draw(Polygon shape);
        void Draw(Rectangle shape);
        void Draw(Trapezium shape);
        void Draw(Triangle shape);

    }
}