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

        private void CreateListViewLecturer()
        {
            listView3.Clear();

            listView3.View = View.Details;
            listView3.GridLines = true;
            listView3.FullRowSelect = true;

            //myListView.Columns.Add(text, width, alignment);
            //Add column header

            listView3.Columns.Add("ID", 150);
            listView3.Columns.Add("Name", 321);
            listView3.Columns.Add("DoB", 100);
            listView3.Columns.Add("Email", 350);
            listView3.Columns.Add("Address", 300);
            listView3.Columns.Add("Batch", 150);



            //Add items in the listview

            string[] arr1 = new string[10];
            ListViewItem itm;

            string[,] strArr = lecturer.LecArr;

            File fileLecturer = new File();

            int countLine = fileLecturer.CountLine("Lecturer.txt");

            string[,] str = new string[countLine + 2, 10];

            // chuyen str1 sang str
            if (countLine != 0)
            {
                for (int i = 0; i < countLine; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        str[i, j] = strArr[i, j];
                    }
                }
            }

            for (int y = 0; y < countLine; y++)
            {
                for (int x = 0; x < 6; x++)
                {
                    arr1[x] = str[y, x];
                }
                itm = new ListViewItem(arr1);
                listView3.Items.Add(itm);
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            lecturerMganage = new LecturerManage(lecturer);
            InputData();
            lecturerMganage.add();

            CreateListViewLecturer();
        }

        private void LecturerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lecturerMganage = new LecturerManage(lecturer);
            InputData();
            lecturerMganage.update();

            CreateListViewLecturer();

        }

        private void button5_Click(object sender, EventArgs e) //delete
        {
            lecturerMganage = new LecturerManage(lecturer);
            InputData();
            lecturerMganage.delete();

            CreateListViewLecturer();
        }

        private void button3_Click(object sender, EventArgs e) //search
        {
            lecturerMganage = new LecturerManage(lecturer);
            InputData();
            lecturerMganage.search();
            Output();

        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {
            lecturerMganage = new LecturerManage(lecturer);
            lecturerMganage.Read();
            CreateListViewLecturer();
        }

        private void listView3_Click(object sender, EventArgs e)
        {
            string id = null;
            string name = null;
            string dob = null;
            string email = null;
            string address = null;
            string batch = null;

            id = listView3.SelectedItems[0].SubItems[0].Text;
            name = listView3.SelectedItems[0].SubItems[1].Text;
            dob = listView3.SelectedItems[0].SubItems[2].Text;
            email = listView3.SelectedItems[0].SubItems[3].Text;
            address = listView3.SelectedItems[0].SubItems[4].Text;
            batch = listView3.SelectedItems[0].SubItems[5].Text;


            txtId.Text = id;
            txtName.Text = name;
            txtDayOfBirth.Text = dob;
            txtEmail.Text = email;
            txtAddress.Text = address;
            txtBatch.Text = batch;
        }
    }
}
