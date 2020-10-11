namespace Estructuras_de_Control_JorgeMadrid.Forms_2
{
    partial class FrmLeer_Descripción__Cantidad_y_Precio_Unitario_de_10_Productos
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
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LsbPrec = new System.Windows.Forms.ListBox();
            this.LsbCant = new System.Windows.Forms.ListBox();
            this.LsbDescripcion = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TxtCantidadP = new System.Windows.Forms.TextBox();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.LblCantPro = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblPrecUni = new System.Windows.Forms.Label();
            this.TxtPrecioU = new System.Windows.Forms.TextBox();
            this.TxtPagar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LsbMonto = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(233, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURA COMERCIAL MADRID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.BtnLimpiar.Location = new System.Drawing.Point(494, 588);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(114, 35);
            this.BtnLimpiar.TabIndex = 26;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Silver;
            this.BtnSalir.Location = new System.Drawing.Point(623, 588);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(114, 35);
            this.BtnSalir.TabIndex = 25;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LsbPrec
            // 
            this.LsbPrec.FormattingEnabled = true;
            this.LsbPrec.ItemHeight = 19;
            this.LsbPrec.Location = new System.Drawing.Point(467, 359);
            this.LsbPrec.Name = "LsbPrec";
            this.LsbPrec.Size = new System.Drawing.Size(121, 156);
            this.LsbPrec.TabIndex = 24;
            // 
            // LsbCant
            // 
            this.LsbCant.FormattingEnabled = true;
            this.LsbCant.ItemHeight = 19;
            this.LsbCant.Location = new System.Drawing.Point(349, 359);
            this.LsbCant.Name = "LsbCant";
            this.LsbCant.Size = new System.Drawing.Size(112, 156);
            this.LsbCant.TabIndex = 23;
            // 
            // LsbDescripcion
            // 
            this.LsbDescripcion.FormattingEnabled = true;
            this.LsbDescripcion.ItemHeight = 19;
            this.LsbDescripcion.Location = new System.Drawing.Point(20, 359);
            this.LsbDescripcion.Name = "LsbDescripcion";
            this.LsbDescripcion.Size = new System.Drawing.Size(324, 156);
            this.LsbDescripcion.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(466, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 37);
            this.label6.TabIndex = 21;
            this.label6.Text = "PRECIO U.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(349, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 37);
            this.label5.TabIndex = 20;
            this.label5.Text = "CANTIDAD";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(20, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 37);
            this.label4.TabIndex = 19;
            this.label4.Text = "DESCRIPCIÓN DEL PRODUCTO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnIngresar.Location = new System.Drawing.Point(519, 188);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(114, 54);
            this.BtnIngresar.TabIndex = 18;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TxtCantidadP
            // 
            this.TxtCantidadP.Location = new System.Drawing.Point(373, 174);
            this.TxtCantidadP.Name = "TxtCantidadP";
            this.TxtCantidadP.Size = new System.Drawing.Size(118, 27);
            this.TxtCantidadP.TabIndex = 17;
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(373, 129);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(267, 27);
            this.TxtProducto.TabIndex = 16;
            // 
            // LblCantPro
            // 
            this.LblCantPro.AutoSize = true;
            this.LblCantPro.Location = new System.Drawing.Point(16, 179);
            this.LblCantPro.Name = "LblCantPro";
            this.LblCantPro.Size = new System.Drawing.Size(296, 19);
            this.LblCantPro.TabIndex = 15;
            this.LblCantPro.Text = "Ingresar la Cantidad de Producto:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(16, 132);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(353, 19);
            this.LblDescripcion.TabIndex = 14;
            this.LblDescripcion.Text = "Ingresar La Descripción del Producto #1:";
            // 
            // LblPrecUni
            // 
            this.LblPrecUni.AutoSize = true;
            this.LblPrecUni.Location = new System.Drawing.Point(16, 225);
            this.LblPrecUni.Name = "LblPrecUni";
            this.LblPrecUni.Size = new System.Drawing.Size(239, 19);
            this.LblPrecUni.TabIndex = 27;
            this.LblPrecUni.Text = "Ingresar el Precio Unitario:";
            // 
            // TxtPrecioU
            // 
            this.TxtPrecioU.Location = new System.Drawing.Point(373, 222);
            this.TxtPrecioU.Name = "TxtPrecioU";
            this.TxtPrecioU.Size = new System.Drawing.Size(118, 27);
            this.TxtPrecioU.TabIndex = 28;
            // 
            // TxtPagar
            // 
            this.TxtPagar.Location = new System.Drawing.Point(594, 518);
            this.TxtPagar.Name = "TxtPagar";
            this.TxtPagar.Size = new System.Drawing.Size(122, 27);
            this.TxtPagar.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(20, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(568, 27);
            this.label3.TabIndex = 29;
            this.label3.Text = "EL TOTAL A PAGAR ES:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LsbMonto
            // 
            this.LsbMonto.FormattingEnabled = true;
            this.LsbMonto.ItemHeight = 19;
            this.LsbMonto.Location = new System.Drawing.Point(594, 359);
            this.LsbMonto.Name = "LsbMonto";
            this.LsbMonto.Size = new System.Drawing.Size(121, 156);
            this.LsbMonto.TabIndex = 32;
            this.LsbMonto.SelectedIndexChanged += new System.EventHandler(this.LsbMonto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(593, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 37);
            this.label2.TabIndex = 31;
            this.label2.Text = "MONTO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLeer_Descripción__Cantidad_y_Precio_Unitario_de_10_Productos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(749, 635);
            this.ControlBox = false;
            this.Controls.Add(this.LsbMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPrecioU);
            this.Controls.Add(this.LblPrecUni);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LsbPrec);
            this.Controls.Add(this.LsbCant);
            this.Controls.Add(this.LsbDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtCantidadP);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.LblCantPro);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmLeer_Descripción__Cantidad_y_Precio_Unitario_de_10_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descripción Cantidad y Precio Unitario de 10 Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ListBox LsbPrec;
        private System.Windows.Forms.ListBox LsbCant;
        private System.Windows.Forms.ListBox LsbDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox TxtCantidadP;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label LblCantPro;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblPrecUni;
        private System.Windows.Forms.TextBox TxtPrecioU;
        private System.Windows.Forms.TextBox TxtPagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LsbMonto;
        private System.Windows.Forms.Label label2;
    }
}