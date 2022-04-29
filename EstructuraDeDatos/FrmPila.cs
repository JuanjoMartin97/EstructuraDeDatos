using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    public partial class FrmPila : Form
    {
        private void FrmPila_Load(object sender, EventArgs e)
        {

        }
        public FrmPila()
        {
            InitializeComponent();
        }


        //instancio objeto de la clase PILA
        //se instancia de forma GLOBAL

        Pila Tramites = new Pila();

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Tramites.Agregar(objNodo);
            Tramites.Recorrer(lstPila);
            Tramites.Recorrer(dgvPila);

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            txtCodigo.Text = Tramites.Primero.ToString();
           txtNombre.Text = Tramites.Primero.Nombre;
            txtTramite.Text = Tramites.Primero.Tramite;

            Tramites.Eliminar();
            Tramites.Recorrer(lstPila);
            Tramites.Recorrer(dgvPila);
        }
    }
}
