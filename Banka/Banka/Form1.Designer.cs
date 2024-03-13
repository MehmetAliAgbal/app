namespace Banka
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.mskhesapno = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btngirisyap = new System.Windows.Forms.Button();
            this.lnkkayitol = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(201, 151);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(187, 30);
            this.txtsifre.TabIndex = 1;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // mskhesapno
            // 
            this.mskhesapno.Location = new System.Drawing.Point(201, 103);
            this.mskhesapno.Mask = "000000";
            this.mskhesapno.Name = "mskhesapno";
            this.mskhesapno.Size = new System.Drawing.Size(187, 30);
            this.mskhesapno.TabIndex = 2;
            this.mskhesapno.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // btngirisyap
            // 
            this.btngirisyap.Location = new System.Drawing.Point(201, 221);
            this.btngirisyap.Name = "btngirisyap";
            this.btngirisyap.Size = new System.Drawing.Size(136, 42);
            this.btngirisyap.TabIndex = 4;
            this.btngirisyap.Text = "Giriş Yap";
            this.btngirisyap.UseVisualStyleBackColor = true;
            this.btngirisyap.Click += new System.EventHandler(this.btngirisyap_Click);
            // 
            // lnkkayitol
            // 
            this.lnkkayitol.AutoSize = true;
            this.lnkkayitol.Location = new System.Drawing.Point(305, 184);
            this.lnkkayitol.Name = "lnkkayitol";
            this.lnkkayitol.Size = new System.Drawing.Size(83, 24);
            this.lnkkayitol.TabIndex = 5;
            this.lnkkayitol.TabStop = true;
            this.lnkkayitol.Text = "Kayıt Ol";
            this.lnkkayitol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkkayitol_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 351);
            this.Controls.Add(this.lnkkayitol);
            this.Controls.Add(this.btngirisyap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskhesapno);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox mskhesapno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngirisyap;
        private System.Windows.Forms.LinkLabel lnkkayitol;
    }
}

