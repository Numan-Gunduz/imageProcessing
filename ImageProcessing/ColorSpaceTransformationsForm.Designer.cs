namespace imageProcessing
{
    partial class ColorSpaceTransformationsForm
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
            this.RGBtoHSIButton = new System.Windows.Forms.Button();
            this.RGBtoCMYKButton = new System.Windows.Forms.Button();
            this.RGBtoCMYButton = new System.Windows.Forms.Button();
            this.RGBtoYCbCrButton = new System.Windows.Forms.Button();
            this.RGBtoNTSCButton = new System.Windows.Forms.Button();
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
            // RGBtoHSIButton
            // 
            this.RGBtoHSIButton.BackColor = System.Drawing.Color.SlateGray;
            this.RGBtoHSIButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RGBtoHSIButton.Location = new System.Drawing.Point(913, 577);
            this.RGBtoHSIButton.Name = "RGBtoHSIButton";
            this.RGBtoHSIButton.Size = new System.Drawing.Size(142, 57);
            this.RGBtoHSIButton.TabIndex = 15;
            this.RGBtoHSIButton.Text = "HSI";
            this.RGBtoHSIButton.UseVisualStyleBackColor = false;
            this.RGBtoHSIButton.Click += new System.EventHandler(this.RGBtoHSIButton_Click);
            // 
            // RGBtoCMYKButton
            // 
            this.RGBtoCMYKButton.BackColor = System.Drawing.Color.SlateGray;
            this.RGBtoCMYKButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RGBtoCMYKButton.Location = new System.Drawing.Point(721, 577);
            this.RGBtoCMYKButton.Name = "RGBtoCMYKButton";
            this.RGBtoCMYKButton.Size = new System.Drawing.Size(142, 57);
            this.RGBtoCMYKButton.TabIndex = 14;
            this.RGBtoCMYKButton.Text = "CMYK";
            this.RGBtoCMYKButton.UseVisualStyleBackColor = false;
            this.RGBtoCMYKButton.Click += new System.EventHandler(this.RGBtoCMYKButton_Click);
            // 
            // RGBtoCMYButton
            // 
            this.RGBtoCMYButton.BackColor = System.Drawing.Color.SlateGray;
            this.RGBtoCMYButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RGBtoCMYButton.Location = new System.Drawing.Point(512, 577);
            this.RGBtoCMYButton.Name = "RGBtoCMYButton";
            this.RGBtoCMYButton.Size = new System.Drawing.Size(142, 57);
            this.RGBtoCMYButton.TabIndex = 13;
            this.RGBtoCMYButton.Text = "CMY";
            this.RGBtoCMYButton.UseVisualStyleBackColor = false;
            this.RGBtoCMYButton.Click += new System.EventHandler(this.RGBtoCMYButton_Click);
            // 
            // RGBtoYCbCrButton
            // 
            this.RGBtoYCbCrButton.BackColor = System.Drawing.Color.SlateGray;
            this.RGBtoYCbCrButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RGBtoYCbCrButton.Location = new System.Drawing.Point(321, 577);
            this.RGBtoYCbCrButton.Name = "RGBtoYCbCrButton";
            this.RGBtoYCbCrButton.Size = new System.Drawing.Size(142, 57);
            this.RGBtoYCbCrButton.TabIndex = 12;
            this.RGBtoYCbCrButton.Text = "YCbCr";
            this.RGBtoYCbCrButton.UseVisualStyleBackColor = false;
            this.RGBtoYCbCrButton.Click += new System.EventHandler(this.RGBtoYCbCrButton_Click);
            // 
            // RGBtoNTSCButton
            // 
            this.RGBtoNTSCButton.BackColor = System.Drawing.Color.SlateGray;
            this.RGBtoNTSCButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RGBtoNTSCButton.Location = new System.Drawing.Point(118, 577);
            this.RGBtoNTSCButton.Name = "RGBtoNTSCButton";
            this.RGBtoNTSCButton.Size = new System.Drawing.Size(142, 57);
            this.RGBtoNTSCButton.TabIndex = 11;
            this.RGBtoNTSCButton.Text = "NTSC";
            this.RGBtoNTSCButton.UseVisualStyleBackColor = false;
            this.RGBtoNTSCButton.Click += new System.EventHandler(this.RGBtoNTSCButton_Click);
            // 
            // resimEkleButton
            // 
            this.resimEkleButton.BackColor = System.Drawing.Color.SlateGray;
            this.resimEkleButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.resimEkleButton.FlatAppearance.BorderSize = 4;
            this.resimEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resimEkleButton.Location = new System.Drawing.Point(468, 475);
            this.resimEkleButton.Name = "resimEkleButton";
            this.resimEkleButton.Size = new System.Drawing.Size(250, 51);
            this.resimEkleButton.TabIndex = 10;
            this.resimEkleButton.Text = "Resim Ekle";
            this.resimEkleButton.UseVisualStyleBackColor = false;
            this.resimEkleButton.Click += new System.EventHandler(this.resimEkleButton_Click);
            // 
            // pictureBoxTransformed
            // 
            this.pictureBoxTransformed.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxTransformed.Location = new System.Drawing.Point(721, 124);
            this.pictureBoxTransformed.Name = "pictureBoxTransformed";
            this.pictureBoxTransformed.Size = new System.Drawing.Size(350, 330);
            this.pictureBoxTransformed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTransformed.TabIndex = 9;
            this.pictureBoxTransformed.TabStop = false;
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(118, 124);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(350, 330);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 8;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(736, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 48);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 18);
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
            this.groupBox2.Location = new System.Drawing.Point(144, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 48);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "ORİJİNAL GÖRSEL";
            // 
            // ColorSpaceTransformationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1206, 677);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.RGBtoHSIButton);
            this.Controls.Add(this.RGBtoCMYKButton);
            this.Controls.Add(this.RGBtoCMYButton);
            this.Controls.Add(this.RGBtoYCbCrButton);
            this.Controls.Add(this.RGBtoNTSCButton);
            this.Controls.Add(this.resimEkleButton);
            this.Controls.Add(this.pictureBoxTransformed);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Name = "ColorSpaceTransformationsForm";
            this.Text = "ColorSpaceTransformationsForm";
            this.Load += new System.EventHandler(this.ColorSpaceTransformationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransformed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RGBtoHSIButton;
        private System.Windows.Forms.Button RGBtoCMYKButton;
        private System.Windows.Forms.Button RGBtoCMYButton;
        private System.Windows.Forms.Button RGBtoYCbCrButton;
        private System.Windows.Forms.Button RGBtoNTSCButton;
        private System.Windows.Forms.Button resimEkleButton;
        private System.Windows.Forms.PictureBox pictureBoxTransformed;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}