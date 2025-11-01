namespace Calculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(54, 73);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "First No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(54, 144);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Second No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(54, 218);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Result";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Info;
            textBox1.Location = new Point(231, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaptionText;
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.Info;
            textBox2.Location = new Point(230, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(126, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveCaptionText;
            textBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.Info;
            textBox3.Location = new Point(227, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(128, 31);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(160, 290);
            button1.Name = "button1";
            button1.Size = new Size(73, 56);
            button1.TabIndex = 6;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(239, 290);
            button2.Name = "button2";
            button2.Size = new Size(69, 56);
            button2.TabIndex = 7;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(160, 352);
            button3.Name = "button3";
            button3.Size = new Size(73, 58);
            button3.TabIndex = 8;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(239, 352);
            button4.Name = "button4";
            button4.Size = new Size(69, 58);
            button4.TabIndex = 9;
            button4.Text = "*";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.WindowFrame;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(622, 245);
            button5.Name = "button5";
            button5.Size = new Size(118, 32);
            button5.TabIndex = 10;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlDarkDark;
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(620, 315);
            button6.Name = "button6";
            button6.Size = new Size(123, 31);
            button6.TabIndex = 11;
            button6.Text = "Exit";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_09_01_at_09_56_35;
            ClientSize = new Size(851, 550);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
