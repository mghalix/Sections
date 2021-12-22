namespace GUI_Section
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.On = new System.Windows.Forms.RadioButton();
            this.Op = new System.Windows.Forms.RadioButton();
            this.Bn = new System.Windows.Forms.RadioButton();
            this.Bp = new System.Windows.Forms.RadioButton();
            this.Ap = new System.Windows.Forms.RadioButton();
            this.An = new System.Windows.Forms.RadioButton();
            this.ABn = new System.Windows.Forms.RadioButton();
            this.ABp = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Mono", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Mono", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Museo Sans Rounded 700", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(94, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Museo Sans Rounded 700", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(94, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(15, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.On);
            this.groupBox2.Controls.Add(this.Op);
            this.groupBox2.Controls.Add(this.Bn);
            this.groupBox2.Controls.Add(this.Bp);
            this.groupBox2.Controls.Add(this.Ap);
            this.groupBox2.Controls.Add(this.An);
            this.groupBox2.Controls.Add(this.ABn);
            this.groupBox2.Controls.Add(this.ABp);
            this.groupBox2.Location = new System.Drawing.Point(261, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 106);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Blood Type";
            // 
            // On
            // 
            this.On.AutoSize = true;
            this.On.Location = new System.Drawing.Point(258, 60);
            this.On.Name = "On";
            this.On.Size = new System.Drawing.Size(40, 19);
            this.On.TabIndex = 7;
            this.On.Text = "O-";
            this.On.UseVisualStyleBackColor = true;
            // 
            // Op
            // 
            this.Op.AutoSize = true;
            this.Op.Location = new System.Drawing.Point(255, 24);
            this.Op.Name = "Op";
            this.Op.Size = new System.Drawing.Size(42, 19);
            this.Op.TabIndex = 6;
            this.Op.Text = "O+";
            this.Op.UseVisualStyleBackColor = true;
            // 
            // Bn
            // 
            this.Bn.AutoSize = true;
            this.Bn.Location = new System.Drawing.Point(174, 60);
            this.Bn.Name = "Bn";
            this.Bn.Size = new System.Drawing.Size(37, 19);
            this.Bn.TabIndex = 5;
            this.Bn.Text = "B-";
            this.Bn.UseVisualStyleBackColor = true;
            // 
            // Bp
            // 
            this.Bp.AutoSize = true;
            this.Bp.Location = new System.Drawing.Point(171, 24);
            this.Bp.Name = "Bp";
            this.Bp.Size = new System.Drawing.Size(39, 19);
            this.Bp.TabIndex = 4;
            this.Bp.Text = "B+";
            this.Bp.UseVisualStyleBackColor = true;
            // 
            // Ap
            // 
            this.Ap.AutoSize = true;
            this.Ap.Location = new System.Drawing.Point(90, 24);
            this.Ap.Name = "Ap";
            this.Ap.Size = new System.Drawing.Size(40, 19);
            this.Ap.TabIndex = 3;
            this.Ap.Text = "A+";
            this.Ap.UseVisualStyleBackColor = true;
            // 
            // An
            // 
            this.An.AutoSize = true;
            this.An.Location = new System.Drawing.Point(93, 64);
            this.An.Name = "An";
            this.An.Size = new System.Drawing.Size(38, 19);
            this.An.TabIndex = 2;
            this.An.Text = "A-";
            this.An.UseVisualStyleBackColor = true;
            // 
            // ABn
            // 
            this.ABn.AutoSize = true;
            this.ABn.Location = new System.Drawing.Point(6, 64);
            this.ABn.Name = "ABn";
            this.ABn.Size = new System.Drawing.Size(45, 19);
            this.ABn.TabIndex = 1;
            this.ABn.Text = "AB-";
            this.ABn.UseVisualStyleBackColor = true;
            // 
            // ABp
            // 
            this.ABp.AutoSize = true;
            this.ABp.Location = new System.Drawing.Point(6, 24);
            this.ABp.Name = "ABp";
            this.ABp.Size = new System.Drawing.Size(47, 19);
            this.ABp.TabIndex = 0;
            this.ABp.Text = "AB+";
            this.ABp.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(375, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.Font = new System.Drawing.Font("Roboto Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(279, 162);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(285, 159);
            this.textBox3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(592, 333);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Museo Sans Rounded 700", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Personal details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton On;
        private System.Windows.Forms.RadioButton Op;
        private System.Windows.Forms.RadioButton Bn;
        private System.Windows.Forms.RadioButton Bp;
        private System.Windows.Forms.RadioButton Ap;
        private System.Windows.Forms.RadioButton An;
        private System.Windows.Forms.RadioButton ABn;
        private System.Windows.Forms.RadioButton ABp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

