using System;
using System.Collections.Generic;
using System.Text;

namespace StudentD
{
    public static class formStatic
    {
        static Menu Menuf;

        static StudentForm studentf;

        static LecturerForm Lecturerf;

        

        public static void FileForMenu()
        {
            //
        }

        public static void BackToMenuForMenu()
        {
            //
        }

        public static void OpenLecturerForm()
        {
            Lecturerf = new LecturerForm();
            Lecturerf.ShowDialog();
        }

        public static void CloseLecturerForm()
        {
            Lecturerf.Hide();
            Lecturerf.Close();
        }


        public static void OpenMenuForm()
        {
            Menuf = new Menu();
            Menuf.ShowDialog();
        }

        public static void CloseMenuForm()
        {
            Menuf.Close();
        }
        public static void OpenStudentform()
        {
            studentf = new StudentForm();
            studentf.ShowDialog();
        }


        public static void CloseStudentform()
        {
            studentf.Hide();
            studentf.Close();
        }


    }
}
