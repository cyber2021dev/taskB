
namespace taskB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnforecolor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkbox2 = new System.Windows.Forms.CheckBox();
            this.checkbox1 = new System.Windows.Forms.CheckBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnfont = new System.Windows.Forms.Button();
            this.btnbackcolor = new System.Windows.Forms.Button();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnforecolor
            // 
            this.btnforecolor.Location = new System.Drawing.Point(24, 49);
            this.btnforecolor.Name = "btnforecolor";
            this.btnforecolor.Size = new System.Drawing.Size(116, 29);
            this.btnforecolor.TabIndex = 0;
            this.btnforecolor.Text = "Fore Color";
            this.btnforecolor.UseVisualStyleBackColor = true;
            this.btnforecolor.Click += new System.EventHandler(this.btnforecolor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkbox2);
            this.groupBox1.Controls.Add(this.checkbox1);
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btnfont);
            this.groupBox1.Controls.Add(this.btnbackcolor);
            this.groupBox1.Controls.Add(this.text2);
            this.groupBox1.Controls.Add(this.text1);
            this.groupBox1.Controls.Add(this.btnforecolor);
            this.groupBox1.Location = new System.Drawing.Point(48, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 330);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkbox2
            // 
            this.checkbox2.AutoSize = true;
            this.checkbox2.Location = new System.Drawing.Point(333, 115);
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(15, 14);
            this.checkbox2.TabIndex = 7;
            this.checkbox2.UseVisualStyleBackColor = true;
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Location = new System.Drawing.Point(36, 115);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(15, 14);
            this.checkbox1.TabIndex = 6;
            this.checkbox1.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(495, 49);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(116, 29);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // btnfont
            // 
            this.btnfont.Location = new System.Drawing.Point(346, 49);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(116, 29);
            this.btnfont.TabIndex = 4;
            this.btnfont.Text = "Font";
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // btnbackcolor
            // 
            this.btnbackcolor.Location = new System.Drawing.Point(179, 49);
            this.btnbackcolor.Name = "btnbackcolor";
            this.btnbackcolor.Size = new System.Drawing.Size(116, 29);
            this.btnbackcolor.TabIndex = 3;
            this.btnbackcolor.Text = "Back Color";
            this.btnbackcolor.UseVisualStyleBackColor = true;
            this.btnbackcolor.Click += new System.EventHandler(this.btnbackcolor_Click);
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(333, 135);
            this.text2.Multiline = true;
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(278, 161);
            this.text2.TabIndex = 2;
            this.text2.Text = "this is text2";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(36, 135);
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(278, 161);
            this.text1.TabIndex = 1;
            this.text1.Text = "this is text1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnforecolor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkbox2;
        private System.Windows.Forms.CheckBox checkbox1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.Button btnbackcolor;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

