namespace GUI
{
    partial class register
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gym_Studio;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(972, 535);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(512, 85);
            label1.Name = "label1";
            label1.Size = new Size(104, 37);
            label1.TabIndex = 5;
            label1.Text = "NAME:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(512, 181);
            label2.Name = "label2";
            label2.Size = new Size(98, 37);
            label2.TabIndex = 6;
            label2.Text = " DATE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(512, 269);
            label3.Name = "label3";
            label3.Size = new Size(255, 37);
            label3.TabIndex = 7;
            label3.Text = "Membership Type:";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "REGULAR", "SPECIAL" });
            comboBox1.Location = new Point(792, 269);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(524, 370);
            button1.Name = "button1";
            button1.Size = new Size(92, 39);
            button1.TabIndex = 9;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(675, 370);
            button2.Name = "button2";
            button2.Size = new Size(92, 39);
            button2.TabIndex = 10;
            button2.Text = "SUBMIT";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(658, 85);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 37);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(658, 181);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 37);
            textBox2.TabIndex = 12;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 533);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "register";
            Text = "register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}