namespace Estructuras_de_Control_JorgeMadrid.Forms_2
{
    partial class FrmCalcular_el_Total_a_Pagar_por_una_Venta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtPreciou = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtDescto = new System.Windows.Forms.TextBox();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPagar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(152, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular el Total a Pagar de Ventas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar la Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingresar el Precio Unitario:";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(296, 121);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(201, 27);
            this.TxtProducto.TabIndex = 4;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(296, 152);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(116, 27);
            this.TxtCantidad.TabIndex = 5;
            // 
            // TxtPreciou
            // 
            this.TxtPreciou.Location = new System.Drawing.Point(296, 184);
            this.TxtPreciou.Name = "TxtPreciou";
            this.TxtPreciou.Size = new System.Drawing.Size(116, 27);
            this.TxtPreciou.TabIndex = 6;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(79, 231);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(137, 46);
            this.BtnCalcular.TabIndex = 7;
            this.BtnCalcular.Text = "Calular el Total";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtDescto
            // 
            this.TxtDescto.BackColor = System.Drawing.Color.White;
            this.TxtDescto.Location = new System.Drawing.Point(296, 335);
            this.TxtDescto.Name = "TxtDescto";
            this.TxtDescto.ReadOnly = true;
            this.TxtDescto.Size = new System.Drawing.Size(116, 27);
            this.TxtDescto.TabIndex = 11;
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.BackColor = System.Drawing.Color.White;
            this.TxtSubtotal.Location = new System.Drawing.Point(296, 303);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.ReadOnly = true;
            this.TxtSubtotal.Size = new System.Drawing.Size(116, 27);
            this.TxtSubtotal.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "El Descuento por la Venta es:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "El Sub-Total de la Venta es:";
            // 
            // TxtPagar
            // 
            this.TxtPagar.BackColor = System.Drawing.Color.White;
            this.TxtPagar.Location = new System.Drawing.Point(296, 369);
            this.TxtPagar.Name = "TxtPagar";
            this.TxtPagar.ReadOnly = true;
            this.TxtPagar.Size = new System.Drawing.Size(116, 27);
            this.TxtPagar.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "El Total a Pagar es:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(231, 432);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(137, 42);
            this.BtnLimpiar.TabIndex = 14;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(383, 432);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(137, 42);
            this.BtnSalir.TabIndex = 15;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmCalcular_el_Total_a_Pagar_por_una_Venta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(532, 486);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtPagar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtDescto);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtPreciou);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmCalcular_el_Total_a_Pagar_por_una_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total a Pagar por Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtPreciou;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtDescto;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
    }
}