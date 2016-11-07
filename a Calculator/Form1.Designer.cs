namespace a_Calculator
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
            this.disp = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.bAc = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.benter = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disp
            // 
            this.disp.Location = new System.Drawing.Point(12, 12);
            this.disp.Multiline = true;
            this.disp.Name = "disp";
            this.disp.Size = new System.Drawing.Size(561, 59);
            this.disp.TabIndex = 0;
            this.disp.TextChanged += new System.EventHandler(this.disp_TextChanged);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(189, 235);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(384, 235);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 23);
            this.b3.TabIndex = 2;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(288, 235);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 23);
            this.b2.TabIndex = 3;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(189, 275);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(75, 23);
            this.b0.TabIndex = 4;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(288, 146);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(75, 23);
            this.b8.TabIndex = 7;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(384, 146);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(75, 23);
            this.b9.TabIndex = 6;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(189, 146);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(75, 23);
            this.b7.TabIndex = 5;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(288, 188);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(75, 23);
            this.b5.TabIndex = 10;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(384, 188);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(75, 23);
            this.b6.TabIndex = 9;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(189, 188);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 23);
            this.b4.TabIndex = 8;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // bAc
            // 
            this.bAc.Location = new System.Drawing.Point(12, 104);
            this.bAc.Name = "bAc";
            this.bAc.Size = new System.Drawing.Size(75, 23);
            this.bAc.TabIndex = 11;
            this.bAc.Text = "Ac";
            this.bAc.UseVisualStyleBackColor = true;
            this.bAc.Click += new System.EventHandler(this.bAc_Click);
            // 
            // bDel
            // 
            this.bDel.Location = new System.Drawing.Point(12, 146);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(75, 23);
            this.bDel.TabIndex = 12;
            this.bDel.Text = "Del";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // benter
            // 
            this.benter.Enabled = false;
            this.benter.Location = new System.Drawing.Point(384, 275);
            this.benter.Name = "benter";
            this.benter.Size = new System.Drawing.Size(75, 23);
            this.benter.TabIndex = 13;
            this.benter.Text = "=";
            this.benter.UseVisualStyleBackColor = true;
            this.benter.Click += new System.EventHandler(this.benter_Click);
            // 
            // bdot
            // 
            this.bdot.Location = new System.Drawing.Point(288, 275);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(75, 23);
            this.bdot.TabIndex = 14;
            this.bdot.Text = ".";
            this.bdot.UseVisualStyleBackColor = true;
            this.bdot.Click += new System.EventHandler(this.bdot_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.benter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 323);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.benter);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bAc);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.disp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox disp;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button bAc;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button benter;
        private System.Windows.Forms.Button bdot;
    }
}

