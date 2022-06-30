using System;
using Course5.Entities.Enums;

namespace Course5.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {

        }
        public Circle(Color color, double radius)
            : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
            
        }
    }
}
