using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecoratorPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //En una panadería se espera añadir pan con más ingrendientes y funciones alrededor de dicho objeto.

            //PatronDecorator
            //Permite añadir nuevas funciones sumplementarias a un objeto, en este caso al pan



            //Instanciamos la clase EstadoDelPan que contiene nuestros métodos
            EstadoDelPan visualizar = new EstadoDelPan();

            visualizar.visualiza();
            visualizar.añadirChocolate();
            visualizar.añadirPasas();
            visualizar.añadirPiña();

            
            Console.ReadKey();
        
        }
    }
}
