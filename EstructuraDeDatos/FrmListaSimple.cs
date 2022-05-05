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
    public partial class FrmListaSimple : Form
    {
        public FrmListaSimple()
        {
            InitializeComponent();
        }

        ListaSimple Tramites = new ListaSimple();

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Tramites.Agregar(objNodo);
            Tramites.Recorrer(lstListaSimple);
            Tramites.Recorrer(dgvListaSimple);

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
