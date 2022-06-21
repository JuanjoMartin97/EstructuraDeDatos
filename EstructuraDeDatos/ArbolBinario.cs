using System;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    internal class ArbolBinario
    {


        private Nodo Inicio;
        public Nodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }

        private Nodo[] Vector = new Nodo[100];
        private Int32 i = 0;
        public void Agregar(Nodo Nvo)
        {

            Nvo.Izquierda = null;
            Nvo.Derecha = null;
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {

                Nodo NodoPadre = Raiz; //ant
                Nodo aux = Raiz;
                while (aux != null)
                {
                    NodoPadre = aux;
                    if (Nvo.Codigo < aux.Codigo)
                    {
                        aux = aux.Izquierda;
                    }
                    else
                    {
                        aux = aux.Derecha;
                    }
                }
                if (Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierda = Nvo;
                }
                else
                {
                    NodoPadre.Derecha = Nvo;
                }
            }
        }

        public void Listar(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        public void Listar(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        public void InOrdenAsc(ComboBox Combo, Nodo R)
        {
            if (R.Izquierda != null)
            {
                InOrdenAsc(Combo, R.Izquierda);
            }
            Combo.Items.Add(R.Codigo);
            if (R.Derecha != null)
            {
                InOrdenAsc(Combo, R.Derecha);
            }
        }





        public void InOrdenAsc(ListBox Lst, Nodo R)
        {
            if (R.Izquierda != null)
            {
                InOrdenAsc(Lst, R.Izquierda);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Derecha != null)
            {
                InOrdenAsc(Lst, R.Derecha);
            }
        }

        public void Listar(DataGridView Lista)
        {
            Lista.Rows.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        public void InOrdenAsc(DataGridView Lst, Nodo R)
        {

            if (R.Izquierda != null)
            {
                InOrdenAsc(Lst, R.Izquierda);
            }
            Lst.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecha != null)
            {
                InOrdenAsc(Lst, R.Derecha);
            }

        }

        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        public void GrabarVectorInOrden(Nodo NodoPadre)
        {
            if (NodoPadre.Izquierda != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierda);
            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecha != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecha);
            }
        }

        public void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

    }

}


