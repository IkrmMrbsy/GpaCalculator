namespace tugaslatihan
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
            this.txtModule = new System.Windows.Forms.TextBox();
            this.btsubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nutest = new System.Windows.Forms.NumericUpDown();
            this.nuassigment = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lbhasil = new System.Windows.Forms.Label();
            this.lbgrade = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nucv = new System.Windows.Forms.NumericUpDown();
            this.btgpa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nutest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuassigment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nucv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModule
            // 
            this.txtModule.Location = new System.Drawing.Point(202, 111);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(385, 26);
            this.txtModule.TabIndex = 0;
            this.txtModule.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btsubmit
            // 
            this.btsubmit.BackColor = System.Drawing.Color.Aqua;
            this.btsubmit.ForeColor = System.Drawing.Color.Black;
            this.btsubmit.Location = new System.Drawing.Point(202, 419);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(385, 48);
            this.btsubmit.TabIndex = 3;
            this.btsubmit.Text = "Submit";
            this.btsubmit.UseVisualStyleBackColor = false;
            this.btsubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(244, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menghitung Nilai Akhir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(56, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modul Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(56, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modul Test";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(56, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Assigment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(616, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hasil :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nutest
            // 
            this.nutest.Location = new System.Drawing.Point(202, 196);
            this.nutest.Name = "nutest";
            this.nutest.Size = new System.Drawing.Size(385, 26);
            this.nutest.TabIndex = 10;
            // 
            // nuassigment
            // 
            this.nuassigment.Location = new System.Drawing.Point(202, 274);
            this.nuassigment.Name = "nuassigment";
            this.nuassigment.Size = new System.Drawing.Size(385, 26);
            this.nuassigment.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(605, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Grade :";
            // 
            // lbhasil
            // 
            this.lbhasil.AutoSize = true;
            this.lbhasil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbhasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbhasil.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbhasil.Location = new System.Drawing.Point(693, 217);
            this.lbhasil.Name = "lbhasil";
            this.lbhasil.Size = new System.Drawing.Size(2, 27);
            this.lbhasil.TabIndex = 14;
            // 
            // lbgrade
            // 
            this.lbgrade.AutoSize = true;
            this.lbgrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbgrade.ForeColor = System.Drawing.Color.Red;
            this.lbgrade.Location = new System.Drawing.Point(693, 291);
            this.lbgrade.Name = "lbgrade";
            this.lbgrade.Size = new System.Drawing.Size(2, 27);
            this.lbgrade.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(56, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Credit Value";
            // 
            // nucv
            // 
            this.nucv.Location = new System.Drawing.Point(202, 351);
            this.nucv.Name = "nucv";
            this.nucv.Size = new System.Drawing.Size(385, 26);
            this.nucv.TabIndex = 17;
            this.nucv.ValueChanged += new System.EventHandler(this.nucv_ValueChanged);
            // 
            // btgpa
            // 
            this.btgpa.BackColor = System.Drawing.Color.MintCream;
            this.btgpa.ForeColor = System.Drawing.Color.Black;
            this.btgpa.Location = new System.Drawing.Point(202, 491);
            this.btgpa.Name = "btgpa";
            this.btgpa.Size = new System.Drawing.Size(385, 48);
            this.btgpa.TabIndex = 18;
            this.btgpa.Text = "GPA";
            this.btgpa.UseVisualStyleBackColor = false;
            this.btgpa.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 565);
            this.Controls.Add(this.btgpa);
            this.Controls.Add(this.nucv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbgrade);
            this.Controls.Add(this.lbhasil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nuassigment);
            this.Controls.Add(this.nutest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btsubmit);
            this.Controls.Add(this.txtModule);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackgroundImageLayoutChanged += new System.EventHandler(this.e);
            ((System.ComponentModel.ISupportInitialize)(this.nutest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuassigment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nucv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.Button btsubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nutest;
        private System.Windows.Forms.NumericUpDown nuassigment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbhasil;
        private System.Windows.Forms.Label lbgrade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nucv;
        private System.Windows.Forms.Button btgpa;
    }
}

