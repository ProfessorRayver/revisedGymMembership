namespace GUIforms
{
    partial class listingMemFroms
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblStatus = new Label();
            lblIDstatus = new Label();
            lblID = new Label();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(619, 74);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(100, 54);
            btnHome.TabIndex = 28;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(560, 239);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 54);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(560, 450);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 54);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(560, 403);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(560, 355);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(560, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 23;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(458, 401);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(86, 23);
            lblStatus.TabIndex = 22;
            lblStatus.Text = "STATUS:";
            // 
            // lblIDstatus
            // 
            lblIDstatus.AutoSize = true;
            lblIDstatus.BackColor = Color.Transparent;
            lblIDstatus.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDstatus.ForeColor = Color.White;
            lblIDstatus.Location = new Point(458, 353);
            lblIDstatus.Name = "lblIDstatus";
            lblIDstatus.Size = new Size(51, 33);
            lblIDstatus.TabIndex = 21;
            lblIDstatus.Text = "ID:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.White;
            lblID.Location = new Point(458, 197);
            lblID.Name = "lblID";
            lblID.Size = new Size(51, 33);
            lblID.TabIndex = 20;
            lblID.Text = "ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column5, Column4 });
            dataGridView1.Location = new Point(56, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(342, 382);
            dataGridView1.TabIndex = 19;
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
            // Column4
            // 
            Column4.HeaderText = "Membership Type";
            Column4.Name = "Column4";
            // 
            // listingMemFroms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.list_main;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1021, 596);
            Controls.Add(btnHome);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblStatus);
            Controls.Add(lblIDstatus);
            Controls.Add(lblID);
            Controls.Add(dataGridView1);
            Name = "listingMemFroms";
            Text = "listingMemFroms";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHome;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblStatus;
        private Label lblIDstatus;
        private Label lblID;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
    }
}