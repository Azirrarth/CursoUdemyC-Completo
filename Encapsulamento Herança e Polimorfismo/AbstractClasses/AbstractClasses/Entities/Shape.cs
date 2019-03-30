using AbstractClasses.Entities.Enums;

namespace AbstractClasses.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }


        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
