﻿namespace PYSP1MipriiAPP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcIngreso = new System.Windows.Forms.GroupBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.mrcGastos = new System.Windows.Forms.GroupBox();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.lblOtrosgastos = new System.Windows.Forms.Label();
            this.txtOtrosgastos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mrcIngreso.SuspendLayout();
            this.mrcGastos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcIngreso
            // 
            this.mrcIngreso.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mrcIngreso.Controls.Add(this.txtDeposito);
            this.mrcIngreso.Controls.Add(this.lblDeposito);
            this.mrcIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcIngreso.Location = new System.Drawing.Point(6, 3);
            this.mrcIngreso.Name = "mrcIngreso";
            this.mrcIngreso.Size = new System.Drawing.Size(270, 72);
            this.mrcIngreso.TabIndex = 0;
            this.mrcIngreso.TabStop = false;
            this.mrcIngreso.Text = "Ingresos";
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(6, 16);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(84, 24);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Deposito";
            this.lblDeposito.Click += new System.EventHandler(this.Deposito_Click);
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(6, 43);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(143, 22);
            this.txtDeposito.TabIndex = 1;
            // 
            // mrcGastos
            // 
            this.mrcGastos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mrcGastos.Controls.Add(this.txtOtrosgastos);
            this.mrcGastos.Controls.Add(this.lblOtrosgastos);
            this.mrcGastos.Controls.Add(this.txtComida);
            this.mrcGastos.Controls.Add(this.lblComida);
            this.mrcGastos.Controls.Add(this.txtImpuesto);
            this.mrcGastos.Controls.Add(this.lblImpuestos);
            this.mrcGastos.Controls.Add(this.txtAlquiler);
            this.mrcGastos.Controls.Add(this.lblAlquiler);
            this.mrcGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastos.Location = new System.Drawing.Point(6, 81);
            this.mrcGastos.Name = "mrcGastos";
            this.mrcGastos.Size = new System.Drawing.Size(270, 255);
            this.mrcGastos.TabIndex = 1;
            this.mrcGastos.TabStop = false;
            this.mrcGastos.Text = "Gastos";
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquiler.Location = new System.Drawing.Point(76, 14);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(84, 25);
            this.lblAlquiler.TabIndex = 0;
            this.lblAlquiler.Text = "Alquiler";
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(52, 42);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(143, 22);
            this.txtAlquiler.TabIndex = 1;
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.Location = new System.Drawing.Point(71, 67);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(110, 25);
            this.lblImpuestos.TabIndex = 2;
            this.lblImpuestos.Text = "Impuestos";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(52, 95);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(143, 22);
            this.txtImpuesto.TabIndex = 3;
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComida.Location = new System.Drawing.Point(71, 125);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(85, 25);
            this.lblComida.TabIndex = 4;
            this.lblComida.Text = "Comida";
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(52, 153);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(143, 22);
            this.txtComida.TabIndex = 5;
            // 
            // lblOtrosgastos
            // 
            this.lblOtrosgastos.AutoSize = true;
            this.lblOtrosgastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtrosgastos.Location = new System.Drawing.Point(61, 178);
            this.lblOtrosgastos.Name = "lblOtrosgastos";
            this.lblOtrosgastos.Size = new System.Drawing.Size(134, 25);
            this.lblOtrosgastos.TabIndex = 6;
            this.lblOtrosgastos.Text = "Otros gastos";
            // 
            // txtOtrosgastos
            // 
            this.txtOtrosgastos.Location = new System.Drawing.Point(52, 206);
            this.txtOtrosgastos.Name = "txtOtrosgastos";
            this.txtOtrosgastos.Size = new System.Drawing.Size(149, 22);
            this.txtOtrosgastos.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(169, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Saldo restante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "___________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(285, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mrcGastos);
            this.Controls.Add(this.mrcIngreso);
            this.Name = "Form1";
            this.Text = "Gasto Mensual";
            this.mrcIngreso.ResumeLayout(false);
            this.mrcIngreso.PerformLayout();
            this.mrcGastos.ResumeLayout(false);
            this.mrcGastos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcIngreso;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.GroupBox mrcGastos;
        private System.Windows.Forms.TextBox txtOtrosgastos;
        private System.Windows.Forms.Label lblOtrosgastos;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}

