namespace GUIforms
{
    partial class MaindashFroms
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
            btnRegister = new Button();
            btnMembers = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(486, 238);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(102, 53);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button1_Click;
            // 
            // btnMembers
            // 
            btnMembers.Location = new Point(616, 238);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(101, 53);
            btnMembers.TabIndex = 1;
            btnMembers.Text = "Members";
            btnMembers.UseVisualStyleBackColor = true;
            btnMembers.Click += button2_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(544, 317);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(113, 68);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // MaindashFroms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MainDASHBAORDfinal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnMembers);
            Controls.Add(btnRegister);
            Name = "MaindashFroms";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private Button btnMembers;
        private Button btnExit;
    }
}
