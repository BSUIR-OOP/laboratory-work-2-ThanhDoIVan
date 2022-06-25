using System.Drawing;

namespace ClassLibrary2
{
    public abstract class Shape
    {
        public Color Color { get; } = Color.Black;

        public abstract void Draw(IDrawable drawable);

    }
}
