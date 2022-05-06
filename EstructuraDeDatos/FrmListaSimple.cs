using System;
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
            Tramites.Recorrer(cmbLista);

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Int16 x = Convert.ToInt16(cmbLista.Text);

            Tramites.Eliminar(x);
            Tramites.Recorrer(dgvListaSimple);
            Tramites.Recorrer(lstListaSimple);
            Tramites.Recorrer(cmbLista);

            BtnEliminar.Enabled = false;

        }
        private void cmbLista_TextChanged(object sender, EventArgs e)
        {
            //if (cmbLista.Text == "")
            //{
            //    BtnEliminar.Enabled = false;
            //}
            //else
            //{
            //    BtnEliminar.Enabled = true;
            //}
        }

        private void FrmListaSimple_Load(object sender, EventArgs e)
        {
           BtnEliminar.Enabled=false;   
        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLista.Text == "")
            {
                BtnEliminar.Enabled = false;
            }
            else
            {
                BtnEliminar.Enabled = true;
            }
        }
    }
}
