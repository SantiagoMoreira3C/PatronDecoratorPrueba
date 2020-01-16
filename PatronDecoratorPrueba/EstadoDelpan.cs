using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecoratorPrueba
{
    class EstadoDelPan: IngrendientesDelPan
    {
        // implementamos la interfaz IngrendientesDelPan para utilizar el método visualiza
        public void visualiza()
        {
            Console.WriteLine("Visualización del Pan");
        }
        public void añadirChocolate()
        {
            Console.WriteLine(" Al pan se le ha añadido Chocolate");
        }

        public void añadirPasas()
        {
            Console.WriteLine("Al pan se le ha añadido Pasas");
        }
        public void añadirPiña()
        {
            Console.WriteLine("Al pan se le ha añadido Piña");
        }

    }
}
