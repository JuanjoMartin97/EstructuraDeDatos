﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos
{
    class Nodo
    {
        //Declaramos la clase del objeto 
        //Los campos son privados
        private Int32 cod;
        private String nom;
        private String tra;
        private Nodo ant;
        private Nodo sig;
        private Nodo der;
        private Nodo izq;



        //Declaramos las propiedades del objeto
        //las propiedades son publicas
        public Int32 Codigo
        {
            get { return cod; } //retorna valor de la variable
            set { cod = value; } //asigna un valor a la variable
        }
        public String Nombre
        {
            get { return nom; } //retorna valor de la variable
            set { nom = value; } //asigna un valor a la variable
        }
        public String Tramite
        {
            get { return tra; } //retorna valor de la variable
            set { tra = value; } //asigna un valor a la variable
        }
        public Nodo Siguiente
        {
            get { return sig; } //retorna valor de la variable
            set { sig = value; } //asigna un valor a la variable
        }
        public Nodo Anterior
        {
            get { return ant; } //retorna valor de la variable
            set { ant = value; } //asigna un valor a la variable
        }
        public Nodo Derecha
        {
            get { return der; } //retorna valor de la variable
            set { der = value; } //asigna un valor a la variable
        }
        public Nodo Izquierda
        {
            get { return izq; } //retorna valor de la variable
            set { izq = value; } //asigna un valor a la variable
        }

       
    }
}
