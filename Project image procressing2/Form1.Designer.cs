namespace Project_image_procressing2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOrigin = new Button();
            btnGray1 = new Button();
            btnGray2 = new Button();
            btnOpen = new Button();
            pictureBox1 = new PictureBox();
            btnblackwhite = new Button();
            textBox1 = new TextBox();
            threshold = new Label();
            btn_negative = new Button();
            btn_invert = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            btn_powerlaw = new Button();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnOrigin
            // 
            btnOrigin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrigin.Location = new Point(35, 12);
            btnOrigin.Name = "btnOrigin";
            btnOrigin.Size = new Size(79, 42);
            btnOrigin.TabIndex = 0;
            btnOrigin.Text = "Original";
            btnOrigin.UseVisualStyleBackColor = true;
            btnOrigin.Click += btnOrigin_Click;
            // 
            // btnGray1
            // 
            btnGray1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGray1.Location = new Point(147, 12);
            btnGray1.Name = "btnGray1";
            btnGray1.Size = new Size(127, 42);
            btnGray1.TabIndex = 1;
            btnGray1.Text = "GrayScale1";
            btnGray1.UseVisualStyleBackColor = true;
            btnGray1.Click += btnGray1_Click;
            // 
            // btnGray2
            // 
            btnGray2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGray2.Location = new Point(317, 12);
            btnGray2.Name = "btnGray2";
            btnGray2.Size = new Size(127, 42);
            btnGray2.TabIndex = 2;
            btnGray2.Text = "GrayScale2";
            btnGray2.UseVisualStyleBackColor = true;
            btnGray2.Click += btnGray2_Click;
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpen.Location = new Point(545, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(140, 42);
            btnOpen.TabIndex = 3;
            btnOpen.Text = "Open Picture";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(491, 537);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnblackwhite
            // 
            btnblackwhite.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnblackwhite.Location = new Point(545, 70);
            btnblackwhite.Name = "btnblackwhite";
            btnblackwhite.Size = new Size(140, 42);
            btnblackwhite.TabIndex = 5;
            btnblackwhite.Text = "Black_white";
            btnblackwhite.UseVisualStyleBackColor = true;
            btnblackwhite.Click += btnblackwhite_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(636, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(49, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "100";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // threshold
            // 
            threshold.AutoSize = true;
            threshold.Location = new Point(536, 129);
            threshold.Name = "threshold";
            threshold.Size = new Size(74, 20);
            threshold.TabIndex = 7;
            threshold.Text = "Threshold";
            // 
            // btn_negative
            // 
            btn_negative.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_negative.Location = new Point(545, 174);
            btn_negative.Name = "btn_negative";
            btn_negative.Size = new Size(140, 42);
            btn_negative.TabIndex = 8;
            btn_negative.Text = "Negative";
            btn_negative.UseVisualStyleBackColor = true;
            btn_negative.Click += button1_Click;
            // 
            // btn_invert
            // 
            btn_invert.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_invert.Location = new Point(545, 244);
            btn_invert.Name = "btn_invert";
            btn_invert.Size = new Size(140, 42);
            btn_invert.TabIndex = 9;
            btn_invert.Text = "invert";
            btn_invert.UseVisualStyleBackColor = true;
            btn_invert.Click += btn_invert_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(545, 306);
            button1.Name = "button1";
            button1.Size = new Size(185, 42);
            button1.TabIndex = 10;
            button1.Text = "Log Tranformation";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(555, 371);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 11;
            label1.Text = "C = ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(597, 368);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(49, 27);
            textBox2.TabIndex = 12;
            textBox2.Text = "2";
            // 
            // btn_powerlaw
            // 
            btn_powerlaw.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_powerlaw.Location = new Point(545, 419);
            btn_powerlaw.Name = "btn_powerlaw";
            btn_powerlaw.Size = new Size(185, 42);
            btn_powerlaw.TabIndex = 13;
            btn_powerlaw.Text = "Power Law";
            btn_powerlaw.UseVisualStyleBackColor = true;
            btn_powerlaw.Click += btn_powerlaw_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(555, 486);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 14;
            label2.Text = "C = ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(597, 483);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(49, 27);
            textBox3.TabIndex = 15;
            textBox3.Text = "1";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(597, 532);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(49, 27);
            textBox4.TabIndex = 16;
            textBox4.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(525, 535);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 17;
            label3.Text = "Alpha = ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 734);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(btn_powerlaw);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btn_invert);
            Controls.Add(btn_negative);
            Controls.Add(threshold);
            Controls.Add(textBox1);
            Controls.Add(btnblackwhite);
            Controls.Add(pictureBox1);
            Controls.Add(btnOpen);
            Controls.Add(btnGray2);
            Controls.Add(btnGray1);
            Controls.Add(btnOrigin);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrigin;
        private Button btnGray1;
        private Button btnGray2;
        private Button btnOpen;
        private PictureBox pictureBox1;
        private Button btnblackwhite;
        private TextBox textBox1;
        private Label threshold;
        private Button btn_negative;
        private Button btn_invert;
        private Button button1;
        private Label label1;
        private TextBox textBox2;
        private Button btn_powerlaw;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
    }
}