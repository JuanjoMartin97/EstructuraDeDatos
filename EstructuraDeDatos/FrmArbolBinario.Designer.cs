namespace EstructuraDeDatos
{
    partial class FrmArbolBinario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbArbolBinario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstArbolPostOrden = new System.Windows.Forms.ListBox();
            this.lstArbolPreOrden = new System.Windows.Forms.ListBox();
            this.lstArbolEnOrden = new System.Windows.Forms.ListBox();
            this.dgvArbolBinario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrbElementoEliminado.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).BeginInit();
            this.GrbNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbElementoEliminado
            // 
            this.GrbElementoEliminado.Controls.Add(this.btnBuscar);
            this.GrbElementoEliminado.Controls.Add(this.cmbArbolBinario);
            this.GrbElementoEliminado.Controls.Add(this.label4);
            this.GrbElementoEliminado.Controls.Add(this.BtnEliminar);
            this.GrbElementoEliminado.Location = new System.Drawing.Point(808, 12);
            this.GrbElementoEliminado.Name = "GrbElementoEliminado";
            this.GrbElementoEliminado.Size = new System.Drawing.Size(242, 153);
            this.GrbElementoEliminado.TabIndex = 19;
            this.GrbElementoEliminado.TabStop = false;
            this.GrbElementoEliminado.Text = "Elemento Eliminado";
            this.GrbElementoEliminado.Enter += new System.EventHandler(this.GrbElementoEliminado_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(19, 116);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(217, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cmbArbolBinario
            // 
            this.cmbArbolBinario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArbolBinario.FormattingEnabled = true;
            this.cmbArbolBinario.Location = new System.Drawing.Point(85, 36);
            this.cmbArbolBinario.Name = "cmbArbolBinario";
            this.cmbArbolBinario.Size = new System.Drawing.Size(121, 21);
            this.cmbArbolBinario.TabIndex = 5;
            this.cmbArbolBinario.SelectedIndexChanged += new System.EventHandler(this.cmbArbolBinario_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codigo:";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(19, 77);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(217, 23);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstArbolPostOrden);
            this.groupBox3.Controls.Add(this.lstArbolPreOrden);
            this.groupBox3.Controls.Add(this.lstArbolEnOrden);
            this.groupBox3.Controls.Add(this.dgvArbolBinario);
            this.groupBox3.Location = new System.Drawing.Point(27, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1001, 339);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado en una Grilla";
            // 
            // lstArbolPostOrden
            // 
            this.lstArbolPostOrden.FormattingEnabled = true;
            this.lstArbolPostOrden.Location = new System.Drawing.Point(680, 34);
            this.lstArbolPostOrden.Name = "lstArbolPostOrden";
            this.lstArbolPostOrden.Size = new System.Drawing.Size(294, 147);
            this.lstArbolPostOrden.TabIndex = 3;
            // 
            // lstArbolPreOrden
            // 
            this.lstArbolPreOrden.FormattingEnabled = true;
            this.lstArbolPreOrden.Location = new System.Drawing.Point(353, 34);
            this.lstArbolPreOrden.Name = "lstArbolPreOrden";
            this.lstArbolPreOrden.Size = new System.Drawing.Size(294, 147);
            this.lstArbolPreOrden.TabIndex = 2;
            // 
            // lstArbolEnOrden
            // 
            this.lstArbolEnOrden.FormattingEnabled = true;
            this.lstArbolEnOrden.Location = new System.Drawing.Point(24, 34);
            this.lstArbolEnOrden.Name = "lstArbolEnOrden";
            this.lstArbolEnOrden.Size = new System.Drawing.Size(294, 147);
            this.lstArbolEnOrden.TabIndex = 1;
            // 
            // dgvArbolBinario
            // 
            this.dgvArbolBinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbolBinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvArbolBinario.Location = new System.Drawing.Point(6, 197);
            this.dgvArbolBinario.Name = "dgvArbolBinario";
            this.dgvArbolBinario.RowHeadersWidth = 51;
            this.dgvArbolBinario.Size = new System.Drawing.Size(989, 130);
            this.dgvArbolBinario.TabIndex = 0;
            this.dgvArbolBinario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArbolBinario_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // GrbNuevoElemento
            // 
            this.GrbNuevoElemento.Controls.Add(this.txtTramite);
            this.GrbNuevoElemento.Controls.Add(this.txtNombre);
            this.GrbNuevoElemento.Controls.Add(this.txtCodigo);
            this.GrbNuevoElemento.Controls.Add(this.label3);
            this.GrbNuevoElemento.Controls.Add(this.label2);
            this.GrbNuevoElemento.Controls.Add(this.label1);
            this.GrbNuevoElemento.Controls.Add(this.BtnAgregar);
            this.GrbNuevoElemento.Location = new System.Drawing.Point(538, 12);
            this.GrbNuevoElemento.Name = "GrbNuevoElemento";
            this.GrbNuevoElemento.Size = new System.Drawing.Size(255, 212);
            this.GrbNuevoElemento.TabIndex = 17;
            this.GrbNuevoElemento.TabStop = false;
            this.GrbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(97, 133);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(97, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tramite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(79, 172);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(134, 23);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(827, 184);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(217, 23);
            this.btnEquilibrar.TabIndex = 20;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EstructuraDeDatos.Properties.Resources.ArbolBinario_png;
            this.pictureBox1.Location = new System.Drawing.Point(51, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 604);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.GrbElementoEliminado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GrbNuevoElemento);
            this.Name = "FrmArbolBinario";
            this.Text = "FrmArbolBinario";
            this.Load += new System.EventHandler(this.FrmArbolBinario_Load);
            this.GrbElementoEliminado.ResumeLayout(false);
            this.GrbElementoEliminado.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).EndInit();
            this.GrbNuevoElemento.ResumeLayout(false);
            this.GrbNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbElementoEliminado;
        private System.Windows.Forms.ComboBox cmbArbolBinario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvArbolBinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox GrbNuevoElemento;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ListBox lstArbolPostOrden;
        private System.Windows.Forms.ListBox lstArbolPreOrden;
        private System.Windows.Forms.ListBox lstArbolEnOrden;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}