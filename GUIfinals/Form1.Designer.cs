

namespace GUIfinals
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(513, 299);
            button3.Name = "button3";
            button3.Size = new Size(148, 61);
            button3.TabIndex = 5;
            button3.Text = "EXIT";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(610, 211);
            button2.Name = "button2";
            button2.Size = new Size(148, 61);
            button2.TabIndex = 4;
            button2.Text = "MEMBERS";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(428, 211);
            button1.Name = "button1";
            button1.Size = new Size(148, 61);
            button1.TabIndex = 3;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MainDASHBAORDfinal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }



        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
    }
}
