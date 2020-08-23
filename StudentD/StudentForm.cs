using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentD
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            formStatic.CloseStudentform();
        }
    }
}
