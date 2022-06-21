using System;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    internal class ListaDoble
    {
        private Nodo pri;
        private Nodo ult;

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

        public void Agregar(Nodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;

                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;

                    }
                    else
                    {
                        Nodo Aux = Primero;
                        Nodo Ant = Primero;
                        while (Aux.Codigo < Nuevo.Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;

                        }
                        Ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = Aux;
                        Aux.Anterior = Nuevo;
                        Nuevo.Anterior = Ant;
                    }
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;

            }
            else
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;

                }
                else
                {
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        Nodo aux = Primero;
                        Nodo ant = Primero;

                        while (aux.Codigo < Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        ant.Siguiente = aux.Siguiente;
                        aux = aux.Siguiente;
                        aux.Anterior = ant;

                    }
                }

            }
        }

        public void RecorrerAsc(DataGridView dgvListaDoble)
        {
            Nodo aux = Primero;
            dgvListaDoble.Rows.Clear();
            while (aux != null)
            {
                dgvListaDoble.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;

            }
        }

        public void RecorrerDes(ListBox lstListaDoble)
        {
            Nodo aux = ult;
            lstListaDoble.Items.Clear();
            while (aux != null)
            {
                lstListaDoble.Items.Add(aux.Codigo + "  " + aux.Nombre + "  " + aux.Tramite);
                aux = aux.Anterior;
            }
        }

        public void RecorrerCmb(ComboBox cmbListaDoble)
        {
            Nodo aux = pri;
            cmbListaDoble.Items.Clear();
            while (aux != null)
            {
                cmbListaDoble.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
    }
}
