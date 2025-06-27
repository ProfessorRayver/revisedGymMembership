namespace GUIfinals
{
    partial class viewMembers
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
            btnHome = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            idrow = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Silver;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ActiveCaptionText;
            btnHome.Location = new Point(573, 68);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(100, 54);
            btnHome.TabIndex = 48;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(503, 292);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 80);
            btnDelete.TabIndex = 46;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SpringGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(503, 395);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(170, 80);
            btnUpdate.TabIndex = 47;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idrow, Column2, Column5, Column6 });
            dataGridView1.Location = new Point(9, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(445, 382);
            dataGridView1.TabIndex = 39;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Elephant", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(503, 195);
            button1.Name = "button1";
            button1.Size = new Size(170, 67);
            button1.TabIndex = 50;
            button1.Text = "GUIDE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // idrow
            // 
            idrow.HeaderText = "ID:";
            idrow.Name = "idrow";
            // 
            // Column2
            // 
            Column2.HeaderText = "NAME:";
            Column2.Name = "Column2";
            // 
            // Column5
            // 
            Column5.HeaderText = "DATE:";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "PaymentStatus";
            Column6.Name = "Column6";
            // 
            // viewMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.list_main;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 656);
            Controls.Add(button1);
            Controls.Add(btnHome);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dataGridView1);
            Name = "viewMembers";
            Text = "viewMembers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHome;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn idrow;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}