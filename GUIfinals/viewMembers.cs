﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GymBL;
using GymCommon;

namespace GUIfinals
{
    public partial class viewMembers : Form
    {
        private GymBAL gymLogic = new GymBAL();

        public viewMembers()
        {
            InitializeComponent();
            LoadMembersToGrid();
        }

        private void LoadMembersToGrid()
        {
            dataGridView1.Rows.Clear();
            List<Member> members = gymLogic.GetMembers();

            int id = 1;
            foreach (var member in members)
            {
                // Display: ID, Name, Date, Membership Status
                dataGridView1.Rows.Add(
                    id,
                    member.Name,
                    member.registeredMonth,
                    member.MembershipType
                );
                id++;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nameToDelete = dataGridView1.SelectedRows[0].Cells[1].Value?.ToString();

                if (!string.IsNullOrEmpty(nameToDelete))
                {
                    var confirmResult = MessageBox.Show(
                        $"Are you sure to delete member '{nameToDelete}'?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        bool deleted = gymLogic.RemoveMember(nameToDelete);
                        if (deleted)
                        {
                            MessageBox.Show("Member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMembersToGrid();
                        }
                        else
                        {
                            MessageBox.Show("Member not found or could not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nameToUpdate = dataGridView1.SelectedRows[0].Cells[1].Value?.ToString();

                if (!string.IsNullOrEmpty(nameToUpdate))
                {
                    string newStatus = Microsoft.VisualBasic.Interaction.InputBox(
                        "Enter new payment status (Paid/Unpaid):",
                        "Update Payment Status",
                        "Paid");

                    if (!string.IsNullOrWhiteSpace(newStatus))
                    {
                        bool updated = gymLogic.UpdatePaymentStatus(nameToUpdate, newStatus);
                        if (updated)
                        {
                            MessageBox.Show("Payment status updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMembersToGrid();
                        }
                        else
                        {
                            MessageBox.Show("Member not found or could not be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select one row before Deleting or Updating.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}