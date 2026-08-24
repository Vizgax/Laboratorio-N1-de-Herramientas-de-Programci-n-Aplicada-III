namespace Pract3_Calculadora
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
            this.TXT_Num1 = new System.Windows.Forms.TextBox();
            this.TXT_Num2 = new System.Windows.Forms.TextBox();
            this.TXT_Resultado = new System.Windows.Forms.TextBox();
            this.LBL_Signo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GB_Op = new System.Windows.Forms.GroupBox();
            this.RB_Div = new System.Windows.Forms.RadioButton();
            this.RB_Mult = new System.Windows.Forms.RadioButton();
            this.RB_Rest = new System.Windows.Forms.RadioButton();
            this.RB_Sum = new System.Windows.Forms.RadioButton();
            this.BTN_Calc = new System.Windows.Forms.Button();
            this.BTN_Clean = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.GB_Op.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT_Num1
            // 
            this.TXT_Num1.Location = new System.Drawing.Point(19, 36);
            this.TXT_Num1.Name = "TXT_Num1";
            this.TXT_Num1.Size = new System.Drawing.Size(100, 20);
            this.TXT_Num1.TabIndex = 0;
            // 
            // TXT_Num2
            // 
            this.TXT_Num2.Location = new System.Drawing.Point(197, 36);
            this.TXT_Num2.Name = "TXT_Num2";
            this.TXT_Num2.Size = new System.Drawing.Size(100, 20);
            this.TXT_Num2.TabIndex = 1;
            // 
            // TXT_Resultado
            // 
            this.TXT_Resultado.Enabled = false;
            this.TXT_Resultado.Location = new System.Drawing.Point(393, 36);
            this.TXT_Resultado.Name = "TXT_Resultado";
            this.TXT_Resultado.Size = new System.Drawing.Size(100, 20);
            this.TXT_Resultado.TabIndex = 2;
            // 
            // LBL_Signo
            // 
            this.LBL_Signo.AutoSize = true;
            this.LBL_Signo.Location = new System.Drawing.Point(153, 39);
            this.LBL_Signo.Name = "LBL_Signo";
            this.LBL_Signo.Size = new System.Drawing.Size(13, 13);
            this.LBL_Signo.TabIndex = 3;
            this.LBL_Signo.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Signo";
            // 
            // GB_Op
            // 
            this.GB_Op.Controls.Add(this.RB_Div);
            this.GB_Op.Controls.Add(this.RB_Mult);
            this.GB_Op.Controls.Add(this.RB_Rest);
            this.GB_Op.Controls.Add(this.RB_Sum);
            this.GB_Op.Location = new System.Drawing.Point(20, 101);
            this.GB_Op.Name = "GB_Op";
            this.GB_Op.Size = new System.Drawing.Size(129, 194);
            this.GB_Op.TabIndex = 6;
            this.GB_Op.TabStop = false;
            this.GB_Op.Text = "Operaciones";
            // 
            // RB_Div
            // 
            this.RB_Div.AutoSize = true;
            this.RB_Div.Location = new System.Drawing.Point(31, 149);
            this.RB_Div.Name = "RB_Div";
            this.RB_Div.Size = new System.Drawing.Size(60, 17);
            this.RB_Div.TabIndex = 4;
            this.RB_Div.TabStop = true;
            this.RB_Div.Text = "Divison";
            this.RB_Div.UseVisualStyleBackColor = true;
            // 
            // RB_Mult
            // 
            this.RB_Mult.AutoSize = true;
            this.RB_Mult.Location = new System.Drawing.Point(31, 115);
            this.RB_Mult.Name = "RB_Mult";
            this.RB_Mult.Size = new System.Drawing.Size(89, 17);
            this.RB_Mult.TabIndex = 3;
            this.RB_Mult.TabStop = true;
            this.RB_Mult.Text = "Multiplicacion";
            this.RB_Mult.UseVisualStyleBackColor = true;
            // 
            // RB_Rest
            // 
            this.RB_Rest.AutoSize = true;
            this.RB_Rest.Location = new System.Drawing.Point(31, 76);
            this.RB_Rest.Name = "RB_Rest";
            this.RB_Rest.Size = new System.Drawing.Size(53, 17);
            this.RB_Rest.TabIndex = 2;
            this.RB_Rest.TabStop = true;
            this.RB_Rest.Text = "Resta";
            this.RB_Rest.UseVisualStyleBackColor = true;
            // 
            // RB_Sum
            // 
            this.RB_Sum.AutoSize = true;
            this.RB_Sum.Location = new System.Drawing.Point(31, 39);
            this.RB_Sum.Name = "RB_Sum";
            this.RB_Sum.Size = new System.Drawing.Size(52, 17);
            this.RB_Sum.TabIndex = 1;
            this.RB_Sum.TabStop = true;
            this.RB_Sum.Text = "Suma";
            this.RB_Sum.UseVisualStyleBackColor = true;
            // 
            // BTN_Calc
            // 
            this.BTN_Calc.Location = new System.Drawing.Point(296, 107);
            this.BTN_Calc.Name = "BTN_Calc";
            this.BTN_Calc.Size = new System.Drawing.Size(75, 23);
            this.BTN_Calc.TabIndex = 0;
            this.BTN_Calc.Text = "Calcular";
            this.BTN_Calc.UseVisualStyleBackColor = true;
            this.BTN_Calc.Click += new System.EventHandler(this.BTN_Calc_Click);
            // 
            // BTN_Clean
            // 
            this.BTN_Clean.Location = new System.Drawing.Point(296, 177);
            this.BTN_Clean.Name = "BTN_Clean";
            this.BTN_Clean.Size = new System.Drawing.Size(75, 23);
            this.BTN_Clean.TabIndex = 7;
            this.BTN_Clean.Text = "Limpiar";
            this.BTN_Clean.UseVisualStyleBackColor = true;
            this.BTN_Clean.Click += new System.EventHandler(this.BTN_Clean_Click);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Location = new System.Drawing.Point(296, 250);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(75, 23);
            this.BTN_Exit.TabIndex = 8;
            this.BTN_Exit.Text = "Salir";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 341);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.BTN_Clean);
            this.Controls.Add(this.GB_Op);
            this.Controls.Add(this.BTN_Calc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBL_Signo);
            this.Controls.Add(this.TXT_Resultado);
            this.Controls.Add(this.TXT_Num2);
            this.Controls.Add(this.TXT_Num1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.GB_Op.ResumeLayout(false);
            this.GB_Op.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Num1;
        private System.Windows.Forms.TextBox TXT_Num2;
        private System.Windows.Forms.TextBox TXT_Resultado;
        private System.Windows.Forms.Label LBL_Signo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GB_Op;
        private System.Windows.Forms.RadioButton RB_Div;
        private System.Windows.Forms.RadioButton RB_Mult;
        private System.Windows.Forms.RadioButton RB_Rest;
        private System.Windows.Forms.RadioButton RB_Sum;
        private System.Windows.Forms.Button BTN_Calc;
        private System.Windows.Forms.Button BTN_Clean;
        private System.Windows.Forms.Button BTN_Exit;
    }
}

