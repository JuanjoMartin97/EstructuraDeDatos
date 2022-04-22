using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos
{
    class Cola
    {
        //Declaro dos campos
        private Nodo pri;
        private Nodo ult;

        //Declaro dos propiedades
        public Nodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public Nodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(Nodo Nuevo) {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
            Ultimo.Siguiente = Nuevo;
            Ultimo = Nuevo;
            }
        }
        public void Eliminar() {
            Primero = Primero.Siguiente;
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else {
                Primero = Primero.Siguiente;
            }
        }
        public void Recorrer() {
        
        }
             


    }
}
