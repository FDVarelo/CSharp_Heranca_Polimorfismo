using Course5.Entities.Enums;

namespace Course5.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape()
        {

        }
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
