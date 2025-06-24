namespace GUIforms
{
    partial class regMemForms
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
            txtGender = new TextBox();
            txtName = new TextBox();
            btnCancel = new Button();
            btnSubmit = new Button();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtGender
            // 
            txtGender.Location = new Point(633, 128);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(213, 23);
            txtGender.TabIndex = 24;
            // 
            // txtName
            // 
            txtName.Location = new Point(633, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 23);
            txtName.TabIndex = 23;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(585, 360);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 60);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(585, 278);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(134, 60);
            btnSubmit.TabIndex = 21;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(481, 192);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 20;
            label3.Text = "DATE:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(633, 197);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(481, 128);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 18;
            label2.Text = "Gender:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(481, 68);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 17;
            label1.Text = "Name:";
            // 
            // regMemForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.registerFINAL;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(919, 542);
            Controls.Add(txtGender);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "regMemForms";
            Text = "regMemForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGender;
        private TextBox txtName;
        private Button btnCancel;
        private Button btnSubmit;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
    }
}