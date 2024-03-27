using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase1
{
    internal class Rectangle
    {
        private double baseRectangle;
        private double heightRectangle;

        public Rectangle(double baseRectangulo, double heightRectangulo)
        {
            this.baseRectangle = baseRectangulo;
            this.heightRectangle = heightRectangulo;
        }

        public double CalculateArea()
        {
            return baseRectangle * heightRectangle;
        }
    }
}
