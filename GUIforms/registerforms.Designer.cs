namespace GUIforms
{
    partial class registerforms
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
            txtStatus.Location = new Point(542, 104);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(213, 23);
            txtStatus.TabIndex = 32;
            // 
            // txtName
            // 
            txtName.Location = new Point(542, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 23);
            txtName.TabIndex = 31;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(494, 336);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 60);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(494, 254);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(134, 60);
            btnSubmit.TabIndex = 29;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(390, 168);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 28;
            label3.Text = "DATE:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(542, 173);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 23);
            dateTimePicker1.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(390, 104);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 26;
            label2.Text = "Status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(390, 44);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 25;
            label1.Text = "Name:";
            // 
            // registerforms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 533);
            Controls.Add(txtStatus);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "registerforms";
            Text = "registerforms";
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