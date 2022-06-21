namespace EstructuraDeDatos
{
    partial class FrmListaDoble
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstListaDoble = new System.Windows.Forms.ListBox();
            this.dgvListaDoble = new System.Windows.Forms.DataGridView();
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
            this.GrbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbListaDoble = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).BeginInit();
            this.GrbNuevoElemento.SuspendLayout();
            this.GrbElementoEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstListaDoble);
            this.groupBox3.Controls.Add(this.dgvListaDoble);
            this.groupBox3.Location = new System.Drawing.Point(12, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 298);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado en una Lista y una Grilla";
            // 
            // lstListaDoble
            // 
            this.lstListaDoble.FormattingEnabled = true;
            this.lstListaDoble.Location = new System.Drawing.Point(6, 21);
            this.lstListaDoble.Name = "lstListaDoble";
            this.lstListaDoble.Size = new System.Drawing.Size(296, 264);
            this.lstListaDoble.TabIndex = 1;
            this.lstListaDoble.SelectedIndexChanged += new System.EventHandler(this.lstListaDoble_SelectedIndexChanged);
            // 
            // dgvListaDoble
            // 
            this.dgvListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvListaDoble.Location = new System.Drawing.Point(320, 19);
            this.dgvListaDoble.Name = "dgvListaDoble";
            this.dgvListaDoble.RowHeadersWidth = 51;
            this.dgvListaDoble.Size = new System.Drawing.Size(421, 267);
            this.dgvListaDoble.TabIndex = 0;
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
            this.GrbNuevoElemento.Location = new System.Drawing.Point(482, 32);
            this.GrbNuevoElemento.Name = "GrbNuevoElemento";
            this.GrbNuevoElemento.Size = new System.Drawing.Size(237, 212);
            this.GrbNuevoElemento.TabIndex = 12;
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
            this.BtnAgregar.Location = new System.Drawing.Point(97, 178);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(96, 23);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // GrbElementoEliminado
            // 
            this.GrbElementoEliminado.Controls.Add(this.cmbListaDoble);
            this.GrbElementoEliminado.Controls.Add(this.label4);
            this.GrbElementoEliminado.Controls.Add(this.BtnEliminar);
            this.GrbElementoEliminado.Location = new System.Drawing.Point(12, 167);
            this.GrbElementoEliminado.Name = "GrbElementoEliminado";
            this.GrbElementoEliminado.Size = new System.Drawing.Size(409, 89);
            this.GrbElementoEliminado.TabIndex = 16;
            this.GrbElementoEliminado.TabStop = false;
            this.GrbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmbListaDoble
            // 
            this.cmbListaDoble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaDoble.FormattingEnabled = true;
            this.cmbListaDoble.Location = new System.Drawing.Point(87, 48);
            this.cmbListaDoble.Name = "cmbListaDoble";
            this.cmbListaDoble.Size = new System.Drawing.Size(121, 21);
            this.cmbListaDoble.TabIndex = 5;
            this.cmbListaDoble.SelectedIndexChanged += new System.EventHandler(this.cmbListaDoble_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codigo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(270, 54);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(96, 23);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EstructuraDeDatos.Properties.Resources.ListaDoble;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FrmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GrbElementoEliminado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GrbNuevoElemento);
            this.Name = "FrmListaDoble";
            this.Text = "FrmListaDoble";
            this.Load += new System.EventHandler(this.FrmListaDoble_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).EndInit();
            this.GrbNuevoElemento.ResumeLayout(false);
            this.GrbNuevoElemento.PerformLayout();
            this.GrbElementoEliminado.ResumeLayout(false);
            this.GrbElementoEliminado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstListaDoble;
        private System.Windows.Forms.DataGridView dgvListaDoble;
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
        private System.Windows.Forms.GroupBox GrbElementoEliminado;
        private System.Windows.Forms.ComboBox cmbListaDoble;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}