namespace imageProcessing
{
    partial class SaltPepperForm
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
            this.resimSecButton = new System.Windows.Forms.Button();
            this.saltPepperButton = new System.Windows.Forms.Button();
            this.processedPictureBox = new System.Windows.Forms.PictureBox();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.saltLabel = new System.Windows.Forms.Label();
            this.pepperLabel = new System.Windows.Forms.Label();
            this.saltTrackBar = new System.Windows.Forms.TrackBar();
            this.pepperTrackBar = new System.Windows.Forms.TrackBar();
            this.meanFilterButton = new System.Windows.Forms.Button();
            this.meanPictureBox = new System.Windows.Forms.PictureBox();
            this.medianFilterButton = new System.Windows.Forms.Button();
            this.medianPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saltTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pepperTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medianPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // resimSecButton
            // 
            this.resimSecButton.BackColor = System.Drawing.Color.SlateGray;
            this.resimSecButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resimSecButton.Location = new System.Drawing.Point(19, 69);
            this.resimSecButton.Name = "resimSecButton";
            this.resimSecButton.Size = new System.Drawing.Size(113, 54);
            this.resimSecButton.TabIndex = 0;
            this.resimSecButton.Text = "Resim Seç";
            this.resimSecButton.UseVisualStyleBackColor = false;
            this.resimSecButton.Click += new System.EventHandler(this.resimSecButton_Click);
            // 
            // saltPepperButton
            // 
            this.saltPepperButton.BackColor = System.Drawing.Color.SlateGray;
            this.saltPepperButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saltPepperButton.Location = new System.Drawing.Point(174, 73);
            this.saltPepperButton.Name = "saltPepperButton";
            this.saltPepperButton.Size = new System.Drawing.Size(147, 47);
            this.saltPepperButton.TabIndex = 3;
            this.saltPepperButton.Text = "SaltAndPepper";
            this.saltPepperButton.UseVisualStyleBackColor = false;
            this.saltPepperButton.Click += new System.EventHandler(this.saltPepperButton_Click);
            // 
            // processedPictureBox
            // 
            this.processedPictureBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.processedPictureBox.Location = new System.Drawing.Point(775, 105);
            this.processedPictureBox.Name = "processedPictureBox";
            this.processedPictureBox.Size = new System.Drawing.Size(357, 203);
            this.processedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.processedPictureBox.TabIndex = 5;
            this.processedPictureBox.TabStop = false;
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.originalPictureBox.Location = new System.Drawing.Point(355, 105);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(360, 209);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalPictureBox.TabIndex = 7;
            this.originalPictureBox.TabStop = false;
            // 
            // saltLabel
            // 
            this.saltLabel.AutoSize = true;
            this.saltLabel.Location = new System.Drawing.Point(41, 234);
            this.saltLabel.Name = "saltLabel";
            this.saltLabel.Size = new System.Drawing.Size(44, 16);
            this.saltLabel.TabIndex = 8;
            this.saltLabel.Text = "label1";
            // 
            // pepperLabel
            // 
            this.pepperLabel.AutoSize = true;
            this.pepperLabel.Location = new System.Drawing.Point(208, 234);
            this.pepperLabel.Name = "pepperLabel";
            this.pepperLabel.Size = new System.Drawing.Size(44, 16);
            this.pepperLabel.TabIndex = 9;
            this.pepperLabel.Text = "label1";
            // 
            // saltTrackBar
            // 
            this.saltTrackBar.Location = new System.Drawing.Point(19, 145);
            this.saltTrackBar.Name = "saltTrackBar";
            this.saltTrackBar.Size = new System.Drawing.Size(104, 56);
            this.saltTrackBar.TabIndex = 10;
            this.saltTrackBar.Scroll += new System.EventHandler(this.saltTrackBar_Scroll);
            // 
            // pepperTrackBar
            // 
            this.pepperTrackBar.Location = new System.Drawing.Point(183, 145);
            this.pepperTrackBar.Name = "pepperTrackBar";
            this.pepperTrackBar.Size = new System.Drawing.Size(104, 56);
            this.pepperTrackBar.TabIndex = 11;
            this.pepperTrackBar.Scroll += new System.EventHandler(this.pepperTrackBar_Scroll);
            // 
            // meanFilterButton
            // 
            this.meanFilterButton.BackColor = System.Drawing.Color.SlateGray;
            this.meanFilterButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.meanFilterButton.Location = new System.Drawing.Point(294, 324);
            this.meanFilterButton.Name = "meanFilterButton";
            this.meanFilterButton.Size = new System.Drawing.Size(94, 46);
            this.meanFilterButton.TabIndex = 12;
            this.meanFilterButton.Text = "Mean";
            this.meanFilterButton.UseVisualStyleBackColor = false;
            this.meanFilterButton.Click += new System.EventHandler(this.meanFilterButton_Click);
            // 
            // meanPictureBox
            // 
            this.meanPictureBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.meanPictureBox.Location = new System.Drawing.Point(144, 388);
            this.meanPictureBox.Name = "meanPictureBox";
            this.meanPictureBox.Size = new System.Drawing.Size(389, 226);
            this.meanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.meanPictureBox.TabIndex = 13;
            this.meanPictureBox.TabStop = false;
            // 
            // medianFilterButton
            // 
            this.medianFilterButton.BackColor = System.Drawing.Color.SlateGray;
            this.medianFilterButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.medianFilterButton.Location = new System.Drawing.Point(819, 324);
            this.medianFilterButton.Name = "medianFilterButton";
            this.medianFilterButton.Size = new System.Drawing.Size(110, 46);
            this.medianFilterButton.TabIndex = 14;
            this.medianFilterButton.Text = "Median";
            this.medianFilterButton.UseVisualStyleBackColor = false;
            this.medianFilterButton.Click += new System.EventHandler(this.medianFilterButton_Click);
            // 
            // medianPictureBox
            // 
            this.medianPictureBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.medianPictureBox.Location = new System.Drawing.Point(691, 388);
            this.medianPictureBox.Name = "medianPictureBox";
            this.medianPictureBox.Size = new System.Drawing.Size(386, 226);
            this.medianPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.medianPictureBox.TabIndex = 15;
            this.medianPictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(805, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 48);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(56, 18);
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
            this.groupBox2.Location = new System.Drawing.Point(390, 39);
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
            // SaltPepperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1231, 626);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.medianPictureBox);
            this.Controls.Add(this.medianFilterButton);
            this.Controls.Add(this.meanPictureBox);
            this.Controls.Add(this.meanFilterButton);
            this.Controls.Add(this.pepperTrackBar);
            this.Controls.Add(this.saltTrackBar);
            this.Controls.Add(this.pepperLabel);
            this.Controls.Add(this.saltLabel);
            this.Controls.Add(this.originalPictureBox);
            this.Controls.Add(this.processedPictureBox);
            this.Controls.Add(this.saltPepperButton);
            this.Controls.Add(this.resimSecButton);
            this.Name = "SaltPepperForm";
            this.Text = "SaltPepper";
            this.Load += new System.EventHandler(this.SaltPepperForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saltTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pepperTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medianPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resimSecButton;
        private System.Windows.Forms.Button saltPepperButton;
        private System.Windows.Forms.PictureBox processedPictureBox;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.Label saltLabel;
        private System.Windows.Forms.Label pepperLabel;
        private System.Windows.Forms.TrackBar saltTrackBar;
        private System.Windows.Forms.TrackBar pepperTrackBar;
        private System.Windows.Forms.Button meanFilterButton;
        private System.Windows.Forms.PictureBox meanPictureBox;
        private System.Windows.Forms.Button medianFilterButton;
        private System.Windows.Forms.PictureBox medianPictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}