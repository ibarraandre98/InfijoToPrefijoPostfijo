namespace InfijoToPrefijoPostfijo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInfija = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrefija = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPostfija = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCalcularInfija = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPostfijaInfija = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrefijaInfija = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResultadoInfija = new System.Windows.Forms.TextBox();
            this.rbPrefija = new System.Windows.Forms.RadioButton();
            this.rbPostfija = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtInfija
            // 
            this.txtInfija.Location = new System.Drawing.Point(100, 64);
            this.txtInfija.Name = "txtInfija";
            this.txtInfija.Size = new System.Drawing.Size(419, 20);
            this.txtInfija.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Infija:";
            // 
            // txtPrefija
            // 
            this.txtPrefija.Location = new System.Drawing.Point(100, 103);
            this.txtPrefija.Name = "txtPrefija";
            this.txtPrefija.Size = new System.Drawing.Size(419, 20);
            this.txtPrefija.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prefija:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Postfija:";
            // 
            // txtPostfija
            // 
            this.txtPostfija.Location = new System.Drawing.Point(100, 142);
            this.txtPostfija.Name = "txtPostfija";
            this.txtPostfija.Size = new System.Drawing.Size(419, 20);
            this.txtPostfija.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(206, 186);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(199, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular Infija a (Prefija,PostFija)";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnCalcularInfija
            // 
            this.btnCalcularInfija.Location = new System.Drawing.Point(206, 360);
            this.btnCalcularInfija.Name = "btnCalcularInfija";
            this.btnCalcularInfija.Size = new System.Drawing.Size(199, 23);
            this.btnCalcularInfija.TabIndex = 11;
            this.btnCalcularInfija.Text = "Calcular (Prefija,PostFija) a Infija";
            this.btnCalcularInfija.UseVisualStyleBackColor = true;
            this.btnCalcularInfija.Click += new System.EventHandler(this.BtnCalcularInfija_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Postfija:";
            // 
            // txtPostfijaInfija
            // 
            this.txtPostfijaInfija.Location = new System.Drawing.Point(100, 266);
            this.txtPostfijaInfija.Name = "txtPostfijaInfija";
            this.txtPostfijaInfija.Size = new System.Drawing.Size(419, 20);
            this.txtPostfijaInfija.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prefija:";
            // 
            // txtPrefijaInfija
            // 
            this.txtPrefijaInfija.Location = new System.Drawing.Point(100, 227);
            this.txtPrefijaInfija.Name = "txtPrefijaInfija";
            this.txtPrefijaInfija.Size = new System.Drawing.Size(419, 20);
            this.txtPrefijaInfija.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Infija:";
            // 
            // txtResultadoInfija
            // 
            this.txtResultadoInfija.Location = new System.Drawing.Point(100, 304);
            this.txtResultadoInfija.Name = "txtResultadoInfija";
            this.txtResultadoInfija.Size = new System.Drawing.Size(419, 20);
            this.txtResultadoInfija.TabIndex = 12;
            // 
            // rbPrefija
            // 
            this.rbPrefija.AutoSize = true;
            this.rbPrefija.Checked = true;
            this.rbPrefija.Location = new System.Drawing.Point(206, 330);
            this.rbPrefija.Name = "rbPrefija";
            this.rbPrefija.Size = new System.Drawing.Size(54, 17);
            this.rbPrefija.TabIndex = 14;
            this.rbPrefija.TabStop = true;
            this.rbPrefija.Text = "Prefija";
            this.rbPrefija.UseVisualStyleBackColor = true;
            // 
            // rbPostfija
            // 
            this.rbPostfija.AutoSize = true;
            this.rbPostfija.Location = new System.Drawing.Point(320, 330);
            this.rbPostfija.Name = "rbPostfija";
            this.rbPostfija.Size = new System.Drawing.Size(59, 17);
            this.rbPostfija.TabIndex = 15;
            this.rbPostfija.Text = "Postfija";
            this.rbPostfija.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbPostfija);
            this.Controls.Add(this.rbPrefija);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResultadoInfija);
            this.Controls.Add(this.btnCalcularInfija);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPostfijaInfija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrefijaInfija);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPostfija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrefija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfija);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrefija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPostfija;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCalcularInfija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPostfijaInfija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrefijaInfija;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResultadoInfija;
        private System.Windows.Forms.RadioButton rbPrefija;
        private System.Windows.Forms.RadioButton rbPostfija;
    }
}

