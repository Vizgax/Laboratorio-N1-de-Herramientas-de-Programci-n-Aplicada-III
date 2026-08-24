namespace Pract2_Descuentos
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
            this.lbl_VFin = new System.Windows.Forms.Label();
            this.lbl_Desc_Porc = new System.Windows.Forms.Label();
            this.lbl_Desc_Din = new System.Windows.Forms.Label();
            this.lbl_VVenta = new System.Windows.Forms.Label();
            this.txt_Desc_Din = new System.Windows.Forms.TextBox();
            this.txt_Desc_Porc = new System.Windows.Forms.TextBox();
            this.txt_VFin = new System.Windows.Forms.TextBox();
            this.txt_VVenta = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_VFin
            // 
            this.lbl_VFin.AutoSize = true;
            this.lbl_VFin.Location = new System.Drawing.Point(35, 190);
            this.lbl_VFin.Name = "lbl_VFin";
            this.lbl_VFin.Size = new System.Drawing.Size(56, 13);
            this.lbl_VFin.TabIndex = 21;
            this.lbl_VFin.Text = "Valor Final";
            this.lbl_VFin.UseWaitCursor = true;
            // 
            // lbl_Desc_Porc
            // 
            this.lbl_Desc_Porc.AutoSize = true;
            this.lbl_Desc_Porc.Location = new System.Drawing.Point(35, 133);
            this.lbl_Desc_Porc.Name = "lbl_Desc_Porc";
            this.lbl_Desc_Porc.Size = new System.Drawing.Size(70, 13);
            this.lbl_Desc_Porc.TabIndex = 20;
            this.lbl_Desc_Porc.Text = "Descuento %";
            this.lbl_Desc_Porc.UseWaitCursor = true;
            // 
            // lbl_Desc_Din
            // 
            this.lbl_Desc_Din.AutoSize = true;
            this.lbl_Desc_Din.Location = new System.Drawing.Point(35, 99);
            this.lbl_Desc_Din.Name = "lbl_Desc_Din";
            this.lbl_Desc_Din.Size = new System.Drawing.Size(68, 13);
            this.lbl_Desc_Din.TabIndex = 19;
            this.lbl_Desc_Din.Text = "Descuento $";
            this.lbl_Desc_Din.UseWaitCursor = true;
            // 
            // lbl_VVenta
            // 
            this.lbl_VVenta.AutoSize = true;
            this.lbl_VVenta.Location = new System.Drawing.Point(35, 38);
            this.lbl_VVenta.Name = "lbl_VVenta";
            this.lbl_VVenta.Size = new System.Drawing.Size(62, 13);
            this.lbl_VVenta.TabIndex = 18;
            this.lbl_VVenta.Text = "Valor Venta";
            this.lbl_VVenta.UseWaitCursor = true;
            // 
            // txt_Desc_Din
            // 
            this.txt_Desc_Din.Enabled = false;
            this.txt_Desc_Din.Location = new System.Drawing.Point(154, 96);
            this.txt_Desc_Din.Name = "txt_Desc_Din";
            this.txt_Desc_Din.Size = new System.Drawing.Size(100, 20);
            this.txt_Desc_Din.TabIndex = 17;
            this.txt_Desc_Din.UseWaitCursor = true;
            // 
            // txt_Desc_Porc
            // 
            this.txt_Desc_Porc.Enabled = false;
            this.txt_Desc_Porc.Location = new System.Drawing.Point(154, 130);
            this.txt_Desc_Porc.Name = "txt_Desc_Porc";
            this.txt_Desc_Porc.Size = new System.Drawing.Size(100, 20);
            this.txt_Desc_Porc.TabIndex = 16;
            this.txt_Desc_Porc.UseWaitCursor = true;
            // 
            // txt_VFin
            // 
            this.txt_VFin.Enabled = false;
            this.txt_VFin.Location = new System.Drawing.Point(154, 188);
            this.txt_VFin.Name = "txt_VFin";
            this.txt_VFin.Size = new System.Drawing.Size(100, 20);
            this.txt_VFin.TabIndex = 15;
            this.txt_VFin.UseWaitCursor = true;
            // 
            // txt_VVenta
            // 
            this.txt_VVenta.Location = new System.Drawing.Point(154, 35);
            this.txt_VVenta.Name = "txt_VVenta";
            this.txt_VVenta.Size = new System.Drawing.Size(100, 20);
            this.txt_VVenta.TabIndex = 14;
            this.txt_VVenta.UseWaitCursor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(304, 168);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 13;
            this.btn_Exit.Text = "Salir";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Clean
            // 
            this.btn_Clean.Location = new System.Drawing.Point(304, 123);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(75, 23);
            this.btn_Clean.TabIndex = 12;
            this.btn_Clean.Text = "Limpiar";
            this.btn_Clean.UseVisualStyleBackColor = true;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click_1);
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(304, 50);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(75, 23);
            this.btn_Calc.TabIndex = 11;
            this.btn_Calc.Text = "Calcular";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 254);
            this.Controls.Add(this.lbl_VFin);
            this.Controls.Add(this.lbl_Desc_Porc);
            this.Controls.Add(this.lbl_Desc_Din);
            this.Controls.Add(this.lbl_VVenta);
            this.Controls.Add(this.txt_Desc_Din);
            this.Controls.Add(this.txt_Desc_Porc);
            this.Controls.Add(this.txt_VFin);
            this.Controls.Add(this.txt_VVenta);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clean);
            this.Controls.Add(this.btn_Calc);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pract2 - Descuento - Programado por: Tomas Vezga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_VFin;
        private System.Windows.Forms.Label lbl_Desc_Porc;
        private System.Windows.Forms.Label lbl_Desc_Din;
        private System.Windows.Forms.Label lbl_VVenta;
        private System.Windows.Forms.TextBox txt_Desc_Din;
        private System.Windows.Forms.TextBox txt_Desc_Porc;
        private System.Windows.Forms.TextBox txt_VFin;
        private System.Windows.Forms.TextBox txt_VVenta;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.Button btn_Calc;
    }
}

