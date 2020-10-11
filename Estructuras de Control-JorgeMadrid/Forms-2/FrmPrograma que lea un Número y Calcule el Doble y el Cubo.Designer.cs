namespace Estructuras_de_Control_JorgeMadrid.Forms_2
{
    partial class FrmPrograma_que_lea_un_Número_y_Calcule_el_Doble_y_el_Cubo
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
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtPrimerN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(206, 311);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(105, 44);
            this.BtnLimpiar.TabIndex = 27;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(320, 311);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(105, 44);
            this.BtnSalir.TabIndex = 26;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtResultado
            // 
            this.TxtResultado.BackColor = System.Drawing.Color.White;
            this.TxtResultado.Location = new System.Drawing.Point(265, 243);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(127, 27);
            this.TxtResultado.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "El Resultados es:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(81, 176);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(105, 44);
            this.BtnCalcular.TabIndex = 23;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtPrimerN
            // 
            this.TxtPrimerN.Location = new System.Drawing.Point(265, 128);
            this.TxtPrimerN.Name = "TxtPrimerN";
            this.TxtPrimerN.Size = new System.Drawing.Size(127, 27);
            this.TxtPrimerN.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ingrese un Número:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 65);
            this.label1.TabIndex = 20;
            this.label1.Text = "Determinar que un Número Calcule el Doble si es Mayor o Igual a 10 o en Caso Cont" +
    "rario el Cubo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrograma_que_lea_un_Número_y_Calcule_el_Doble_y_el_Cubo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(437, 367);
            this.ControlBox = false;
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtPrimerN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmPrograma_que_lea_un_Número_y_Calcule_el_Doble_y_el_Cubo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa que lea un Número y Calcule el Doble y el Cubo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtPrimerN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}