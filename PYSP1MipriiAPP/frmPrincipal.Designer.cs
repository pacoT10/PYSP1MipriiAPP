namespace PYSP1MipriiAPP
{
    partial class frmPrincipal
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
            this.cmdAlacena = new System.Windows.Forms.Button();
            this.cmdGastos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAlacena
            // 
            this.cmdAlacena.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAlacena.Location = new System.Drawing.Point(12, 12);
            this.cmdAlacena.Name = "cmdAlacena";
            this.cmdAlacena.Size = new System.Drawing.Size(320, 94);
            this.cmdAlacena.TabIndex = 0;
            this.cmdAlacena.Text = "Alacena";
            this.cmdAlacena.UseVisualStyleBackColor = true;
            this.cmdAlacena.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdGastos
            // 
            this.cmdGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGastos.Location = new System.Drawing.Point(12, 135);
            this.cmdGastos.Name = "cmdGastos";
            this.cmdGastos.Size = new System.Drawing.Size(320, 97);
            this.cmdGastos.TabIndex = 1;
            this.cmdGastos.Text = "Gastos";
            this.cmdGastos.UseVisualStyleBackColor = true;
            this.cmdGastos.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 248);
            this.Controls.Add(this.cmdGastos);
            this.Controls.Add(this.cmdAlacena);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAlacena;
        private System.Windows.Forms.Button cmdGastos;
    }
}