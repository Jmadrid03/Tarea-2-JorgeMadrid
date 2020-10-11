namespace Estructuras_de_Control_JorgeMadrid.Forms_2
{
    partial class FrmMostrar_los_Múltiplo_de_5_que_hay_entre_0_y_300
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
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mostrar Los Números Multiplos de 5 Que Hay Entre 0 y 300:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(50, 129);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(134, 49);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Mostrar Múltiplos";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(50, 217);
            this.TxtResultado.Multiline = true;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResultado.Size = new System.Drawing.Size(398, 99);
            this.TxtResultado.TabIndex = 2;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(368, 339);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(118, 36);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(228, 339);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(118, 36);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmMostrar_los_Múltiplo_de_5_que_hay_entre_0_y_300
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(498, 387);
            this.ControlBox = false;
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmMostrar_los_Múltiplo_de_5_que_hay_entre_0_y_300";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar los Múltiplo de 5 que hay entre 0 y 300";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}