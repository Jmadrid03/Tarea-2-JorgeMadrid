namespace Estructuras_de_Control_JorgeMadrid.Forms_2
{
    partial class FrmCalcular_el_Total_a_Pagar_en_una_Boleteria
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
            this.TxtPagar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(342, 310);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(98, 42);
            this.BtnSalir.TabIndex = 31;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(217, 310);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(98, 42);
            this.BtnLimpiar.TabIndex = 30;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxtPagar
            // 
            this.TxtPagar.BackColor = System.Drawing.Color.White;
            this.TxtPagar.Location = new System.Drawing.Point(292, 245);
            this.TxtPagar.Name = "TxtPagar";
            this.TxtPagar.ReadOnly = true;
            this.TxtPagar.Size = new System.Drawing.Size(116, 27);
            this.TxtPagar.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "El Total a Pagar es:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(75, 173);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(137, 46);
            this.BtnCalcular.TabIndex = 23;
            this.BtnCalcular.Text = "Calular el Total";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(292, 125);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(116, 27);
            this.TxtCantidad.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ingresar la Cantidad Boletos:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(117, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 66);
            this.label1.TabIndex = 16;
            this.label1.Text = "Calcular el Total a Pagar en una Boleteria:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCalcular_el_Total_a_Pagar_en_una_Boleteria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(452, 364);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtPagar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmCalcular_el_Total_a_Pagar_en_una_Boleteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total a Pagar en una Boleteria";
            this.Load += new System.EventHandler(this.FrmCalcular_el_Total_a_Pagar_en_una_Boleteria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox TxtPagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}