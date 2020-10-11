namespace Estructuras_de_Control_JorgeMadrid.Forms_2
{
    partial class FrmPlantear_un_Programa_que_Determine_el_Número_Menor_de_2_Números
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
            this.TxtPrimerN = new System.Windows.Forms.TextBox();
            this.TxtSegundoN = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(76, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa Que Determina el Número Menor de 2 Números:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar el Primer Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar el Segundo Número:";
            // 
            // TxtPrimerN
            // 
            this.TxtPrimerN.Location = new System.Drawing.Point(301, 120);
            this.TxtPrimerN.Name = "TxtPrimerN";
            this.TxtPrimerN.Size = new System.Drawing.Size(127, 27);
            this.TxtPrimerN.TabIndex = 3;
            // 
            // TxtSegundoN
            // 
            this.TxtSegundoN.Location = new System.Drawing.Point(301, 166);
            this.TxtSegundoN.Name = "TxtSegundoN";
            this.TxtSegundoN.Size = new System.Drawing.Size(127, 27);
            this.TxtSegundoN.TabIndex = 4;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(101, 212);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(105, 44);
            this.BtnCalcular.TabIndex = 5;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(301, 271);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(127, 27);
            this.TxtResultado.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "El Número Menor es:";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(348, 331);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(105, 44);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(227, 331);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(105, 44);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmPlantear_un_Programa_que_Determine_el_Número_Menor_de_2_Números
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(465, 387);
            this.ControlBox = false;
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtSegundoN);
            this.Controls.Add(this.TxtPrimerN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmPlantear_un_Programa_que_Determine_el_Número_Menor_de_2_Números";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantear un Programa que Determine el Número Menor de 2 Números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPrimerN;
        private System.Windows.Forms.TextBox TxtSegundoN;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}