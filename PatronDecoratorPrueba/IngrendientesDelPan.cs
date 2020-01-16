using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecoratorPrueba
{
    interface IngrendientesDelPan
    {
        //Primero creamos una interfaz que nos permita visualizar el estado de pan
        //En esta interfaz podemos añadir más métodos que nos permita modificar el tipo de pan

        void visualiza();

        //Añadimos  los ingrendientes que deseamos presentar
        void añadirChocolate();

        void añadirPasas();

       

        void añadirPiña();


    }
}
