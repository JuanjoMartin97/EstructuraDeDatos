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
    public partial class FrmVentanaPrincipal : Form
    {
        public FrmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void FrmVentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe ObjVentana = new FrmAcercaDe();
            ObjVentana.ShowDialog();
            
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCola ObjVentana = new FrmCola();
            ObjVentana.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCola ObjVentana = new FrmCola();
            ObjVentana.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaSimple ObjVentana = new FrmListaSimple();
                ObjVentana.ShowDialog();
        }
    }
}
