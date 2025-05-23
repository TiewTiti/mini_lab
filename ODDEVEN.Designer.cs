namespace Lab_2234_2240_2244
{
    partial class oeanalysis_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oeanalysis_frm));
            label1 = new Label();
            label2 = new Label();
            Result_lbl = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(36, 61);
            label1.Name = "label1";
            label1.Size = new Size(424, 70);
            label1.TabIndex = 0;
            label1.Text = "OOD N EVEN \r\nNUMBER ANALYSIS MACHINE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(101, 190);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter a Number to Analysis";
            label2.Click += label2_Click;
            // 
            // Result_lbl
            // 
            Result_lbl.Anchor = AnchorStyles.None;
            Result_lbl.AutoSize = true;
            Result_lbl.BackColor = SystemColors.ControlLightLight;
            Result_lbl.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Result_lbl.Location = new Point(101, 495);
            Result_lbl.Name = "Result_lbl";
            Result_lbl.Size = new Size(118, 33);
            Result_lbl.TabIndex = 2;
            Result_lbl.Text = "Result";
            Result_lbl.TextAlign = ContentAlignment.MiddleCenter;
            Result_lbl.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 213);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(406, 641);
            button1.Name = "button1";
            button1.Size = new Size(75, 38);
            button1.TabIndex = 4;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(165, 309);
            button2.Name = "button2";
            button2.Size = new Size(157, 90);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // oeanalysis_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(493, 691);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(Result_lbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "oeanalysis_frm";
            Text = "OOD and EVEN Analysis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Result_lbl;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}