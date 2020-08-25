using System;
using System.Collections.Generic;
using System.Text;

namespace StudentD
{
    class LecturerManage : Person
    {
        Lecturer lecturer;
        File fileLectuer = new File();
        public LecturerManage(Lecturer lecturer)
        {
            this.lecturer = lecturer;
        }

        public override void add()
        {
            // add Lecturer
            fileLectuer.ReadFileLecturer("Lecturer.txt", lecturer);
            fileLectuer.WriteFileLecturer("Lecturer.txt", lecturer);

        }

        public override void view()
        {
            // view Lecturer
            fileLectuer.ReadFileLecturer("Lecturer.txt", lecturer);
        }

        public override void delete()
        {
            // delete Lecturer
            fileLectuer.ReadFileLecturer("Lecturer.txt", lecturer);
            fileLectuer.DeleteFileLecturer("Lecturer.txt", lecturer);
        }

        public override void search()
        {
            // search Lecturer
            fileLectuer.ReadFileLecturer("Lecturer.txt", lecturer);
            fileLectuer.SearchFileLecturer("Lecturer.txt", lecturer);
        }

        public override void update()
        {
            // update Lecturer
            fileLectuer.ReadFileLecturer("Lecturer.txt", lecturer);
            fileLectuer.UpdateFileLecturer("Lecturer.txt", lecturer);
        }

        public void Read()
        {
            fileLectuer.ReadFileLecturer("Lecturer.txt", lecturer);
        }
    }
}


