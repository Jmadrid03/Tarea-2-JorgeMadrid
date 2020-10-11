namespace Estructuras_de_Control_JorgeMadrid.Forms_2
{
    partial class FrmCalcular_la_Edad_Promedio_de_10_Personas
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LsbEdad = new System.Windows.Forms.ListBox();
            this.LsbPersona = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TxtEdadP = new System.Windows.Forms.TextBox();
            this.TxtNombreP = new System.Windows.Forms.TextBox();
            this.LblEdadPr = new System.Windows.Forms.Label();
            this.LblNombreP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Silver;
            this.BtnSalir.Location = new System.Drawing.Point(508, 496);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(114, 35);
            this.BtnSalir.TabIndex = 26;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LsbEdad
            // 
            this.LsbEdad.FormattingEnabled = true;
            this.LsbEdad.ItemHeight = 19;
            this.LsbEdad.Location = new System.Drawing.Point(362, 275);
            this.LsbEdad.Name = "LsbEdad";
            this.LsbEdad.Size = new System.Drawing.Size(149, 156);
            this.LsbEdad.TabIndex = 24;
            // 
            // LsbPersona
            // 
            this.LsbPersona.FormattingEnabled = true;
            this.LsbPersona.ItemHeight = 19;
            this.LsbPersona.Location = new System.Drawing.Point(103, 275);
            this.LsbPersona.Name = "LsbPersona";
            this.LsbPersona.Size = new System.Drawing.Size(254, 156);
            this.LsbPersona.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(363, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 37);
            this.label5.TabIndex = 21;
            this.label5.Text = "EDAD";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(103, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "NOMBRE DE LA PERSONA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnIngresar.Location = new System.Drawing.Point(471, 170);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(124, 44);
            this.BtnIngresar.TabIndex = 19;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TxtEdadP
            // 
            this.TxtEdadP.Location = new System.Drawing.Point(337, 179);
            this.TxtEdadP.Name = "TxtEdadP";
            this.TxtEdadP.Size = new System.Drawing.Size(120, 27);
            this.TxtEdadP.TabIndex = 18;
            // 
            // TxtNombreP
            // 
            this.TxtNombreP.Location = new System.Drawing.Point(337, 134);
            this.TxtNombreP.Name = "TxtNombreP";
            this.TxtNombreP.Size = new System.Drawing.Size(258, 27);
            this.TxtNombreP.TabIndex = 17;
            // 
            // LblEdadPr
            // 
            this.LblEdadPr.AutoSize = true;
            this.LblEdadPr.Location = new System.Drawing.Point(35, 182);
            this.LblEdadPr.Name = "LblEdadPr";
            this.LblEdadPr.Size = new System.Drawing.Size(296, 19);
            this.LblEdadPr.TabIndex = 16;
            this.LblEdadPr.Text = "Ingresar la Edad de la Persona #1:";
            // 
            // LblNombreP
            // 
            this.LblNombreP.AutoSize = true;
            this.LblNombreP.Location = new System.Drawing.Point(35, 137);
            this.LblNombreP.Name = "LblNombreP";
            this.LblNombreP.Size = new System.Drawing.Size(296, 19);
            this.LblNombreP.TabIndex = 15;
            this.LblNombreP.Text = "Ingresar Nombre de la Persona #1:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(195, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 58);
            this.label1.TabIndex = 14;
            this.label1.Text = "Calcular la Edad Promedio de 10 Personas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtResultado
            // 
            this.TxtResultado.BackColor = System.Drawing.Color.White;
            this.TxtResultado.Location = new System.Drawing.Point(435, 445);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(120, 27);
            this.TxtResultado.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "El Promedio de las Edades de las Personas es:";
            // 
            // FrmCalcular_la_Edad_Promedio_de_10_Personas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(634, 543);
            this.ControlBox = false;
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LsbEdad);
            this.Controls.Add(this.LsbPersona);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtEdadP);
            this.Controls.Add(this.TxtNombreP);
            this.Controls.Add(this.LblEdadPr);
            this.Controls.Add(this.LblNombreP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmCalcular_la_Edad_Promedio_de_10_Personas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edad Promedio de 10 Personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ListBox LsbEdad;
        private System.Windows.Forms.ListBox LsbPersona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox TxtEdadP;
        private System.Windows.Forms.TextBox TxtNombreP;
        private System.Windows.Forms.Label LblEdadPr;
        private System.Windows.Forms.Label LblNombreP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label label2;
    }
}