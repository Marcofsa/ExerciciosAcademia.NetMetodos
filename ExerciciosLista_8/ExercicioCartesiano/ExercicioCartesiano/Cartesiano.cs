using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCartesiano
{
    internal class Cartesiano
    {
        private double _x { get; set; }
        private double _y { get; set; }

        public Cartesiano(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }

        public static void getXY(List<Cartesiano> c, int indice)
        {
            Console.WriteLine($"X: {c[indice]._x}  |  Y: {c[indice]._y}");
        }
    }
}
