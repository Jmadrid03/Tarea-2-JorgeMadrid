namespace Estructuras_de_Control_JorgeMadrid.Forms_2
{
    partial class FrmCalcular_el_Promedio_de_10_Estudiantes_si_Aprobo_o_Repobo
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
            this.LblNombreE = new System.Windows.Forms.Label();
            this.LblCalificacion = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCalificacion = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LsbEstudiantes = new System.Windows.Forms.ListBox();
            this.LsbCalif = new System.Windows.Forms.ListBox();
            this.LsbCondicion = new System.Windows.Forms.ListBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(157, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular el Promedio de 10 Estudiantes Si Aprobaron o Reprobaron:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNombreE
            // 
            this.LblNombreE.AutoSize = true;
            this.LblNombreE.Location = new System.Drawing.Point(37, 135);
            this.LblNombreE.Name = "LblNombreE";
            this.LblNombreE.Size = new System.Drawing.Size(305, 19);
            this.LblNombreE.TabIndex = 1;
            this.LblNombreE.Text = "Ingresar Nombre del Estudiante #1:";
            // 
            // LblCalificacion
            // 
            this.LblCalificacion.AutoSize = true;
            this.LblCalificacion.Location = new System.Drawing.Point(37, 180);
            this.LblCalificacion.Name = "LblCalificacion";
            this.LblCalificacion.Size = new System.Drawing.Size(341, 19);
            this.LblCalificacion.TabIndex = 2;
            this.LblCalificacion.Text = "Ingresar Calificación del Estudiante #1:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(382, 132);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(235, 27);
            this.TxtNombre.TabIndex = 3;
            // 
            // TxtCalificacion
            // 
            this.TxtCalificacion.Location = new System.Drawing.Point(384, 177);
            this.TxtCalificacion.Name = "TxtCalificacion";
            this.TxtCalificacion.Size = new System.Drawing.Size(120, 27);
            this.TxtCalificacion.TabIndex = 4;
            this.TxtCalificacion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnIngresar.Location = new System.Drawing.Point(525, 169);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(114, 44);
            this.BtnIngresar.TabIndex = 5;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(37, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "NOMBRE DEL ESTUDIANTE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(297, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "CALIFICACIÓN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(451, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 37);
            this.label6.TabIndex = 8;
            this.label6.Text = "CONDICIÓN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LsbEstudiantes
            // 
            this.LsbEstudiantes.FormattingEnabled = true;
            this.LsbEstudiantes.ItemHeight = 19;
            this.LsbEstudiantes.Location = new System.Drawing.Point(37, 289);
            this.LsbEstudiantes.Name = "LsbEstudiantes";
            this.LsbEstudiantes.Size = new System.Drawing.Size(254, 156);
            this.LsbEstudiantes.TabIndex = 9;
            // 
            // LsbCalif
            // 
            this.LsbCalif.FormattingEnabled = true;
            this.LsbCalif.ItemHeight = 19;
            this.LsbCalif.Location = new System.Drawing.Point(296, 289);
            this.LsbCalif.Name = "LsbCalif";
            this.LsbCalif.Size = new System.Drawing.Size(149, 156);
            this.LsbCalif.TabIndex = 10;
            // 
            // LsbCondicion
            // 
            this.LsbCondicion.FormattingEnabled = true;
            this.LsbCondicion.ItemHeight = 19;
            this.LsbCondicion.Location = new System.Drawing.Point(451, 289);
            this.LsbCondicion.Name = "LsbCondicion";
            this.LsbCondicion.Size = new System.Drawing.Size(148, 156);
            this.LsbCondicion.TabIndex = 11;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Silver;
            this.BtnSalir.Location = new System.Drawing.Point(535, 481);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(114, 35);
            this.BtnSalir.TabIndex = 12;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.BtnLimpiar.Location = new System.Drawing.Point(404, 481);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(114, 35);
            this.BtnLimpiar.TabIndex = 13;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmCalcular_el_Promedio_de_10_Estudiantes_si_Aprobo_o_Repobo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(661, 528);
            this.ControlBox = false;
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LsbCondicion);
            this.Controls.Add(this.LsbCalif);
            this.Controls.Add(this.LsbEstudiantes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtCalificacion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblCalificacion);
            this.Controls.Add(this.LblNombreE);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmCalcular_el_Promedio_de_10_Estudiantes_si_Aprobo_o_Repobo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promedio de 10 Estudiantes Si Aprobo o Repobo";
            this.Load += new System.EventHandler(this.FrmCalcular_el_Promedio_de_10_Estudiantes_si_Aprobo_o_Repobo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNombreE;
        private System.Windows.Forms.Label LblCalificacion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCalificacion;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox LsbEstudiantes;
        private System.Windows.Forms.ListBox LsbCalif;
        private System.Windows.Forms.ListBox LsbCondicion;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}