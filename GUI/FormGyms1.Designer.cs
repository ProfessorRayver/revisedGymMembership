namespace GUI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBox1 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-7, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1051, 534);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(807, 261);
            button5.Name = "button5";
            button5.Size = new Size(147, 69);
            button5.TabIndex = 12;
            button5.Text = "EXIT";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(807, 166);
            button4.Name = "button4";
            button4.Size = new Size(147, 69);
            button4.TabIndex = 11;
            button4.Text = "Remove Member";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(626, 352);
            button3.Name = "button3";
            button3.Size = new Size(147, 69);
            button3.TabIndex = 10;
            button3.Text = "Update Payment";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(626, 261);
            button1.Name = "button1";
            button1.Size = new Size(147, 69);
            button1.TabIndex = 9;
            button1.Text = "View Members";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(626, 166);
            button2.Name = "button2";
            button2.Size = new Size(147, 69);
            button2.TabIndex = 8;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(626, 88);
            label1.Name = "label1";
            label1.Size = new Size(354, 46);
            label1.TabIndex = 13;
            label1.Text = "MAIN DASHBOARD";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1037, 525);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}
