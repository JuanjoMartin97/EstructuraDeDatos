﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    class ListaSimple
    

            //el ultimo que entra es el primero que se va
    {
        //Declaro dos campos
        private Nodo pri;

        //Declaro dos propiedades
        public Nodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public void Agregar(Nodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    Nodo aux = Primero;
                    Nodo ant = Primero;

                    while(Nuevo.Codigo> aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;

                        if (aux == null) break;
                    }

                    ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = aux;
                }

                
            }
        }
        public void Recorrer(DataGridView Grilla)
        {

            Nodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
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
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + "" + aux.Tramite);
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
        public void Eliminar(Int32 codigo)
        {

            if (Primero.Codigo == codigo)
            {
                Primero = Primero.Siguiente;

            }
            else
            {
                Nodo Ant = Primero;
                Nodo Aux = Primero;
                while (Aux.Codigo != codigo)
                {
                    Ant = Aux;
                    Aux = Aux.Siguiente;
                }
                Ant.Siguiente = Aux.Siguiente;
            }

        }
    }

    }


