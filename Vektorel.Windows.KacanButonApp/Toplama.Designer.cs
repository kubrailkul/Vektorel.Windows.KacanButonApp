namespace Vektorel.Windows.KacanButonApp
{
    partial class Toplama
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
            this.btnSayi1 = new System.Windows.Forms.Button();
            this.btnSayi2 = new System.Windows.Forms.Button();
            this.btnSayi3 = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSayi1
            // 
            this.btnSayi1.Location = new System.Drawing.Point(17, 28);
            this.btnSayi1.Name = "btnSayi1";
            this.btnSayi1.Size = new System.Drawing.Size(75, 23);
            this.btnSayi1.TabIndex = 0;
            this.btnSayi1.Tag = "0";
            this.btnSayi1.Text = "Sayı 1";
            this.btnSayi1.UseVisualStyleBackColor = true;
            this.btnSayi1.Click += new System.EventHandler(this.BtnSayi_Click);
            // 
            // btnSayi2
            // 
            this.btnSayi2.Location = new System.Drawing.Point(17, 57);
            this.btnSayi2.Name = "btnSayi2";
            this.btnSayi2.Size = new System.Drawing.Size(75, 23);
            this.btnSayi2.TabIndex = 1;
            this.btnSayi2.Tag = "0";
            this.btnSayi2.Text = "Sayı 2";
            this.btnSayi2.UseVisualStyleBackColor = true;
            this.btnSayi2.Click += new System.EventHandler(this.BtnSayi_Click);
            // 
            // btnSayi3
            // 
            this.btnSayi3.Location = new System.Drawing.Point(17, 86);
            this.btnSayi3.Name = "btnSayi3";
            this.btnSayi3.Size = new System.Drawing.Size(75, 23);
            this.btnSayi3.TabIndex = 2;
            this.btnSayi3.Tag = "0";
            this.btnSayi3.Text = "Sayı 3";
            this.btnSayi3.UseVisualStyleBackColor = true;
            this.btnSayi3.Click += new System.EventHandler(this.BtnSayi_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(87, 193);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 23);
            this.btnTopla.TabIndex = 3;
            this.btnTopla.Tag = "1";
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.BtnTopla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSayi1);
            this.groupBox1.Controls.Add(this.btnSayi2);
            this.groupBox1.Controls.Add(this.btnSayi3);
            this.groupBox1.Location = new System.Drawing.Point(55, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 126);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Toplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 252);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTopla);
            this.Name = "Toplama";
            this.Tag = "0";
            this.Text = "Toplama";
            this.Load += new System.EventHandler(this.Toplama_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSayi1;
        private System.Windows.Forms.Button btnSayi2;
        private System.Windows.Forms.Button btnSayi3;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}