namespace WinFormsApp1
{
    partial class frmRandomNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRandomNumber));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.Font = new Font("Impact", 49.8000031F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(-16, -4);
            label1.Name = "label1";
            label1.Size = new Size(1239, 102);
            label1.TabIndex = 0;
            label1.Text = "RanderNumbom    RandomNumber";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 212);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 245);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(334, 498);
            label2.Name = "label2";
            label2.Size = new Size(591, 75);
            label2.TabIndex = 2;
            label2.Text = "ถ้าพร้อมแล้ว ขึ้นไปได้!!!!!";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Green;
            textBox1.Font = new Font("Impact", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(192, 192, 0);
            textBox1.Location = new Point(406, 259);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(431, 152);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.Transparent;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(942, 243);
            button2.Name = "button2";
            button2.Size = new Size(183, 180);
            button2.TabIndex = 5;
            button2.TextImageRelation = TextImageRelation.TextAboveImage;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LawnGreen;
            label4.Location = new Point(41, 498);
            label4.Name = "label4";
            label4.Size = new Size(300, 75);
            label4.TabIndex = 7;
            label4.Text = "คุณปัญญา :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmRandomNumber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1202, 598);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmRandomNumber";
            Text = "frmRandomNumber";
            Load += frmRandomNumber_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private Label label4;
    }
}