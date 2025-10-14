
namespace GUI
{
    partial class List
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
            dataGridView1 = new DataGridView();
            lblID = new Label();
            lblIDstatus = new Label();
            lblStatus = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnHome = new Button();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column5, Column4 });
            dataGridView1.Location = new Point(69, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(342, 382);
            dataGridView1.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.White;
            lblID.Location = new Point(471, 169);
            lblID.Name = "lblID";
            lblID.Size = new Size(51, 33);
            lblID.TabIndex = 1;
            lblID.Text = "ID:";
            lblID.Click += lblID_Click;
            // 
            // lblIDstatus
            // 
            lblIDstatus.AutoSize = true;
            lblIDstatus.BackColor = Color.Transparent;
            lblIDstatus.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDstatus.ForeColor = Color.White;
            lblIDstatus.Location = new Point(471, 325);
            lblIDstatus.Name = "lblIDstatus";
            lblIDstatus.Size = new Size(51, 33);
            lblIDstatus.TabIndex = 2;
            lblIDstatus.Text = "ID:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(471, 373);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(86, 23);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "STATUS:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(573, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(573, 327);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(573, 375);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(573, 422);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 54);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(573, 211);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 54);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(632, 46);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(100, 54);
            btnHome.TabIndex = 8;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = true;
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
            // List
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.list_main;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1069, 631);
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
            Name = "List";
            Text = "List";
            Load += List_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void List_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblID_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblID;
        private Label lblIDstatus;
        private Label lblStatus;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnHome;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
    }
}