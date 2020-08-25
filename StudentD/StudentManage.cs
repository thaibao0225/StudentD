using System;
using System.Collections.Generic;
using System.Text;

namespace StudentD
{
    class StudentManage : Person
    {
        Student student;
        File fileStudent = new File();

        public StudentManage(Student student)
        {
            this.student = student;
        }

        public override void add()
        {
            // add Student
            fileStudent.ReadFileStudent("Student.txt", student);
            fileStudent.WriteFileStudent("Student.txt", student);
        }

        public override void view()
        {
            // view Student
            
            fileStudent.ReadFileStudent("Student.txt", student);
        }

        public override void delete()
        {
            // delete student
            fileStudent.ReadFileStudent("Student.txt", student);
            fileStudent.DeleteFileStudent("Student.txt", student);
        }

        public override void search()
        {
            // search student
            fileStudent.ReadFileStudent("Student.txt", student);
            fileStudent.SearchFileStudent("Student.txt", student);
        }

        public override void update()
        {
            // update student
            fileStudent.ReadFileStudent("Student.txt", student);
            fileStudent.UpdateFileStudent("Student.txt", student);
        }

        public  void Read()
        {
            fileStudent.ReadFileStudent("Student.txt", student);
        }
    }
}
