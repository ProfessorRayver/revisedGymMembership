namespace GUIfinals
{
    partial class RegisterForm
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
            txtStatus = new TextBox();
            txtName = new TextBox();
            btnCancel = new Button();
            btnSubmit = new Button();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(640, 123);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(213, 23);
            txtStatus.TabIndex = 40;
            txtStatus.TextChanged += txtStatus_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(640, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 23);
            txtName.TabIndex = 39;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(592, 355);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 60);
            btnCancel.TabIndex = 38;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.LimeGreen;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(592, 273);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(134, 60);
            btnSubmit.TabIndex = 37;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(488, 187);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 36;
            label3.Text = "DATE:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(640, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 23);
            dateTimePicker1.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(488, 123);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 34;
            label2.Text = "Status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(488, 63);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 33;
            label1.Text = "Name:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.registerFINAL;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(888, 533);
            Controls.Add(txtStatus);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStatus;
        private TextBox txtName;
        private Button btnCancel;
        private Button btnSubmit;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
    }
}