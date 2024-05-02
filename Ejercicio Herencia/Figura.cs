using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    public class Figura : Operaciones
    {
        public void Imprimir()
        {
            Console.WriteLine($"Area: {Area()}");
            Console.WriteLine($"Longitud: {Longitud()}");
            Console.WriteLine($"Volumen: {Volumen()}");
        }

    }
}
