using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase1
{
    internal class Triangle
    {
        private double baseTriangle;
        private double heightTriangle;

        public Triangle(double baseTriangle, double heightTriangle)
        {
            this.baseTriangle = baseTriangle;
            this.heightTriangle = heightTriangle;
        }

        public double CalculateArea()
        {
            return (baseTriangle * heightTriangle) / 2;
        }
    }
}
