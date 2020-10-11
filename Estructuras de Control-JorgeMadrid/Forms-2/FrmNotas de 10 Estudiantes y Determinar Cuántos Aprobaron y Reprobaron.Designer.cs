namespace Estructuras_de_Control_JorgeMadrid.Forms_2
{
    partial class FrmNotas_de_10_Estudiantes_y_Determinar_Cuántos_Aprobaron_y_Reprobaron
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
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LsbCondicion = new System.Windows.Forms.ListBox();
            this.LsbCalif = new System.Windows.Forms.ListBox();
            this.LsbEstudiantes = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TxtNotas = new System.Windows.Forms.TextBox();
            this.TxtNombreE = new System.Windows.Forms.TextBox();
            this.LblCalificacion = new System.Windows.Forms.Label();
            this.LblNombreE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAprobaron = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtReprobaron = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.BtnLimpiar.Location = new System.Drawing.Point(409, 574);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(114, 35);
            this.BtnLimpiar.TabIndex = 27;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Silver;
            this.BtnSalir.Location = new System.Drawing.Point(540, 574);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(114, 35);
            this.BtnSalir.TabIndex = 26;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LsbCondicion
            // 
            this.LsbCondicion.FormattingEnabled = true;
            this.LsbCondicion.ItemHeight = 19;
            this.LsbCondicion.Location = new System.Drawing.Point(445, 288);
            this.LsbCondicion.Name = "LsbCondicion";
            this.LsbCondicion.Size = new System.Drawing.Size(148, 156);
            this.LsbCondicion.TabIndex = 25;
            // 
            // LsbCalif
            // 
            this.LsbCalif.FormattingEnabled = true;
            this.LsbCalif.ItemHeight = 19;
            this.LsbCalif.Location = new System.Drawing.Point(290, 288);
            this.LsbCalif.Name = "LsbCalif";
            this.LsbCalif.Size = new System.Drawing.Size(149, 156);
            this.LsbCalif.TabIndex = 24;
            // 
            // LsbEstudiantes
            // 
            this.LsbEstudiantes.FormattingEnabled = true;
            this.LsbEstudiantes.ItemHeight = 19;
            this.LsbEstudiantes.Location = new System.Drawing.Point(31, 288);
            this.LsbEstudiantes.Name = "LsbEstudiantes";
            this.LsbEstudiantes.Size = new System.Drawing.Size(254, 156);
            this.LsbEstudiantes.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(445, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 37);
            this.label6.TabIndex = 22;
            this.label6.Text = "CONDICIÓN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(291, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 37);
            this.label5.TabIndex = 21;
            this.label5.Text = "NOTAS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(31, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "NOMBRE DEL ESTUDIANTE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnIngresar.Location = new System.Drawing.Point(519, 168);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(114, 44);
            this.BtnIngresar.TabIndex = 19;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TxtNotas
            // 
            this.TxtNotas.Location = new System.Drawing.Point(378, 176);
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.Size = new System.Drawing.Size(120, 27);
            this.TxtNotas.TabIndex = 18;
            // 
            // TxtNombreE
            // 
            this.TxtNombreE.Location = new System.Drawing.Point(376, 131);
            this.TxtNombreE.Name = "TxtNombreE";
            this.TxtNombreE.Size = new System.Drawing.Size(235, 27);
            this.TxtNombreE.TabIndex = 17;
            // 
            // LblCalificacion
            // 
            this.LblCalificacion.AutoSize = true;
            this.LblCalificacion.Location = new System.Drawing.Point(31, 179);
            this.LblCalificacion.Name = "LblCalificacion";
            this.LblCalificacion.Size = new System.Drawing.Size(280, 19);
            this.LblCalificacion.TabIndex = 16;
            this.LblCalificacion.Text = "Ingresar Nota del Estudiante #1:";
            // 
            // LblNombreE
            // 
            this.LblNombreE.AutoSize = true;
            this.LblNombreE.Location = new System.Drawing.Point(31, 134);
            this.LblNombreE.Name = "LblNombreE";
            this.LblNombreE.Size = new System.Drawing.Size(305, 19);
            this.LblNombreE.TabIndex = 15;
            this.LblNombreE.Text = "Ingresar Nombre del Estudiante #1:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(151, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 58);
            this.label1.TabIndex = 14;
            this.label1.Text = "Calcular las Notas de 10 Estudiantes y Cuantos Aprobaron o Reprobaron:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtAprobaron
            // 
            this.TxtAprobaron.Location = new System.Drawing.Point(349, 468);
            this.TxtAprobaron.Name = "TxtAprobaron";
            this.TxtAprobaron.Size = new System.Drawing.Size(120, 27);
            this.TxtAprobaron.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cantidad de Estudiantes Aprobados:";
            // 
            // TxtReprobaron
            // 
            this.TxtReprobaron.Location = new System.Drawing.Point(349, 500);
            this.TxtReprobaron.Name = "TxtReprobaron";
            this.TxtReprobaron.Size = new System.Drawing.Size(120, 27);
            this.TxtReprobaron.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cantidad de Estudiates Reprobados:";
            // 
            // FrmNotas_de_10_Estudiantes_y_Determinar_Cuántos_Aprobaron_y_Reprobaron
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(666, 621);
            this.ControlBox = false;
            this.Controls.Add(this.TxtReprobaron);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAprobaron);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LsbCondicion);
            this.Controls.Add(this.LsbCalif);
            this.Controls.Add(this.LsbEstudiantes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtNotas);
            this.Controls.Add(this.TxtNombreE);
            this.Controls.Add(this.LblCalificacion);
            this.Controls.Add(this.LblNombreE);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmNotas_de_10_Estudiantes_y_Determinar_Cuántos_Aprobaron_y_Reprobaron";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas 10 Estudiantes y Cuántos Aprobaron o Reprobaron";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ListBox LsbCondicion;
        private System.Windows.Forms.ListBox LsbCalif;
        private System.Windows.Forms.ListBox LsbEstudiantes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.TextBox TxtNombreE;
        private System.Windows.Forms.Label LblCalificacion;
        private System.Windows.Forms.Label LblNombreE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAprobaron;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtReprobaron;
        private System.Windows.Forms.Label label3;
    }
}