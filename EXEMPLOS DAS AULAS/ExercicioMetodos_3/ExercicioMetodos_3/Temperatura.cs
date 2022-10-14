using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodos_3
{
    public class Temperatura
    {
        public double celsius = 0;
        public double getCelsius()
        {
        
            return (((celsius * 9) /5) +32); //CONVERTE PARA FAHRENHEIT
        
        }
        public void setCelsius(double fahrenheit)
        {
            Console.WriteLine("Fahrenheit " + fahrenheit);
            
            celsius = (((fahrenheit - 32) *5 ) /9); //CONVERTE PARA CELSIUS
            
            Console.WriteLine("Celsius " + celsius);
        }
    }
}
