using System.Globalization;

namespace Interface2.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public override double Area()
        {
            return Width * Heigth;
        }

        public override string ToString()
        {
            return "Rectangle Color = "
                + Color
                + ", Width = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", Heigth = "
                + Heigth.ToString("F2", CultureInfo.InvariantCulture)
                + ", Area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
