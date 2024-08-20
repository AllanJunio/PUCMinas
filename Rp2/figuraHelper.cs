using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rp2
{
    internal class figuraHelper
    {
        public static double calcularPerimetro(double raio)
        {
            return 2 * Math.PI * raio;
        }

        public static double calcularPerimetro(double x, double altura)
        {
            return 2 * Math.PI * x + altura;

        }

        public static double calcularPerimetro(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 + lado3;

        }
    }
}
