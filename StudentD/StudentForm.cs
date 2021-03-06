﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace StudentD
{
    public partial class StudentForm : Form
    {
        Student Student = new Student();
        StudentManage studentManage;

        public StudentForm()
        {
            InitializeComponent();
        }

        private void InputData()
        {
            Student.StdId = txtId.Text;
            Student.StdName = txtName.Text;
            Student.StdDoB = txtDayOfBirth.Text;
            Student.StdEmail = txtEmail.Text;
            Student.StdAddress = txtAddress.Text;
            Student.StdBatch = txtBatch.Text;

            Student.StdSearch = txtSearch.Text;
        }

        private void OutputData()
        {
            txtId.Text = Student.StdId;
            txtName.Text = Student.StdName;
            txtDayOfBirth.Text = Student.StdDoB;
            txtEmail.Text = Student.StdEmail;
            txtAddress.Text = Student.StdAddress;
            txtBatch.Text = Student.StdBatch;

           
        }

        private void CreateListViewStudent()
        {
            listView1.Clear();

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            
            //myListView.Columns.Add(text, width, alignment);
            //Add column header
            
            listView1.Columns.Add("ID", 150);
            listView1.Columns.Add("Name", 321);
            listView1.Columns.Add("DoB", 100);
            listView1.Columns.Add("Email", 350);
            listView1.Columns.Add("Address", 300);
            listView1.Columns.Add("Batch", 150);
            


            //Add items in the listview

            string[] arr1 = new string[10];
            ListViewItem itm;

            string[,] strArr = Student.StdArr;
            File fileStudent = new File();

            int countLine = fileStudent.CountLine("student.txt");

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
                listView1.Items.Add(itm);
            }


        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            studentManage = new StudentManage(Student);
            //InputData();
            studentManage.Read();
            CreateListViewStudent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            formStatic.CloseStudentform();
            formStatic.OpenMenuForm();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            studentManage = new StudentManage(Student);
            InputData();
            studentManage.search();
            OutputData();
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            studentManage = new StudentManage(Student);
            InputData();
            studentManage.add();

            CreateListViewStudent();
        }

        private void btView_Click(object sender, EventArgs e)
        {
            studentManage = new StudentManage(Student);

            studentManage.view();
        }

        private void btUpdate_Click(object sender, EventArgs e) //update
        {
            studentManage = new StudentManage(Student);
            InputData();
            studentManage.update();

            CreateListViewStudent();
        }

        private void btDelete_Click(object sender, EventArgs e) //delete
        {
            studentManage = new StudentManage(Student);
            InputData();
            studentManage.delete();

            CreateListViewStudent();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
           
            string id = null;
            string name = null;
            string dob = null;
            string email = null;
            string address = null;
            string batch = null;

            id = listView1.SelectedItems[0].SubItems[0].Text;
            name = listView1.SelectedItems[0].SubItems[1].Text;
            dob = listView1.SelectedItems[0].SubItems[2].Text;
            email = listView1.SelectedItems[0].SubItems[3].Text;
            address = listView1.SelectedItems[0].SubItems[4].Text;
            batch = listView1.SelectedItems[0].SubItems[5].Text;


            txtId.Text = id;
            txtName.Text = name;
            txtDayOfBirth.Text = dob;
            txtEmail.Text = email;
            txtAddress.Text = address;
            txtBatch.Text = batch;
        }
    }
}
