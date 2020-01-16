using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecoratorPrueba
{
    //Creamos la clase abstracta decorator  para pasar por parámetro un componente 

    abstract class Decorator : IngrendientesDelPan
    {
        protected IngrendientesDelPan componente;

        public Decorator(IngrendientesDelPan componente)
        {
            this.componente = componente;
        }


        public virtual void visualiza()
        {
            componente.visualiza();
        }

        public virtual void añadirChocolate()
        {
            componente.añadirChocolate();
        }

        public virtual void añadirPasas()
        {
            componente.añadirPasas();
        }
        public virtual void añadirPiña()
        {
            componente.añadirPiña();
        }
    }
}
