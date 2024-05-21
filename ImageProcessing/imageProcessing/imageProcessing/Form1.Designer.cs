namespace imageProcessing
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
			this.grayscaleButton = new System.Windows.Forms.Button();
			this.selectImageButton = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.binaryButton = new System.Windows.Forms.Button();
			this.rotateButton = new System.Windows.Forms.Button();
			this.angleTextBox = new System.Windows.Forms.TextBox();
			this.cropButton = new System.Windows.Forms.Button();
			this.leftTextBox = new System.Windows.Forms.TextBox();
			this.topTextBox = new System.Windows.Forms.TextBox();
			this.widthTextBox = new System.Windows.Forms.TextBox();
			this.heightTextBox = new System.Windows.Forms.TextBox();
			this.zoomOutButton = new System.Windows.Forms.Button();
			this.widthTextBox1 = new System.Windows.Forms.TextBox();
			this.heightTextBox1 = new System.Windows.Forms.TextBox();
			this.zoomInButton = new System.Windows.Forms.Button();
			this.scaleFactorTextBox = new System.Windows.Forms.TextBox();
			this.gaussButton = new System.Windows.Forms.Button();
			this.adaptiveThresholdButton = new System.Windows.Forms.Button();
			this.sobelButton = new System.Windows.Forms.Button();
			this.noiseAddButton = new System.Windows.Forms.Button();
			this.meanFilterButton = new System.Windows.Forms.Button();
			this.medianFilterButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// grayscaleButton
			// 
			this.grayscaleButton.Location = new System.Drawing.Point(104, 8);
			this.grayscaleButton.Name = "grayscaleButton";
			this.grayscaleButton.Size = new System.Drawing.Size(96, 46);
			this.grayscaleButton.TabIndex = 0;
			this.grayscaleButton.Text = "Gri Dönüşüm";
			this.grayscaleButton.UseVisualStyleBackColor = true;
			this.grayscaleButton.Click += new System.EventHandler(this.grayscaleButton_Click);
			// 
			// selectImageButton
			// 
			this.selectImageButton.Location = new System.Drawing.Point(2, 1);
			this.selectImageButton.Name = "selectImageButton";
			this.selectImageButton.Size = new System.Drawing.Size(96, 60);
			this.selectImageButton.TabIndex = 1;
			this.selectImageButton.Text = "Resim Seç";
			this.selectImageButton.UseVisualStyleBackColor = true;
			this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click_1);
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(684, 26);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(449, 335);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 2;
			this.pictureBox.TabStop = false;
			// 
			// binaryButton
			// 
			this.binaryButton.Location = new System.Drawing.Point(2, 67);
			this.binaryButton.Name = "binaryButton";
			this.binaryButton.Size = new System.Drawing.Size(96, 50);
			this.binaryButton.TabIndex = 3;
			this.binaryButton.Text = "Binary  Dönüşüm";
			this.binaryButton.UseVisualStyleBackColor = true;
			this.binaryButton.Click += new System.EventHandler(this.binaryButton_Click);
			// 
			// rotateButton
			// 
			this.rotateButton.Location = new System.Drawing.Point(104, 69);
			this.rotateButton.Name = "rotateButton";
			this.rotateButton.Size = new System.Drawing.Size(96, 46);
			this.rotateButton.TabIndex = 4;
			this.rotateButton.Text = "Rotate";
			this.rotateButton.UseVisualStyleBackColor = true;
			this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
			// 
			// angleTextBox
			// 
			this.angleTextBox.Location = new System.Drawing.Point(206, 81);
			this.angleTextBox.Name = "angleTextBox";
			this.angleTextBox.Size = new System.Drawing.Size(55, 22);
			this.angleTextBox.TabIndex = 5;
			// 
			// cropButton
			// 
			this.cropButton.Location = new System.Drawing.Point(2, 123);
			this.cropButton.Name = "cropButton";
			this.cropButton.Size = new System.Drawing.Size(96, 46);
			this.cropButton.TabIndex = 6;
			this.cropButton.Text = "Kırpma";
			this.cropButton.UseVisualStyleBackColor = true;
			this.cropButton.Click += new System.EventHandler(this.cropButton_Click);
			// 
			// leftTextBox
			// 
			this.leftTextBox.Location = new System.Drawing.Point(114, 123);
			this.leftTextBox.Name = "leftTextBox";
			this.leftTextBox.Size = new System.Drawing.Size(45, 22);
			this.leftTextBox.TabIndex = 7;
			// 
			// topTextBox
			// 
			this.topTextBox.Location = new System.Drawing.Point(114, 152);
			this.topTextBox.Name = "topTextBox";
			this.topTextBox.Size = new System.Drawing.Size(45, 22);
			this.topTextBox.TabIndex = 8;
			// 
			// widthTextBox
			// 
			this.widthTextBox.Location = new System.Drawing.Point(165, 123);
			this.widthTextBox.Name = "widthTextBox";
			this.widthTextBox.Size = new System.Drawing.Size(49, 22);
			this.widthTextBox.TabIndex = 9;
			// 
			// heightTextBox
			// 
			this.heightTextBox.Location = new System.Drawing.Point(166, 152);
			this.heightTextBox.Name = "heightTextBox";
			this.heightTextBox.Size = new System.Drawing.Size(48, 22);
			this.heightTextBox.TabIndex = 10;
			// 
			// zoomOutButton
			// 
			this.zoomOutButton.Location = new System.Drawing.Point(2, 185);
			this.zoomOutButton.Name = "zoomOutButton";
			this.zoomOutButton.Size = new System.Drawing.Size(96, 51);
			this.zoomOutButton.TabIndex = 11;
			this.zoomOutButton.Text = "ZoomOut";
			this.zoomOutButton.UseVisualStyleBackColor = true;
			this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
			// 
			// widthTextBox1
			// 
			this.widthTextBox1.Location = new System.Drawing.Point(114, 185);
			this.widthTextBox1.Name = "widthTextBox1";
			this.widthTextBox1.Size = new System.Drawing.Size(100, 22);
			this.widthTextBox1.TabIndex = 12;
			// 
			// heightTextBox1
			// 
			this.heightTextBox1.Location = new System.Drawing.Point(114, 214);
			this.heightTextBox1.Name = "heightTextBox1";
			this.heightTextBox1.Size = new System.Drawing.Size(100, 22);
			this.heightTextBox1.TabIndex = 13;
			// 
			// zoomInButton
			// 
			this.zoomInButton.Location = new System.Drawing.Point(2, 253);
			this.zoomInButton.Name = "zoomInButton";
			this.zoomInButton.Size = new System.Drawing.Size(96, 51);
			this.zoomInButton.TabIndex = 14;
			this.zoomInButton.Text = "Zoom In";
			this.zoomInButton.UseVisualStyleBackColor = true;
			this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
			// 
			// scaleFactorTextBox
			// 
			this.scaleFactorTextBox.Location = new System.Drawing.Point(114, 267);
			this.scaleFactorTextBox.Name = "scaleFactorTextBox";
			this.scaleFactorTextBox.Size = new System.Drawing.Size(100, 22);
			this.scaleFactorTextBox.TabIndex = 15;
			// 
			// gaussButton
			// 
			this.gaussButton.Location = new System.Drawing.Point(2, 324);
			this.gaussButton.Name = "gaussButton";
			this.gaussButton.Size = new System.Drawing.Size(96, 51);
			this.gaussButton.TabIndex = 16;
			this.gaussButton.Text = "Gauss";
			this.gaussButton.UseVisualStyleBackColor = true;
			this.gaussButton.Click += new System.EventHandler(this.gaussButton_Click);
			// 
			// adaptiveThresholdButton
			// 
			this.adaptiveThresholdButton.Location = new System.Drawing.Point(2, 387);
			this.adaptiveThresholdButton.Name = "adaptiveThresholdButton";
			this.adaptiveThresholdButton.Size = new System.Drawing.Size(96, 51);
			this.adaptiveThresholdButton.TabIndex = 17;
			this.adaptiveThresholdButton.Text = "Adaptif Eşikle";
			this.adaptiveThresholdButton.UseVisualStyleBackColor = true;
			this.adaptiveThresholdButton.Click += new System.EventHandler(this.adaptiveThresholdButton_Click_1);
			// 
			// sobelButton
			// 
			this.sobelButton.Location = new System.Drawing.Point(2, 457);
			this.sobelButton.Name = "sobelButton";
			this.sobelButton.Size = new System.Drawing.Size(96, 51);
			this.sobelButton.TabIndex = 18;
			this.sobelButton.Text = "Sobel";
			this.sobelButton.UseVisualStyleBackColor = true;
			this.sobelButton.Click += new System.EventHandler(this.sobelButton_Click);
			// 
			// noiseAddButton
			// 
			this.noiseAddButton.Location = new System.Drawing.Point(2, 535);
			this.noiseAddButton.Name = "noiseAddButton";
			this.noiseAddButton.Size = new System.Drawing.Size(96, 51);
			this.noiseAddButton.TabIndex = 19;
			this.noiseAddButton.Text = "Gürültü Ekle";
			this.noiseAddButton.UseVisualStyleBackColor = true;
			this.noiseAddButton.Click += new System.EventHandler(this.noiseAddButton_Click);
			// 
			// meanFilterButton
			// 
			this.meanFilterButton.Location = new System.Drawing.Point(2, 606);
			this.meanFilterButton.Name = "meanFilterButton";
			this.meanFilterButton.Size = new System.Drawing.Size(96, 51);
			this.meanFilterButton.TabIndex = 23;
			this.meanFilterButton.Text = "Temizle   (Mean)";
			this.meanFilterButton.UseVisualStyleBackColor = true;
			this.meanFilterButton.Click += new System.EventHandler(this.meanFilterButton_Click);
			// 
			// medianFilterButton
			// 
			this.medianFilterButton.Location = new System.Drawing.Point(2, 672);
			this.medianFilterButton.Name = "medianFilterButton";
			this.medianFilterButton.Size = new System.Drawing.Size(96, 51);
			this.medianFilterButton.TabIndex = 24;
			this.medianFilterButton.Text = "Temizle   (Median)";
			this.medianFilterButton.UseVisualStyleBackColor = true;
			this.medianFilterButton.Click += new System.EventHandler(this.medianFilterButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PapayaWhip;
			this.ClientSize = new System.Drawing.Size(1376, 755);
			this.Controls.Add(this.medianFilterButton);
			this.Controls.Add(this.meanFilterButton);
			this.Controls.Add(this.noiseAddButton);
			this.Controls.Add(this.sobelButton);
			this.Controls.Add(this.adaptiveThresholdButton);
			this.Controls.Add(this.gaussButton);
			this.Controls.Add(this.scaleFactorTextBox);
			this.Controls.Add(this.zoomInButton);
			this.Controls.Add(this.heightTextBox1);
			this.Controls.Add(this.widthTextBox1);
			this.Controls.Add(this.zoomOutButton);
			this.Controls.Add(this.heightTextBox);
			this.Controls.Add(this.widthTextBox);
			this.Controls.Add(this.topTextBox);
			this.Controls.Add(this.leftTextBox);
			this.Controls.Add(this.cropButton);
			this.Controls.Add(this.angleTextBox);
			this.Controls.Add(this.rotateButton);
			this.Controls.Add(this.binaryButton);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.selectImageButton);
			this.Controls.Add(this.grayscaleButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grayscaleButton;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button binaryButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.Button cropButton;
        private System.Windows.Forms.TextBox leftTextBox;
        private System.Windows.Forms.TextBox topTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button zoomOutButton;
        private System.Windows.Forms.TextBox widthTextBox1;
        private System.Windows.Forms.TextBox heightTextBox1;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.TextBox scaleFactorTextBox;
		private System.Windows.Forms.Button gaussButton;
		private System.Windows.Forms.Button adaptiveThresholdButton;
		private System.Windows.Forms.Button sobelButton;
		private System.Windows.Forms.Button noiseAddButton;
		private System.Windows.Forms.Button meanFilterButton;
		private System.Windows.Forms.Button medianFilterButton;
	}
}

