namespace Banka
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lblhesapno = new System.Windows.Forms.Label();
            this.lblnumara = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btngonder = new System.Windows.Forms.Button();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.mskhesapno = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numara:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC Kimlik No:";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(169, 21);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(64, 24);
            this.lbladsoyad.TabIndex = 4;
            this.lbladsoyad.Text = "NULL";
            // 
            // lblhesapno
            // 
            this.lblhesapno.AutoSize = true;
            this.lblhesapno.Location = new System.Drawing.Point(174, 61);
            this.lblhesapno.Name = "lblhesapno";
            this.lblhesapno.Size = new System.Drawing.Size(64, 24);
            this.lblhesapno.TabIndex = 5;
            this.lblhesapno.Text = "NULL";
            // 
            // lblnumara
            // 
            this.lblnumara.AutoSize = true;
            this.lblnumara.Location = new System.Drawing.Point(174, 101);
            this.lblnumara.Name = "lblnumara";
            this.lblnumara.Size = new System.Drawing.Size(64, 24);
            this.lblnumara.TabIndex = 6;
            this.lblnumara.Text = "NULL";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(174, 140);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(64, 24);
            this.lbltc.TabIndex = 7;
            this.lbltc.Text = "NULL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngonder);
            this.groupBox1.Controls.Add(this.txttutar);
            this.groupBox1.Controls.Add(this.mskhesapno);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 228);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havale";
            // 
            // btngonder
            // 
            this.btngonder.Location = new System.Drawing.Point(166, 150);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(127, 39);
            this.btngonder.TabIndex = 4;
            this.btngonder.Text = "Gönder";
            this.btngonder.UseVisualStyleBackColor = true;
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // txttutar
            // 
            this.txttutar.Location = new System.Drawing.Point(142, 101);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(183, 30);
            this.txttutar.TabIndex = 3;
            // 
            // mskhesapno
            // 
            this.mskhesapno.Location = new System.Drawing.Point(142, 49);
            this.mskhesapno.Mask = "000000";
            this.mskhesapno.Name = "mskhesapno";
            this.mskhesapno.Size = new System.Drawing.Size(183, 30);
            this.mskhesapno.TabIndex = 2;
            this.mskhesapno.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tutar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hesap No:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Hareketlerim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(715, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.lblnumara);
            this.Controls.Add(this.lblhesapno);
            this.Controls.Add(this.lbladsoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Hesap";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lblhesapno;
        private System.Windows.Forms.Label lblnumara;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.MaskedTextBox mskhesapno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btngonder;
        private System.Windows.Forms.Button button1;
    }
}