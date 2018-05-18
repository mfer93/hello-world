namespace BestGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vsHuman = new System.Windows.Forms.RadioButton();
            this.vsComputer = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mayor = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.menor = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vsHuman);
            this.groupBox1.Controls.Add(this.vsComputer);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // vsHuman
            // 
            this.vsHuman.AutoSize = true;
            this.vsHuman.Location = new System.Drawing.Point(466, 40);
            this.vsHuman.Name = "vsHuman";
            this.vsHuman.Size = new System.Drawing.Size(121, 17);
            this.vsHuman.TabIndex = 1;
            this.vsHuman.TabStop = true;
            this.vsHuman.Text = "Adivinaré tu Número";
            this.vsHuman.UseVisualStyleBackColor = true;
            this.vsHuman.CheckedChanged += new System.EventHandler(this.vsHuman_CheckedChanged);
            // 
            // vsComputer
            // 
            this.vsComputer.AutoSize = true;
            this.vsComputer.Location = new System.Drawing.Point(115, 40);
            this.vsComputer.Name = "vsComputer";
            this.vsComputer.Size = new System.Drawing.Size(113, 17);
            this.vsComputer.TabIndex = 0;
            this.vsComputer.TabStop = true;
            this.vsComputer.Text = "Adivina mi Número";
            this.vsComputer.UseVisualStyleBackColor = true;
            this.vsComputer.CheckedChanged += new System.EventHandler(this.vsComputer_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.richTextBox2);
            this.groupBox3.Location = new System.Drawing.Point(348, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 389);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // mayor
            // 
            this.mayor.Location = new System.Drawing.Point(248, 19);
            this.mayor.Name = "mayor";
            this.mayor.Size = new System.Drawing.Size(75, 23);
            this.mayor.TabIndex = 6;
            this.mayor.Text = "Mayor";
            this.mayor.UseVisualStyleBackColor = true;
            this.mayor.Click += new System.EventHandler(this.mayor_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(138, 19);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(75, 23);
            this.igual.TabIndex = 5;
            this.igual.Text = "Correcto!";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // menor
            // 
            this.menor.Location = new System.Drawing.Point(16, 19);
            this.menor.Name = "menor";
            this.menor.Size = new System.Drawing.Size(75, 23);
            this.menor.TabIndex = 4;
            this.menor.Text = "Menor";
            this.menor.UseVisualStyleBackColor = true;
            this.menor.Click += new System.EventHandler(this.menor_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(22, 19);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(307, 247);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(15, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 389);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Is your Number?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(284, 247);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.menor);
            this.groupBox4.Controls.Add(this.mayor);
            this.groupBox4.Controls.Add(this.igual);
            this.groupBox4.Location = new System.Drawing.Point(6, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(343, 66);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 482);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Magic Number";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton vsHuman;
        private System.Windows.Forms.RadioButton vsComputer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button mayor;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button menor;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

