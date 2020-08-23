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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // can sua lai
            formStatic.FileForMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer();

            lecturer.LecId = txtId.Text;
            lecturer.LecName = txtName.Text;
            lecturer.LecDoB = txtDayOfBirth.Text;
            lecturer.LecEmail = txtEmail.Text;
            lecturer.LecBatch = txtBatch.Text;
            lecturer.LecAddress = txtAddress.Text;


        }
    }
}
