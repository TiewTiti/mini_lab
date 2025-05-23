namespace Lab_2234_2240_2244
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(203, 240);
            button1.Name = "button1";
            button1.Size = new Size(385, 69);
            button1.TabIndex = 0;
            button1.Text = "โปรแกรมจัดการพนักงาน";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(203, 315);
            button2.Name = "button2";
            button2.Size = new Size(385, 69);
            button2.TabIndex = 1;
            button2.Text = "เครื่องคำนวณเลขคู่และเลขคี่";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(203, 390);
            button3.Name = "button3";
            button3.Size = new Size(385, 69);
            button3.TabIndex = 2;
            button3.Text = "ตารางสูตรคูณ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(203, 465);
            button4.Name = "button4";
            button4.Size = new Size(385, 69);
            button4.TabIndex = 3;
            button4.Text = "เกมทายตัวเลข";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(203, 540);
            button5.Name = "button5";
            button5.Size = new Size(385, 69);
            button5.TabIndex = 4;
            button5.Text = "เครื่องคิดเลข";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 51);
            label1.Name = "label1";
            label1.Size = new Size(480, 75);
            label1.TabIndex = 5;
            label1.Text = "LAB VISUAL STUDIO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(349, 185);
            label2.Name = "label2";
            label2.Size = new Size(93, 42);
            label2.TabIndex = 6;
            label2.Text = "MENU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("TH Kodchasal", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(266, 723);
            label3.Name = "label3";
            label3.Size = new Size(268, 75);
            label3.TabIndex = 7;
            label3.Text = "นายฐิติพงจ์ ลีลาทิวานนท์ 65080502234\r\nนางสาวพัชรทิยา เครือสนิท 65080502240\r\nนายยศวร ล้อมลิ้ม 65080502244";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(814, 807);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}