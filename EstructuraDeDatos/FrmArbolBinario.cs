using System;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    public partial class FrmArbolBinario : Form
    {
        public FrmArbolBinario()
        {
            InitializeComponent();
        }

        ArbolBinario Tramites = new ArbolBinario();

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Tramites.Agregar(objNodo);
            Tramites.Listar(lstArbolEnOrden);
            Tramites.Listar(dgvArbolBinario);
            Tramites.Listar(cmbArbolBinario);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void FrmArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void dgvArbolBinario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Int32 x = Convert.ToInt32(cmbArbolBinario.Text);


            //Tramites.Eliminar(x);
            Tramites.Listar(lstArbolEnOrden);
            Tramites.Listar(dgvArbolBinario);
            Tramites.Listar(cmbArbolBinario);


            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            cmbArbolBinario.Text = "";
        }

        private void cmbArbolBinario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GrbElementoEliminado_Enter(object sender, EventArgs e)
        {

        }
    }
}
