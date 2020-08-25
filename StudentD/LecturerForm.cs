using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentD
{
    public partial class LecturerForm : Form
    {
        public LecturerForm()
        {
            InitializeComponent();
        }

        Lecturer lecturer = new Lecturer();
        LecturerManage lecturerMganage;


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            formStatic.CloseLecturerForm();
            formStatic.OpenMenuForm();
        }

        private void InputData()
        {
            lecturer.LecId = txtId.Text;
            lecturer.LecName = txtName.Text;
            lecturer.LecDoB = txtDayOfBirth.Text;
            lecturer.LecEmail = txtEmail.Text;
            lecturer.LecBatch = txtBatch.Text;
            lecturer.LecAddress = txtAddress.Text;

            lecturer.LecSearch = txtSearch.Text;
        }

        private void Output()
        {
            txtId.Text = lecturer.LecId;
            txtName.Text = lecturer.LecName;
            txtDayOfBirth.Text = lecturer.LecDoB;
            txtEmail.Text = lecturer.LecEmail;
            txtBatch.Text = txtBatch.Text;
            txtAddress.Text = txtAddress.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void LecturerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
