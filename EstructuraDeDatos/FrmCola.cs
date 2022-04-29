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
    public partial class FrmCola : Form
    {
        public FrmCola()
        {
            InitializeComponent();
        }

        Cola FilaDePersonas = new Cola();
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Nodo NuevoNodo = new Nodo();
            NuevoNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            NuevoNodo.Nombre = txtNombre.Text;
            NuevoNodo.Tramite = txtTramite.Text;

            FilaDePersonas.Agregar(NuevoNodo);
            FilaDePersonas.Recorrer(lstCola);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(FilaDePersonas.Primero !=null){
                txtEliminarCodigo.Text = FilaDePersonas.Primero.Codigo.ToString();
                txtEliminarNombre.Text = FilaDePersonas.Primero.Nombre;
                txtEliminarTramite.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(lstCola);
                FilaDePersonas.Recorrer(dgvCola);

            }
        }
        private void FrmCola_Load(object sender, EventArgs e)
        {

        }

    }
}
