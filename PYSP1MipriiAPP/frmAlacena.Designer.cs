namespace PYSP1MipriiAPP
{
    partial class frmCargaDeDatosEnLaAlacena
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
            this.mrcLugar = new System.Windows.Forms.GroupBox();
            this.optHeladera = new System.Windows.Forms.RadioButton();
            this.optMedicamentos = new System.Windows.Forms.RadioButton();
            this.optBaño = new System.Windows.Forms.RadioButton();
            this.optLimpieza = new System.Windows.Forms.RadioButton();
            this.optAlacena = new System.Windows.Forms.RadioButton();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.chkCaduca = new System.Windows.Forms.CheckBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.lblCompra = new System.Windows.Forms.Label();
            this.mrcLugar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcLugar
            // 
            this.mrcLugar.Controls.Add(this.optHeladera);
            this.mrcLugar.Controls.Add(this.optMedicamentos);
            this.mrcLugar.Controls.Add(this.optBaño);
            this.mrcLugar.Controls.Add(this.optLimpieza);
            this.mrcLugar.Controls.Add(this.optAlacena);
            this.mrcLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcLugar.Location = new System.Drawing.Point(10, 12);
            this.mrcLugar.Name = "mrcLugar";
            this.mrcLugar.Size = new System.Drawing.Size(363, 79);
            this.mrcLugar.TabIndex = 0;
            this.mrcLugar.TabStop = false;
            this.mrcLugar.Text = "Lugar:";
            // 
            // optHeladera
            // 
            this.optHeladera.AutoSize = true;
            this.optHeladera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optHeladera.Location = new System.Drawing.Point(6, 48);
            this.optHeladera.Name = "optHeladera";
            this.optHeladera.Size = new System.Drawing.Size(82, 20);
            this.optHeladera.TabIndex = 4;
            this.optHeladera.TabStop = true;
            this.optHeladera.Text = "Heladera";
            this.optHeladera.UseVisualStyleBackColor = true;
            // 
            // optMedicamentos
            // 
            this.optMedicamentos.AutoSize = true;
            this.optMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMedicamentos.Location = new System.Drawing.Point(236, 22);
            this.optMedicamentos.Name = "optMedicamentos";
            this.optMedicamentos.Size = new System.Drawing.Size(114, 20);
            this.optMedicamentos.TabIndex = 3;
            this.optMedicamentos.TabStop = true;
            this.optMedicamentos.Text = "Medicamentos\r\n";
            this.optMedicamentos.UseVisualStyleBackColor = true;
            // 
            // optBaño
            // 
            this.optBaño.AutoSize = true;
            this.optBaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optBaño.Location = new System.Drawing.Point(173, 22);
            this.optBaño.Name = "optBaño";
            this.optBaño.Size = new System.Drawing.Size(57, 20);
            this.optBaño.TabIndex = 2;
            this.optBaño.TabStop = true;
            this.optBaño.Text = "Baño";
            this.optBaño.UseVisualStyleBackColor = true;
            // 
            // optLimpieza
            // 
            this.optLimpieza.AutoSize = true;
            this.optLimpieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optLimpieza.Location = new System.Drawing.Point(88, 22);
            this.optLimpieza.Name = "optLimpieza";
            this.optLimpieza.Size = new System.Drawing.Size(79, 20);
            this.optLimpieza.TabIndex = 1;
            this.optLimpieza.TabStop = true;
            this.optLimpieza.Text = "Limpieza";
            this.optLimpieza.UseVisualStyleBackColor = true;
            // 
            // optAlacena
            // 
            this.optAlacena.AutoSize = true;
            this.optAlacena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAlacena.Location = new System.Drawing.Point(6, 22);
            this.optAlacena.Name = "optAlacena";
            this.optAlacena.Size = new System.Drawing.Size(75, 20);
            this.optAlacena.TabIndex = 0;
            this.optAlacena.TabStop = true;
            this.optAlacena.Text = "Alacena";
            this.optAlacena.UseVisualStyleBackColor = true;
            this.optAlacena.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(7, 98);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(61, 16);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Items.AddRange(new object[] {
            "Galletas",
            "Fideos",
            "Leche",
            "Huevos",
            "Lavandina",
            "Fiambre",
            "Parecetamol",
            "Loratadina",
            "Trapo",
            "Escobillon",
            "Jabon",
            "Detergente",
            "Desodorante de ambiente"});
            this.cboProducto.Location = new System.Drawing.Point(74, 97);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(117, 21);
            this.cboProducto.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(264, 99);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(197, 102);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 16);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // chkCaduca
            // 
            this.chkCaduca.AutoSize = true;
            this.chkCaduca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCaduca.Location = new System.Drawing.Point(6, 136);
            this.chkCaduca.Name = "chkCaduca";
            this.chkCaduca.Size = new System.Drawing.Size(87, 20);
            this.chkCaduca.TabIndex = 5;
            this.chkCaduca.Text = "¿Caduca?";
            this.chkCaduca.UseVisualStyleBackColor = true;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(285, 134);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.TabIndex = 6;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(285, 176);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 7;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(6, 226);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(367, 69);
            this.lstLista.TabIndex = 10;
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(7, 210);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(0, 13);
            this.lblCompra.TabIndex = 11;
            // 
            // frmCargaDeDatosEnLaAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 299);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.chkCaduca);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.mrcLugar);
            this.Name = "frmCargaDeDatosEnLaAlacena";
            this.Text = "Cargar productos en la alacena";
            this.Load += new System.EventHandler(this.frmCargaDeDatosEnLaAlacena_Load);
            this.mrcLugar.ResumeLayout(false);
            this.mrcLugar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcLugar;
        private System.Windows.Forms.RadioButton optLimpieza;
        private System.Windows.Forms.RadioButton optAlacena;
        private System.Windows.Forms.RadioButton optMedicamentos;
        private System.Windows.Forms.RadioButton optBaño;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.RadioButton optHeladera;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.CheckBox chkCaduca;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Label lblCompra;
    }
}