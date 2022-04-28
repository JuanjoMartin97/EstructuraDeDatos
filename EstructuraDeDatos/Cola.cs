using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //--------------------------
        //--------------------------
        //--------------------------

        //se declaran metodos
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
            
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else {
                Primero = Primero.Siguiente;
            }
        }
        public void Recorrer(DataGridView Grilla) {

            Nodo aux = Primero;
            Grilla.Rows.Clear();
            while ( aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }   
        }

        public void Recorrer(ListBox Lista)
        {

            Nodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {

            Nodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }




    }
}
