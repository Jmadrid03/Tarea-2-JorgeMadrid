namespace Estructuras_de_Control_JorgeMadrid.Forms_2
{
    partial class FrmPlantear_un_Programa_que_Ordene_2_Números_Ascendentemente
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
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.TxtPrimerN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSegundoN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAscen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(413, 356);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(98, 42);
            this.BtnSalir.TabIndex = 39;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(288, 356);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(98, 42);
            this.BtnLimpiar.TabIndex = 38;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(118, 220);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(125, 40);
            this.BtnMostrar.TabIndex = 35;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // TxtPrimerN
            // 
            this.TxtPrimerN.Location = new System.Drawing.Point(321, 144);
            this.TxtPrimerN.Name = "TxtPrimerN";
            this.TxtPrimerN.Size = new System.Drawing.Size(116, 27);
            this.TxtPrimerN.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ingresar el Primer Número:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 57);
            this.label1.TabIndex = 32;
            this.label1.Text = "Programa que al Ingresar 2 Números Los Ordene Ascendentemente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSegundoN
            // 
            this.TxtSegundoN.Location = new System.Drawing.Point(321, 179);
            this.TxtSegundoN.Name = "TxtSegundoN";
            this.TxtSegundoN.Size = new System.Drawing.Size(116, 27);
            this.TxtSegundoN.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ingresar el Segundo Número:";
            // 
            // TxtDescen
            // 
            this.TxtDescen.BackColor = System.Drawing.Color.White;
            this.TxtDescen.Location = new System.Drawing.Point(271, 281);
            this.TxtDescen.Name = "TxtDescen";
            this.TxtDescen.ReadOnly = true;
            this.TxtDescen.Size = new System.Drawing.Size(78, 27);
            this.TxtDescen.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "El Orden Ascendente es:";
            // 
            // TxtAscen
            // 
            this.TxtAscen.BackColor = System.Drawing.Color.White;
            this.TxtAscen.Location = new System.Drawing.Point(355, 281);
            this.TxtAscen.Name = "TxtAscen";
            this.TxtAscen.ReadOnly = true;
            this.TxtAscen.Size = new System.Drawing.Size(78, 27);
            this.TxtAscen.TabIndex = 44;
            // 
            // FrmPlantear_un_Programa_que_Ordene_2_Números_Ascendentemente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(523, 410);
            this.ControlBox = false;
            this.Controls.Add(this.TxtAscen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDescen);
            this.Controls.Add(this.TxtSegundoN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.TxtPrimerN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmPlantear_un_Programa_que_Ordene_2_Números_Ascendentemente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa que Ordena 2 Números Ascendentemente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.TextBox TxtPrimerN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSegundoN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAscen;
    }
}