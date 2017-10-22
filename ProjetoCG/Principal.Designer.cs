namespace ProjetoCG
{
    partial class Principal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLarguraDeTela = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.px1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.py1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.px2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.py2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(243, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(724, 469);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Posição X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Posição Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coordenadas do Pixel";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Plotar Pixel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLarguraDeTela
            // 
            this.txtLarguraDeTela.AccessibleName = "";
            this.txtLarguraDeTela.AutoSize = true;
            this.txtLarguraDeTela.Location = new System.Drawing.Point(191, 22);
            this.txtLarguraDeTela.Name = "txtLarguraDeTela";
            this.txtLarguraDeTela.Size = new System.Drawing.Size(0, 13);
            this.txtLarguraDeTela.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(22, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 496);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 161);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.px2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.py2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.px1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.py1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(3, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 201);
            this.panel3.TabIndex = 8;
            // 
            // px1
            // 
            this.px1.Location = new System.Drawing.Point(97, 42);
            this.px1.Name = "px1";
            this.px1.Size = new System.Drawing.Size(68, 20);
            this.px1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Desenhar reta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Coordenadas da reta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Posição X0";
            // 
            // py1
            // 
            this.py1.Location = new System.Drawing.Point(97, 73);
            this.py1.Name = "py1";
            this.py1.Size = new System.Drawing.Size(68, 20);
            this.py1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Posição Y0";
            // 
            // px2
            // 
            this.px2.Location = new System.Drawing.Point(97, 104);
            this.px2.Name = "px2";
            this.px2.Size = new System.Drawing.Size(68, 20);
            this.px2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Posição X1";
            // 
            // py2
            // 
            this.py2.Location = new System.Drawing.Point(97, 135);
            this.py2.Name = "py2";
            this.py2.Size = new System.Drawing.Size(68, 20);
            this.py2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Posição Y1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLarguraDeTela);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Principal";
            this.Text = "Plotar Pixel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtLarguraDeTela;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox px2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox py2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox px1;
        private System.Windows.Forms.TextBox py1;
    }
}

