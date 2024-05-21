namespace imageProcessing
{
    partial class HistogramForm
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
            this.GenisletmeButton = new System.Windows.Forms.Button();
            this.GermeButton = new System.Windows.Forms.Button();
            this.resimEkleButton = new System.Windows.Forms.Button();
            this.pictureBoxTransformed = new System.Windows.Forms.PictureBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransformed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenisletmeButton
            // 
            this.GenisletmeButton.BackColor = System.Drawing.Color.SlateGray;
            this.GenisletmeButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenisletmeButton.Location = new System.Drawing.Point(25, 372);
            this.GenisletmeButton.Name = "GenisletmeButton";
            this.GenisletmeButton.Size = new System.Drawing.Size(198, 45);
            this.GenisletmeButton.TabIndex = 17;
            this.GenisletmeButton.Text = "Histogram Genişletme";
            this.GenisletmeButton.UseVisualStyleBackColor = false;
            this.GenisletmeButton.Click += new System.EventHandler(this.GenisletmeButton_Click);
            // 
            // GermeButton
            // 
            this.GermeButton.BackColor = System.Drawing.Color.SlateGray;
            this.GermeButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GermeButton.Location = new System.Drawing.Point(25, 304);
            this.GermeButton.Name = "GermeButton";
            this.GermeButton.Size = new System.Drawing.Size(198, 47);
            this.GermeButton.TabIndex = 16;
            this.GermeButton.Text = "Histogram Germe";
            this.GermeButton.UseVisualStyleBackColor = false;
            this.GermeButton.Click += new System.EventHandler(this.GermeButton_Click);
            // 
            // resimEkleButton
            // 
            this.resimEkleButton.BackColor = System.Drawing.Color.SlateGray;
            this.resimEkleButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.resimEkleButton.FlatAppearance.BorderSize = 4;
            this.resimEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resimEkleButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resimEkleButton.Location = new System.Drawing.Point(25, 166);
            this.resimEkleButton.Name = "resimEkleButton";
            this.resimEkleButton.Size = new System.Drawing.Size(198, 51);
            this.resimEkleButton.TabIndex = 15;
            this.resimEkleButton.Text = "Resim Ekle";
            this.resimEkleButton.UseVisualStyleBackColor = false;
            this.resimEkleButton.Click += new System.EventHandler(this.resimEkleButton_Click);
            // 
            // pictureBoxTransformed
            // 
            this.pictureBoxTransformed.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxTransformed.Location = new System.Drawing.Point(728, 143);
            this.pictureBoxTransformed.Name = "pictureBoxTransformed";
            this.pictureBoxTransformed.Size = new System.Drawing.Size(437, 382);
            this.pictureBoxTransformed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTransformed.TabIndex = 14;
            this.pictureBoxTransformed.TabStop = false;
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(243, 143);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(464, 382);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 13;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(810, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 48);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "FİLTRELİ GÖRSEL";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(313, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 48);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "ORİJİNAL GÖRSEL";
            // 
            // HistogramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1216, 640);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GenisletmeButton);
            this.Controls.Add(this.GermeButton);
            this.Controls.Add(this.resimEkleButton);
            this.Controls.Add(this.pictureBoxTransformed);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Name = "HistogramForm";
            this.Text = "HistogramForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransformed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenisletmeButton;
        private System.Windows.Forms.Button GermeButton;
        private System.Windows.Forms.Button resimEkleButton;
        private System.Windows.Forms.PictureBox pictureBoxTransformed;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}