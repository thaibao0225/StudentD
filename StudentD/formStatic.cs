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

        public static void OpenStudentform()
        {
            studentf = new StudentForm();
            studentf.ShowDialog();
        }


        public static void CloseStudentform()
        {
            studentf.Close();
        }


    }
}
