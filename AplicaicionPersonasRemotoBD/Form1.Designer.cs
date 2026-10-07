namespace AplicaicionPersonasRemotoBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            TxtID = new TextBox();
            TxtNombre = new TextBox();
            label2 = new Label();
            TxtTelefono = new TextBox();
            label3 = new Label();
            BtnNuevo = new Button();
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            BtnSalir = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            DgvPersonas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // TxtID
            // 
            TxtID.Enabled = false;
            TxtID.Location = new Point(90, 9);
            TxtID.Margin = new Padding(2, 2, 2, 2);
            TxtID.MaxLength = 19;
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(191, 27);
            TxtID.TabIndex = 2;
            TxtID.KeyPress += TxtID_KeyPress;
            // 
            // TxtNombre
            // 
            TxtNombre.Enabled = false;
            TxtNombre.Location = new Point(90, 48);
            TxtNombre.Margin = new Padding(2, 2, 2, 2);
            TxtNombre.MaxLength = 100;
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(290, 27);
            TxtNombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 53);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // TxtTelefono
            // 
            TxtTelefono.Enabled = false;
            TxtTelefono.Location = new Point(90, 97);
            TxtTelefono.Margin = new Padding(2, 2, 2, 2);
            TxtTelefono.MaxLength = 100;
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(121, 27);
            TxtTelefono.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 102);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 5;
            label3.Text = "Telefono";
            // 
            // BtnNuevo
            // 
            BtnNuevo.Image = (Image)resources.GetObject("BtnNuevo.Image");
            BtnNuevo.ImageAlign = ContentAlignment.TopCenter;
            BtnNuevo.Location = new Point(24, 152);
            BtnNuevo.Margin = new Padding(2, 2, 2, 2);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(90, 70);
            BtnNuevo.TabIndex = 7;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.TextAlign = ContentAlignment.BottomCenter;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Enabled = false;
            BtnGuardar.Image = (Image)resources.GetObject("BtnGuardar.Image");
            BtnGuardar.ImageAlign = ContentAlignment.TopCenter;
            BtnGuardar.Location = new Point(121, 152);
            BtnGuardar.Margin = new Padding(2, 2, 2, 2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(90, 70);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextAlign = ContentAlignment.BottomCenter;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Enabled = false;
            BtnCancelar.Image = (Image)resources.GetObject("BtnCancelar.Image");
            BtnCancelar.ImageAlign = ContentAlignment.TopCenter;
            BtnCancelar.Location = new Point(215, 152);
            BtnCancelar.Margin = new Padding(2, 2, 2, 2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(90, 70);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancalar";
            BtnCancelar.TextAlign = ContentAlignment.BottomCenter;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.ImageAlign = ContentAlignment.TopCenter;
            BtnSalir.Location = new Point(507, 152);
            BtnSalir.Margin = new Padding(2, 2, 2, 2);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(90, 70);
            BtnSalir.TabIndex = 12;
            BtnSalir.Text = "Salir";
            BtnSalir.TextAlign = ContentAlignment.BottomCenter;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Image = (Image)resources.GetObject("BtnEliminar.Image");
            BtnEliminar.ImageAlign = ContentAlignment.TopCenter;
            BtnEliminar.Location = new Point(413, 152);
            BtnEliminar.Margin = new Padding(2, 2, 2, 2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(90, 70);
            BtnEliminar.TabIndex = 11;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.TextAlign = ContentAlignment.BottomCenter;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Image = (Image)resources.GetObject("BtnEditar.Image");
            BtnEditar.ImageAlign = ContentAlignment.TopCenter;
            BtnEditar.Location = new Point(316, 152);
            BtnEditar.Margin = new Padding(2, 2, 2, 2);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(90, 70);
            BtnEditar.TabIndex = 10;
            BtnEditar.Text = "Editar";
            BtnEditar.TextAlign = ContentAlignment.BottomCenter;
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // DgvPersonas
            // 
            DgvPersonas.AllowUserToAddRows = false;
            DgvPersonas.AllowUserToDeleteRows = false;
            DgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPersonas.Location = new Point(24, 241);
            DgvPersonas.Margin = new Padding(2, 2, 2, 2);
            DgvPersonas.Name = "DgvPersonas";
            DgvPersonas.ReadOnly = true;
            DgvPersonas.RowHeadersWidth = 62;
            DgvPersonas.Size = new Size(573, 180);
            DgvPersonas.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 432);
            ControlBox = false;
            Controls.Add(DgvPersonas);
            Controls.Add(BtnSalir);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(BtnNuevo);
            Controls.Add(TxtTelefono);
            Controls.Add(label3);
            Controls.Add(TxtNombre);
            Controls.Add(label2);
            Controls.Add(TxtID);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Personas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox TxtID;
        private TextBox TxtNombre;
        private Label label2;
        private TextBox TxtTelefono;
        private Label label3;
        private Button BtnNuevo;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private Button BtnSalir;
        private Button BtnEliminar;
        private Button BtnEditar;
        private DataGridView DgvPersonas;
    }
}
