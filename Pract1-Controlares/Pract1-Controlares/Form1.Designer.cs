namespace Pract1_Controlares
{
    partial class Form1
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
            this.BTN_Clean = new System.Windows.Forms.Button();
            this.lbl_Mostrar = new System.Windows.Forms.Label();
            this.TBT_A = new System.Windows.Forms.TextBox();
            this.TBT_M = new System.Windows.Forms.TextBox();
            this.TBT_D = new System.Windows.Forms.TextBox();
            this.btn_Fin = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.lbl_Ano = new System.Windows.Forms.Label();
            this.lbl_Mes = new System.Windows.Forms.Label();
            this.lbl_Dia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Clean
            // 
            this.BTN_Clean.Location = new System.Drawing.Point(267, 106);
            this.BTN_Clean.Name = "BTN_Clean";
            this.BTN_Clean.Size = new System.Drawing.Size(75, 23);
            this.BTN_Clean.TabIndex = 25;
            this.BTN_Clean.Text = "Limpiar";
            this.BTN_Clean.UseVisualStyleBackColor = true;
            this.BTN_Clean.Click += new System.EventHandler(this.BTN_Clean_Click);
            // 
            // lbl_Mostrar
            // 
            this.lbl_Mostrar.AutoSize = true;
            this.lbl_Mostrar.Location = new System.Drawing.Point(264, 55);
            this.lbl_Mostrar.Name = "lbl_Mostrar";
            this.lbl_Mostrar.Size = new System.Drawing.Size(66, 13);
            this.lbl_Mostrar.TabIndex = 24;
            this.lbl_Mostrar.Text = "La fecha es:";
            // 
            // TBT_A
            // 
            this.TBT_A.Location = new System.Drawing.Point(117, 155);
            this.TBT_A.Name = "TBT_A";
            this.TBT_A.Size = new System.Drawing.Size(100, 20);
            this.TBT_A.TabIndex = 23;
            // 
            // TBT_M
            // 
            this.TBT_M.Location = new System.Drawing.Point(117, 90);
            this.TBT_M.Name = "TBT_M";
            this.TBT_M.Size = new System.Drawing.Size(100, 20);
            this.TBT_M.TabIndex = 22;
            // 
            // TBT_D
            // 
            this.TBT_D.Location = new System.Drawing.Point(117, 34);
            this.TBT_D.Name = "TBT_D";
            this.TBT_D.Size = new System.Drawing.Size(100, 20);
            this.TBT_D.TabIndex = 21;
            // 
            // btn_Fin
            // 
            this.btn_Fin.Location = new System.Drawing.Point(267, 158);
            this.btn_Fin.Name = "btn_Fin";
            this.btn_Fin.Size = new System.Drawing.Size(75, 23);
            this.btn_Fin.TabIndex = 20;
            this.btn_Fin.Text = "Salir";
            this.btn_Fin.UseVisualStyleBackColor = true;
            this.btn_Fin.Click += new System.EventHandler(this.btn_Fin_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(91, 214);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mostrar.TabIndex = 19;
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // lbl_Ano
            // 
            this.lbl_Ano.AutoSize = true;
            this.lbl_Ano.Location = new System.Drawing.Point(46, 158);
            this.lbl_Ano.Name = "lbl_Ano";
            this.lbl_Ano.Size = new System.Drawing.Size(26, 13);
            this.lbl_Ano.TabIndex = 18;
            this.lbl_Ano.Text = "Año";
            // 
            // lbl_Mes
            // 
            this.lbl_Mes.AutoSize = true;
            this.lbl_Mes.Location = new System.Drawing.Point(46, 93);
            this.lbl_Mes.Name = "lbl_Mes";
            this.lbl_Mes.Size = new System.Drawing.Size(27, 13);
            this.lbl_Mes.TabIndex = 17;
            this.lbl_Mes.Text = "Mes";
            // 
            // lbl_Dia
            // 
            this.lbl_Dia.AutoSize = true;
            this.lbl_Dia.Location = new System.Drawing.Point(46, 37);
            this.lbl_Dia.Name = "lbl_Dia";
            this.lbl_Dia.Size = new System.Drawing.Size(23, 13);
            this.lbl_Dia.TabIndex = 16;
            this.lbl_Dia.Text = "Dia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.BTN_Clean);
            this.Controls.Add(this.lbl_Mostrar);
            this.Controls.Add(this.TBT_A);
            this.Controls.Add(this.TBT_M);
            this.Controls.Add(this.TBT_D);
            this.Controls.Add(this.btn_Fin);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.lbl_Ano);
            this.Controls.Add(this.lbl_Mes);
            this.Controls.Add(this.lbl_Dia);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Pract1-Controles Programados por: Tomas Vezga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_Clean;
        private System.Windows.Forms.Label lbl_Mostrar;
        private System.Windows.Forms.TextBox TBT_A;
        private System.Windows.Forms.TextBox TBT_M;
        private System.Windows.Forms.TextBox TBT_D;
        private System.Windows.Forms.Button btn_Fin;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Label lbl_Ano;
        private System.Windows.Forms.Label lbl_Mes;
        private System.Windows.Forms.Label lbl_Dia;
    }
}

