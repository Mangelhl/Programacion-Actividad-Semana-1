using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase1
{
    internal class Circle
    {
        private double radio;

        public Circle(double radio)
        {
            this.radio = radio;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
