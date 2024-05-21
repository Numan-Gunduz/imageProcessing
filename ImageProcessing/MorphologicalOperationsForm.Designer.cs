namespace imageProcessing
{
    partial class MorphologicalOperationsForm
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
            this.resimEkleButton = new System.Windows.Forms.Button();
            this.KapamaButton = new System.Windows.Forms.Button();
            this.AcmaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kernelTextBox = new System.Windows.Forms.TextBox();
            this.AsinmaButton = new System.Windows.Forms.Button();
            this.GenislemeButton = new System.Windows.Forms.Button();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // resimEkleButton
            // 
            this.resimEkleButton.BackColor = System.Drawing.Color.SlateGray;
            this.resimEkleButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.resimEkleButton.FlatAppearance.BorderSize = 4;
            this.resimEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resimEkleButton.Location = new System.Drawing.Point(66, 502);
            this.resimEkleButton.Name = "resimEkleButton";
            this.resimEkleButton.Size = new System.Drawing.Size(232, 56);
            this.resimEkleButton.TabIndex = 17;
            this.resimEkleButton.Text = "Resim Ekle";
            this.resimEkleButton.UseVisualStyleBackColor = false;
            this.resimEkleButton.Click += new System.EventHandler(this.resimEkleButton_Click);
            // 
            // KapamaButton
            // 
            this.KapamaButton.BackColor = System.Drawing.Color.SlateGray;
            this.KapamaButton.Location = new System.Drawing.Point(763, 565);
            this.KapamaButton.Name = "KapamaButton";
            this.KapamaButton.Size = new System.Drawing.Size(104, 49);
            this.KapamaButton.TabIndex = 16;
            this.KapamaButton.Text = "Kapama";
            this.KapamaButton.UseVisualStyleBackColor = false;
            this.KapamaButton.Click += new System.EventHandler(this.KapamaButton_Click);
            // 
            // AcmaButton
            // 
            this.AcmaButton.BackColor = System.Drawing.Color.SlateGray;
            this.AcmaButton.Location = new System.Drawing.Point(763, 470);
            this.AcmaButton.Name = "AcmaButton";
            this.AcmaButton.Size = new System.Drawing.Size(104, 48);
            this.AcmaButton.TabIndex = 15;
            this.AcmaButton.Text = "Açma";
            this.AcmaButton.UseVisualStyleBackColor = false;
            this.AcmaButton.Click += new System.EventHandler(this.AcmaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kernel Değeri";
            // 
            // kernelTextBox
            // 
            this.kernelTextBox.Location = new System.Drawing.Point(583, 537);
            this.kernelTextBox.Name = "kernelTextBox";
            this.kernelTextBox.Size = new System.Drawing.Size(113, 22);
            this.kernelTextBox.TabIndex = 13;
            // 
            // AsinmaButton
            // 
            this.AsinmaButton.BackColor = System.Drawing.Color.SlateGray;
            this.AsinmaButton.Location = new System.Drawing.Point(367, 565);
            this.AsinmaButton.Name = "AsinmaButton";
            this.AsinmaButton.Size = new System.Drawing.Size(108, 49);
            this.AsinmaButton.TabIndex = 12;
            this.AsinmaButton.Text = "Asinma";
            this.AsinmaButton.UseVisualStyleBackColor = false;
            this.AsinmaButton.Click += new System.EventHandler(this.AsinmaButton_Click);
            // 
            // GenislemeButton
            // 
            this.GenislemeButton.BackColor = System.Drawing.Color.SlateGray;
            this.GenislemeButton.Location = new System.Drawing.Point(367, 470);
            this.GenislemeButton.Name = "GenislemeButton";
            this.GenislemeButton.Size = new System.Drawing.Size(108, 48);
            this.GenislemeButton.TabIndex = 11;
            this.GenislemeButton.Text = "Genisleme";
            this.GenislemeButton.UseVisualStyleBackColor = false;
            this.GenislemeButton.Click += new System.EventHandler(this.GenislemeButton_Click);
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxResult.Location = new System.Drawing.Point(562, 99);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(350, 330);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResult.TabIndex = 10;
            this.pictureBoxResult.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(82, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(598, 32);
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
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(101, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 48);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "ORİJİNAL GÖRSEL";
            // 
            // MorphologicalOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1048, 660);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.resimEkleButton);
            this.Controls.Add(this.KapamaButton);
            this.Controls.Add(this.AcmaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kernelTextBox);
            this.Controls.Add(this.AsinmaButton);
            this.Controls.Add(this.GenislemeButton);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MorphologicalOperationsForm";
            this.Text = "MorphologicalOperationsForm";
            this.Load += new System.EventHandler(this.MorphologicalOperationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resimEkleButton;
        private System.Windows.Forms.Button KapamaButton;
        private System.Windows.Forms.Button AcmaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kernelTextBox;
        private System.Windows.Forms.Button AsinmaButton;
        private System.Windows.Forms.Button GenislemeButton;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}