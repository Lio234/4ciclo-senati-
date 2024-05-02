namespace WindowsFormsApp1
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
            this.btn_calcular = new System.Windows.Forms.Button();
            this.TRIANGULOS = new System.Windows.Forms.Label();
            this.txt_ld1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ld2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ld3 = new System.Windows.Forms.TextBox();
            this.s = new System.Windows.Forms.Label();
            this.txt_existe = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.txt_perimetro = new System.Windows.Forms.TextBox();
            this.label_3 = new System.Windows.Forms.Label();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(162, 156);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // TRIANGULOS
            // 
            this.TRIANGULOS.AutoSize = true;
            this.TRIANGULOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRIANGULOS.Location = new System.Drawing.Point(108, 9);
            this.TRIANGULOS.Name = "TRIANGULOS";
            this.TRIANGULOS.Size = new System.Drawing.Size(192, 31);
            this.TRIANGULOS.TabIndex = 1;
            this.TRIANGULOS.Text = "TRIANGULOS";
            // 
            // txt_ld1
            // 
            this.txt_ld1.Location = new System.Drawing.Point(71, 60);
            this.txt_ld1.Name = "txt_ld1";
            this.txt_ld1.Size = new System.Drawing.Size(100, 20);
            this.txt_ld1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lado 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lado 2";
            // 
            // txt_ld2
            // 
            this.txt_ld2.Location = new System.Drawing.Point(254, 60);
            this.txt_ld2.Name = "txt_ld2";
            this.txt_ld2.Size = new System.Drawing.Size(100, 20);
            this.txt_ld2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lado 3";
            // 
            // txt_ld3
            // 
            this.txt_ld3.Location = new System.Drawing.Point(157, 107);
            this.txt_ld3.Name = "txt_ld3";
            this.txt_ld3.Size = new System.Drawing.Size(100, 20);
            this.txt_ld3.TabIndex = 6;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(25, 209);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(41, 13);
            this.s.TabIndex = 9;
            this.s.Text = "Existe?";
            // 
            // txt_existe
            // 
            this.txt_existe.Location = new System.Drawing.Point(71, 206);
            this.txt_existe.Name = "txt_existe";
            this.txt_existe.ReadOnly = true;
            this.txt_existe.Size = new System.Drawing.Size(100, 20);
            this.txt_existe.TabIndex = 8;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(12, 248);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(54, 13);
            this.a.TabIndex = 11;
            this.a.Text = "Perimetro:";
            // 
            // txt_perimetro
            // 
            this.txt_perimetro.Location = new System.Drawing.Point(72, 245);
            this.txt_perimetro.Name = "txt_perimetro";
            this.txt_perimetro.ReadOnly = true;
            this.txt_perimetro.Size = new System.Drawing.Size(100, 20);
            this.txt_perimetro.TabIndex = 10;
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Location = new System.Drawing.Point(198, 209);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(32, 13);
            this.label_3.TabIndex = 13;
            this.label_3.Text = "Area:";
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(236, 206);
            this.txt_area.Name = "txt_area";
            this.txt_area.ReadOnly = true;
            this.txt_area.Size = new System.Drawing.Size(100, 20);
            this.txt_area.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo:";
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(236, 245);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.ReadOnly = true;
            this.txt_tipo.Size = new System.Drawing.Size(100, 20);
            this.txt_tipo.TabIndex = 14;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(162, 288);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 16;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 344);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.a);
            this.Controls.Add(this.txt_perimetro);
            this.Controls.Add(this.s);
            this.Controls.Add(this.txt_existe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ld3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ld2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ld1);
            this.Controls.Add(this.TRIANGULOS);
            this.Controls.Add(this.btn_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label TRIANGULOS;
        private System.Windows.Forms.TextBox txt_ld1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ld2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ld3;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.TextBox txt_existe;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txt_perimetro;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Button btn_salir;
    }
}

