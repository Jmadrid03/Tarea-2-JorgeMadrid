namespace Estructuras_de_Control_JorgeMadrid.Forms_2
{
    partial class FrmMostrar_en_una_Tabla_de_Multiplicar_un_Número
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
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LsbTabla = new System.Windows.Forms.ListBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(149, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mostrar un Número de la Tabla de Multiplicación:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar un Número de la Tabla de Multiplicar:";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(443, 119);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(105, 27);
            this.TxtNumero.TabIndex = 2;
            this.TxtNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LsbTabla
            // 
            this.LsbTabla.FormattingEnabled = true;
            this.LsbTabla.ItemHeight = 19;
            this.LsbTabla.Location = new System.Drawing.Point(16, 218);
            this.LsbTabla.Name = "LsbTabla";
            this.LsbTabla.Size = new System.Drawing.Size(263, 213);
            this.LsbTabla.TabIndex = 3;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnMostrar.Location = new System.Drawing.Point(338, 168);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(131, 43);
            this.BtnMostrar.TabIndex = 4;
            this.BtnMostrar.Text = "Mostrar ";
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSalir.Location = new System.Drawing.Point(409, 399);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(116, 32);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnLimpiar.Location = new System.Drawing.Point(409, 349);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(116, 32);
            this.BtnLimpiar.TabIndex = 6;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(21, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "TABLA DE MULTIPLICAR:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMostrar_en_una_Tabla_de_Multiplicar_un_Número
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(563, 446);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.LsbTabla);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmMostrar_en_una_Tabla_de_Multiplicar_un_Número";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar una Tabla de Multiplicar de un Número";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.ListBox LsbTabla;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label3;
    }
}