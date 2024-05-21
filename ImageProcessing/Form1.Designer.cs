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
			this.scaleXTextBox = new System.Windows.Forms.TextBox();
			this.scaleYTextBox = new System.Windows.Forms.TextBox();
			this.zoomInButton = new System.Windows.Forms.Button();
			this.widthTextBox2 = new System.Windows.Forms.TextBox();
			this.ParlaklıkArttırButton = new System.Windows.Forms.Button();
			this.AdaptifEşiklemeButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.heightTextBox2 = new System.Windows.Forms.TextBox();
			this.parlaklikTextBox = new System.Windows.Forms.TextBox();
			this.sobelButton = new System.Windows.Forms.Button();
			this.gaussButton = new System.Windows.Forms.Button();
			this.blurButton = new System.Windows.Forms.Button();
			this.blurAmountTextBox = new System.Windows.Forms.TextBox();
			this.SaltAndPepper = new System.Windows.Forms.Button();
			this.AritmetikIslemlerButton = new System.Windows.Forms.Button();
			this.MorfolojikIslemlerButton = new System.Windows.Forms.Button();
			this.renkUzayıButton = new System.Windows.Forms.Button();
			this.HistogramButton = new System.Windows.Forms.Button();
			this.f = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.f.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// grayscaleButton
			// 
			this.grayscaleButton.BackColor = System.Drawing.Color.RosyBrown;
			this.grayscaleButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grayscaleButton.Location = new System.Drawing.Point(40, 42);
			this.grayscaleButton.Name = "grayscaleButton";
			this.grayscaleButton.Size = new System.Drawing.Size(129, 48);
			this.grayscaleButton.TabIndex = 0;
			this.grayscaleButton.Text = "Gri Dönüşüm";
			this.grayscaleButton.UseVisualStyleBackColor = false;
			this.grayscaleButton.Click += new System.EventHandler(this.grayscaleButton_Click);
			// 
			// selectImageButton
			// 
			this.selectImageButton.BackColor = System.Drawing.Color.SlateGray;
			this.selectImageButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
			this.selectImageButton.FlatAppearance.BorderSize = 4;
			this.selectImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.selectImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.selectImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.selectImageButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.selectImageButton.ForeColor = System.Drawing.Color.Black;
			this.selectImageButton.Location = new System.Drawing.Point(22, 31);
			this.selectImageButton.Name = "selectImageButton";
			this.selectImageButton.Size = new System.Drawing.Size(371, 43);
			this.selectImageButton.TabIndex = 1;
			this.selectImageButton.Text = "Resim Seç";
			this.selectImageButton.UseVisualStyleBackColor = false;
			this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox.Location = new System.Drawing.Point(432, 165);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(504, 335);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox.TabIndex = 2;
			this.pictureBox.TabStop = false;
			// 
			// binaryButton
			// 
			this.binaryButton.BackColor = System.Drawing.Color.RosyBrown;
			this.binaryButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.binaryButton.Location = new System.Drawing.Point(177, 42);
			this.binaryButton.Name = "binaryButton";
			this.binaryButton.Size = new System.Drawing.Size(129, 48);
			this.binaryButton.TabIndex = 3;
			this.binaryButton.Text = "Binary  Dönüşüm";
			this.binaryButton.UseVisualStyleBackColor = false;
			this.binaryButton.Click += new System.EventHandler(this.binaryButton_Click);
			// 
			// rotateButton
			// 
			this.rotateButton.BackColor = System.Drawing.Color.RosyBrown;
			this.rotateButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rotateButton.Location = new System.Drawing.Point(40, 192);
			this.rotateButton.Name = "rotateButton";
			this.rotateButton.Size = new System.Drawing.Size(135, 54);
			this.rotateButton.TabIndex = 4;
			this.rotateButton.Text = "Rotate";
			this.rotateButton.UseVisualStyleBackColor = false;
			this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
			// 
			// angleTextBox
			// 
			this.angleTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
			this.angleTextBox.Location = new System.Drawing.Point(199, 200);
			this.angleTextBox.Name = "angleTextBox";
			this.angleTextBox.Size = new System.Drawing.Size(119, 34);
			this.angleTextBox.TabIndex = 5;
			this.angleTextBox.TextChanged += new System.EventHandler(this.angleTextBox_TextChanged);
			// 
			// cropButton
			// 
			this.cropButton.BackColor = System.Drawing.Color.RosyBrown;
			this.cropButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cropButton.Location = new System.Drawing.Point(40, 251);
			this.cropButton.Name = "cropButton";
			this.cropButton.Size = new System.Drawing.Size(135, 54);
			this.cropButton.TabIndex = 6;
			this.cropButton.Text = "Kırpma";
			this.cropButton.UseVisualStyleBackColor = false;
			this.cropButton.Click += new System.EventHandler(this.cropButton_Click);
			// 
			// leftTextBox
			// 
			this.leftTextBox.Location = new System.Drawing.Point(199, 251);
			this.leftTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.leftTextBox.Name = "leftTextBox";
			this.leftTextBox.Size = new System.Drawing.Size(55, 34);
			this.leftTextBox.TabIndex = 7;
			// 
			// topTextBox
			// 
			this.topTextBox.Location = new System.Drawing.Point(199, 287);
			this.topTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.topTextBox.Name = "topTextBox";
			this.topTextBox.Size = new System.Drawing.Size(55, 34);
			this.topTextBox.TabIndex = 8;
			// 
			// widthTextBox
			// 
			this.widthTextBox.Location = new System.Drawing.Point(260, 251);
			this.widthTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.widthTextBox.Name = "widthTextBox";
			this.widthTextBox.Size = new System.Drawing.Size(55, 34);
			this.widthTextBox.TabIndex = 9;
			// 
			// heightTextBox
			// 
			this.heightTextBox.Location = new System.Drawing.Point(260, 287);
			this.heightTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.heightTextBox.Name = "heightTextBox";
			this.heightTextBox.Size = new System.Drawing.Size(55, 34);
			this.heightTextBox.TabIndex = 10;
			// 
			// zoomOutButton
			// 
			this.zoomOutButton.BackColor = System.Drawing.Color.RosyBrown;
			this.zoomOutButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.zoomOutButton.Location = new System.Drawing.Point(40, 311);
			this.zoomOutButton.Name = "zoomOutButton";
			this.zoomOutButton.Size = new System.Drawing.Size(135, 54);
			this.zoomOutButton.TabIndex = 11;
			this.zoomOutButton.Text = "ZoomOut";
			this.zoomOutButton.UseVisualStyleBackColor = false;
			this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
			// 
			// scaleXTextBox
			// 
			this.scaleXTextBox.Location = new System.Drawing.Point(199, 328);
			this.scaleXTextBox.Name = "scaleXTextBox";
			this.scaleXTextBox.Size = new System.Drawing.Size(55, 34);
			this.scaleXTextBox.TabIndex = 12;
			// 
			// scaleYTextBox
			// 
			this.scaleYTextBox.Location = new System.Drawing.Point(260, 331);
			this.scaleYTextBox.Name = "scaleYTextBox";
			this.scaleYTextBox.Size = new System.Drawing.Size(55, 34);
			this.scaleYTextBox.TabIndex = 13;
			// 
			// zoomInButton
			// 
			this.zoomInButton.BackColor = System.Drawing.Color.RosyBrown;
			this.zoomInButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.zoomInButton.Location = new System.Drawing.Point(40, 372);
			this.zoomInButton.Name = "zoomInButton";
			this.zoomInButton.Size = new System.Drawing.Size(135, 54);
			this.zoomInButton.TabIndex = 14;
			this.zoomInButton.Text = "Zoom In";
			this.zoomInButton.UseVisualStyleBackColor = false;
			this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
			// 
			// widthTextBox2
			// 
			this.widthTextBox2.Location = new System.Drawing.Point(199, 382);
			this.widthTextBox2.Name = "widthTextBox2";
			this.widthTextBox2.Size = new System.Drawing.Size(55, 34);
			this.widthTextBox2.TabIndex = 15;
			// 
			// ParlaklıkArttırButton
			// 
			this.ParlaklıkArttırButton.BackColor = System.Drawing.Color.RosyBrown;
			this.ParlaklıkArttırButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ParlaklıkArttırButton.Location = new System.Drawing.Point(40, 435);
			this.ParlaklıkArttırButton.Name = "ParlaklıkArttırButton";
			this.ParlaklıkArttırButton.Size = new System.Drawing.Size(135, 54);
			this.ParlaklıkArttırButton.TabIndex = 16;
			this.ParlaklıkArttırButton.Text = "Parlaklık Arttır";
			this.ParlaklıkArttırButton.UseVisualStyleBackColor = false;
			this.ParlaklıkArttırButton.Click += new System.EventHandler(this.ParlaklıkArttırButton_Click);
			// 
			// AdaptifEşiklemeButton
			// 
			this.AdaptifEşiklemeButton.BackColor = System.Drawing.Color.RosyBrown;
			this.AdaptifEşiklemeButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.AdaptifEşiklemeButton.Location = new System.Drawing.Point(40, 94);
			this.AdaptifEşiklemeButton.Name = "AdaptifEşiklemeButton";
			this.AdaptifEşiklemeButton.Size = new System.Drawing.Size(129, 48);
			this.AdaptifEşiklemeButton.TabIndex = 17;
			this.AdaptifEşiklemeButton.Text = "Adaptif Eşikleme";
			this.AdaptifEşiklemeButton.UseVisualStyleBackColor = false;
			this.AdaptifEşiklemeButton.Click += new System.EventHandler(this.AdaptifEşiklemeButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(954, 165);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(504, 335);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// heightTextBox2
			// 
			this.heightTextBox2.Location = new System.Drawing.Point(263, 382);
			this.heightTextBox2.Name = "heightTextBox2";
			this.heightTextBox2.Size = new System.Drawing.Size(55, 34);
			this.heightTextBox2.TabIndex = 21;
			this.heightTextBox2.TextChanged += new System.EventHandler(this.scaleYTextBox_TextChanged);
			// 
			// parlaklikTextBox
			// 
			this.parlaklikTextBox.Location = new System.Drawing.Point(199, 455);
			this.parlaklikTextBox.Name = "parlaklikTextBox";
			this.parlaklikTextBox.Size = new System.Drawing.Size(116, 34);
			this.parlaklikTextBox.TabIndex = 22;
			// 
			// sobelButton
			// 
			this.sobelButton.BackColor = System.Drawing.Color.RosyBrown;
			this.sobelButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.sobelButton.Location = new System.Drawing.Point(40, 148);
			this.sobelButton.Name = "sobelButton";
			this.sobelButton.Size = new System.Drawing.Size(266, 35);
			this.sobelButton.TabIndex = 23;
			this.sobelButton.Text = "Sobel";
			this.sobelButton.UseVisualStyleBackColor = false;
			this.sobelButton.Click += new System.EventHandler(this.sobelButton_Click);
			// 
			// gaussButton
			// 
			this.gaussButton.BackColor = System.Drawing.Color.RosyBrown;
			this.gaussButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gaussButton.Location = new System.Drawing.Point(177, 94);
			this.gaussButton.Name = "gaussButton";
			this.gaussButton.Size = new System.Drawing.Size(129, 48);
			this.gaussButton.TabIndex = 24;
			this.gaussButton.Text = "Gauss";
			this.gaussButton.UseVisualStyleBackColor = false;
			this.gaussButton.Click += new System.EventHandler(this.gaussButton_Click);
			// 
			// blurButton
			// 
			this.blurButton.BackColor = System.Drawing.Color.RosyBrown;
			this.blurButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.blurButton.Location = new System.Drawing.Point(40, 495);
			this.blurButton.Name = "blurButton";
			this.blurButton.Size = new System.Drawing.Size(135, 54);
			this.blurButton.TabIndex = 25;
			this.blurButton.Text = "Blurring";
			this.blurButton.UseVisualStyleBackColor = false;
			this.blurButton.Click += new System.EventHandler(this.blurButton_Click);
			// 
			// blurAmountTextBox
			// 
			this.blurAmountTextBox.Location = new System.Drawing.Point(199, 502);
			this.blurAmountTextBox.Name = "blurAmountTextBox";
			this.blurAmountTextBox.Size = new System.Drawing.Size(116, 34);
			this.blurAmountTextBox.TabIndex = 26;
			this.blurAmountTextBox.TextChanged += new System.EventHandler(this.blurAmountTextBox_TextChanged);
			// 
			// SaltAndPepper
			// 
			this.SaltAndPepper.BackColor = System.Drawing.Color.RosyBrown;
			this.SaltAndPepper.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.SaltAndPepper.Location = new System.Drawing.Point(71, 33);
			this.SaltAndPepper.Name = "SaltAndPepper";
			this.SaltAndPepper.Size = new System.Drawing.Size(169, 50);
			this.SaltAndPepper.TabIndex = 27;
			this.SaltAndPepper.Text = "Salt Pepper";
			this.SaltAndPepper.UseVisualStyleBackColor = false;
			this.SaltAndPepper.Click += new System.EventHandler(this.SaltAndPepper_Click);
			// 
			// AritmetikIslemlerButton
			// 
			this.AritmetikIslemlerButton.BackColor = System.Drawing.Color.RosyBrown;
			this.AritmetikIslemlerButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.AritmetikIslemlerButton.Location = new System.Drawing.Point(256, 33);
			this.AritmetikIslemlerButton.Name = "AritmetikIslemlerButton";
			this.AritmetikIslemlerButton.Size = new System.Drawing.Size(169, 50);
			this.AritmetikIslemlerButton.TabIndex = 28;
			this.AritmetikIslemlerButton.Text = "Aritmetik İslemler";
			this.AritmetikIslemlerButton.UseVisualStyleBackColor = false;
			this.AritmetikIslemlerButton.Click += new System.EventHandler(this.AritmetikIslemlerButton_Click);
			// 
			// MorfolojikIslemlerButton
			// 
			this.MorfolojikIslemlerButton.BackColor = System.Drawing.Color.RosyBrown;
			this.MorfolojikIslemlerButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.MorfolojikIslemlerButton.Location = new System.Drawing.Point(432, 33);
			this.MorfolojikIslemlerButton.Name = "MorfolojikIslemlerButton";
			this.MorfolojikIslemlerButton.Size = new System.Drawing.Size(169, 50);
			this.MorfolojikIslemlerButton.TabIndex = 29;
			this.MorfolojikIslemlerButton.Text = "Morfolojik İslemler";
			this.MorfolojikIslemlerButton.UseVisualStyleBackColor = false;
			this.MorfolojikIslemlerButton.Click += new System.EventHandler(this.MorfolojikIslemlerButton_Click);
			// 
			// renkUzayıButton
			// 
			this.renkUzayıButton.BackColor = System.Drawing.Color.RosyBrown;
			this.renkUzayıButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.renkUzayıButton.Location = new System.Drawing.Point(608, 33);
			this.renkUzayıButton.Name = "renkUzayıButton";
			this.renkUzayıButton.Size = new System.Drawing.Size(169, 50);
			this.renkUzayıButton.TabIndex = 30;
			this.renkUzayıButton.Text = "Renk Uzayı Dönüşümleri";
			this.renkUzayıButton.UseVisualStyleBackColor = false;
			this.renkUzayıButton.Click += new System.EventHandler(this.renkUzayıButton_Click);
			// 
			// HistogramButton
			// 
			this.HistogramButton.BackColor = System.Drawing.Color.RosyBrown;
			this.HistogramButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.HistogramButton.Location = new System.Drawing.Point(783, 33);
			this.HistogramButton.Name = "HistogramButton";
			this.HistogramButton.Size = new System.Drawing.Size(169, 50);
			this.HistogramButton.TabIndex = 31;
			this.HistogramButton.Text = "Histogram Germe/Genişletme";
			this.HistogramButton.UseVisualStyleBackColor = false;
			this.HistogramButton.Click += new System.EventHandler(this.HistogramButton_Click);
			// 
			// f
			// 
			this.f.BackColor = System.Drawing.Color.SlateGray;
			this.f.Controls.Add(this.sobelButton);
			this.f.Controls.Add(this.grayscaleButton);
			this.f.Controls.Add(this.binaryButton);
			this.f.Controls.Add(this.rotateButton);
			this.f.Controls.Add(this.angleTextBox);
			this.f.Controls.Add(this.blurAmountTextBox);
			this.f.Controls.Add(this.cropButton);
			this.f.Controls.Add(this.blurButton);
			this.f.Controls.Add(this.leftTextBox);
			this.f.Controls.Add(this.gaussButton);
			this.f.Controls.Add(this.heightTextBox);
			this.f.Controls.Add(this.parlaklikTextBox);
			this.f.Controls.Add(this.widthTextBox);
			this.f.Controls.Add(this.heightTextBox2);
			this.f.Controls.Add(this.topTextBox);
			this.f.Controls.Add(this.zoomOutButton);
			this.f.Controls.Add(this.scaleXTextBox);
			this.f.Controls.Add(this.scaleYTextBox);
			this.f.Controls.Add(this.AdaptifEşiklemeButton);
			this.f.Controls.Add(this.ParlaklıkArttırButton);
			this.f.Controls.Add(this.zoomInButton);
			this.f.Controls.Add(this.widthTextBox2);
			this.f.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.f.Location = new System.Drawing.Point(14, 96);
			this.f.Name = "f";
			this.f.Size = new System.Drawing.Size(380, 567);
			this.f.TabIndex = 32;
			this.f.TabStop = false;
			this.f.Text = "Filtreleme İşlemleri";
			this.f.Enter += new System.EventHandler(this.f_Enter);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
			this.groupBox1.Controls.Add(this.renkUzayıButton);
			this.groupBox1.Controls.Add(this.SaltAndPepper);
			this.groupBox1.Controls.Add(this.HistogramButton);
			this.groupBox1.Controls.Add(this.AritmetikIslemlerButton);
			this.groupBox1.Controls.Add(this.MorfolojikIslemlerButton);
			this.groupBox1.Location = new System.Drawing.Point(432, 531);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1026, 103);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
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
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.RosyBrown;
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Location = new System.Drawing.Point(543, 96);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(290, 48);
			this.groupBox2.TabIndex = 35;
			this.groupBox2.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox3.Location = new System.Drawing.Point(1040, 96);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(290, 48);
			this.groupBox3.TabIndex = 36;
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.SlateGray;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(666, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(579, 37);
			this.label3.TabIndex = 37;
			this.label3.Text = "GÖRÜNTÜ İŞLEME FİNAL PROJESİ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(1478, 675);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.f);
			this.Controls.Add(this.selectImageButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Name = "Form1";
			this.Text = "Filtrelemeİşlemleri-NumanGündüz";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.f.ResumeLayout(false);
			this.f.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.TextBox scaleXTextBox;
        private System.Windows.Forms.TextBox scaleYTextBox;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.TextBox widthTextBox2;
        private System.Windows.Forms.Button ParlaklıkArttırButton;
        private System.Windows.Forms.Button AdaptifEşiklemeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox heightTextBox2;
        private System.Windows.Forms.TextBox parlaklikTextBox;
        private System.Windows.Forms.Button sobelButton;
        private System.Windows.Forms.Button gaussButton;
        private System.Windows.Forms.Button blurButton;
        private System.Windows.Forms.TextBox blurAmountTextBox;
        private System.Windows.Forms.Button SaltAndPepper;
        private System.Windows.Forms.Button AritmetikIslemlerButton;
        private System.Windows.Forms.Button MorfolojikIslemlerButton;
        private System.Windows.Forms.Button renkUzayıButton;
        private System.Windows.Forms.Button HistogramButton;
        private System.Windows.Forms.GroupBox f;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

