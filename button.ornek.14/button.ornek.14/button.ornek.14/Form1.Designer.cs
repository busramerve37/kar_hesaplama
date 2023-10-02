namespace button.ornek._14
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
            this.lblalisfiyat = new System.Windows.Forms.Label();
            this.lblsatisfiyat = new System.Windows.Forms.Label();
            this.lblKarFiyat = new System.Windows.Forms.Label();
            this.txtAlisfFiyat = new System.Windows.Forms.TextBox();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblalisfiyat
            // 
            this.lblalisfiyat.AutoSize = true;
            this.lblalisfiyat.Location = new System.Drawing.Point(34, 36);
            this.lblalisfiyat.Name = "lblalisfiyat";
            this.lblalisfiyat.Size = new System.Drawing.Size(51, 13);
            this.lblalisfiyat.TabIndex = 0;
            this.lblalisfiyat.Text = "Alış Fiyat:";
            // 
            // lblsatisfiyat
            // 
            this.lblsatisfiyat.AutoSize = true;
            this.lblsatisfiyat.Location = new System.Drawing.Point(34, 70);
            this.lblsatisfiyat.Name = "lblsatisfiyat";
            this.lblsatisfiyat.Size = new System.Drawing.Size(60, 13);
            this.lblsatisfiyat.TabIndex = 1;
            this.lblsatisfiyat.Text = "Satiş Fiyatı:";
            // 
            // lblKarFiyat
            // 
            this.lblKarFiyat.AutoSize = true;
            this.lblKarFiyat.Location = new System.Drawing.Point(108, 140);
            this.lblKarFiyat.Name = "lblKarFiyat";
            this.lblKarFiyat.Size = new System.Drawing.Size(53, 13);
            this.lblKarFiyat.TabIndex = 2;
            this.lblKarFiyat.Text = "Kar Fiyatı:";
            // 
            // txtAlisfFiyat
            // 
            this.txtAlisfFiyat.Location = new System.Drawing.Point(94, 36);
            this.txtAlisfFiyat.Name = "txtAlisfFiyat";
            this.txtAlisfFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtAlisfFiyat.TabIndex = 3;
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(94, 62);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtSatisFiyat.TabIndex = 4;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(264, 31);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(106, 91);
            this.btnhesapla.TabIndex = 5;
            this.btnhesapla.Text = "HESAPLA";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 389);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.txtSatisFiyat);
            this.Controls.Add(this.txtAlisfFiyat);
            this.Controls.Add(this.lblKarFiyat);
            this.Controls.Add(this.lblsatisfiyat);
            this.Controls.Add(this.lblalisfiyat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblalisfiyat;
        private System.Windows.Forms.Label lblsatisfiyat;
        private System.Windows.Forms.Label lblKarFiyat;
        private System.Windows.Forms.TextBox txtAlisfFiyat;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.Button btnhesapla;
    }
}

