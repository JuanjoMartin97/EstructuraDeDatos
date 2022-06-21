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
    public partial class FrmListaDoble : Form
    {
        public FrmListaDoble()
        {
            InitializeComponent();
        }

        ListaDoble Tramites = new ListaDoble();

        private void FrmListaDoble_Load(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
        }

        private void lstListaDoble_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbListaDoble_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbListaDoble.Text == "")
            {
                BtnEliminar.Enabled = false;
            }
            else
            {
                BtnEliminar.Enabled = true;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Tramites.Agregar(objNodo);
            Tramites.RecorrerDes(lstListaDoble);
            Tramites.RecorrerAsc(dgvListaDoble);
            Tramites.RecorrerCmb(cmbListaDoble);


            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Int32 x = Convert.ToInt32(cmbListaDoble.Text);

            Tramites.Eliminar(x);
            Tramites.RecorrerAsc(dgvListaDoble);
            Tramites.RecorrerDes(lstListaDoble);
            Tramites.RecorrerCmb(cmbListaDoble);
            

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            cmbListaDoble.Text = "";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
