namespace Lab_2234_2240_2244
{
    partial class MultiplyTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiplyTable));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Snap ITC", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(115, 26);
            label1.Name = "label1";
            label1.Size = new Size(411, 61);
            label1.TabIndex = 0;
            label1.Text = "MultiplyTable";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 93);
            label2.Name = "label2";
            label2.Size = new Size(214, 28);
            label2.TabIndex = 2;
            label2.Text = "ใสเลขที่ต้องการหาสูตรคูณ";
            label2.Click += label2_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Browallia New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 42;
            listBox1.Location = new Point(45, 191);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(540, 466);
            listBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(515, 711);
            button1.Name = "button1";
            button1.Size = new Size(70, 37);
            button1.TabIndex = 4;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(480, 124);
            button2.Name = "button2";
            button2.Size = new Size(105, 27);
            button2.TabIndex = 5;
            button2.Text = "SEARCH";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 101);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            label3.Click += label3_Click;
            // 
            // MultiplyTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(621, 778);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "MultiplyTable";
            Text = "        ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}