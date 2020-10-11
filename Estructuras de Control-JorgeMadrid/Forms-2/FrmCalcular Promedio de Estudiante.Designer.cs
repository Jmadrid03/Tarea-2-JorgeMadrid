namespace Estructuras_de_Control_JorgeMadrid.Forms_2
{
    partial class FrmCalcular_Promedio_de_Estudiante
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
            this.TxtPrimeracal = new System.Windows.Forms.TextBox();
            this.TxtSegundacal = new System.Windows.Forms.TextBox();
            this.TxtTerceracal = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtPromedio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtCondición = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular el Promedio de Estudiante:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar la Primera Calificación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar la Segunda Calificación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingresar la Tercera Calificación:";
            // 
            // TxtPrimeracal
            // 
            this.TxtPrimeracal.Location = new System.Drawing.Point(326, 98);
            this.TxtPrimeracal.Name = "TxtPrimeracal";
            this.TxtPrimeracal.Size = new System.Drawing.Size(147, 27);
            this.TxtPrimeracal.TabIndex = 4;
            // 
            // TxtSegundacal
            // 
            this.TxtSegundacal.Location = new System.Drawing.Point(326, 138);
            this.TxtSegundacal.Name = "TxtSegundacal";
            this.TxtSegundacal.Size = new System.Drawing.Size(147, 27);
            this.TxtSegundacal.TabIndex = 5;
            // 
            // TxtTerceracal
            // 
            this.TxtTerceracal.Location = new System.Drawing.Point(326, 178);
            this.TxtTerceracal.Name = "TxtTerceracal";
            this.TxtTerceracal.Size = new System.Drawing.Size(147, 27);
            this.TxtTerceracal.TabIndex = 6;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(100, 229);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(120, 39);
            this.BtnCalcular.TabIndex = 7;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtPromedio
            // 
            this.TxtPromedio.BackColor = System.Drawing.Color.White;
            this.TxtPromedio.Location = new System.Drawing.Point(326, 292);
            this.TxtPromedio.Name = "TxtPromedio";
            this.TxtPromedio.ReadOnly = true;
            this.TxtPromedio.Size = new System.Drawing.Size(147, 27);
            this.TxtPromedio.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "El Promedio del Estudiante es:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(253, 429);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(120, 39);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(381, 429);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(120, 39);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtCondición
            // 
            this.TxtCondición.BackColor = System.Drawing.Color.White;
            this.TxtCondición.Location = new System.Drawing.Point(326, 348);
            this.TxtCondición.Name = "TxtCondición";
            this.TxtCondición.ReadOnly = true;
            this.TxtCondición.Size = new System.Drawing.Size(147, 27);
            this.TxtCondición.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "La Condición del Estudiante Esta:";
            // 
            // FrmCalcular_Promedio_de_Estudiante
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(513, 480);
            this.ControlBox = false;
            this.Controls.Add(this.TxtCondición);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtPromedio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtTerceracal);
            this.Controls.Add(this.TxtSegundacal);
            this.Controls.Add(this.TxtPrimeracal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmCalcular_Promedio_de_Estudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Promedio de Estudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrimeracal;
        private System.Windows.Forms.TextBox TxtSegundacal;
        private System.Windows.Forms.TextBox TxtTerceracal;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtPromedio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtCondición;
        private System.Windows.Forms.Label label6;
    }
}