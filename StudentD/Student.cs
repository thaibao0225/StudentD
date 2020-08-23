using System;
using System.Collections.Generic;
using System.Text;

namespace StudentD
{
    class Student
    {
        string stdId;
        string stdName;
        string stdDoB;
        string stdEmail;
        string stdBatch;

        public Student()
        {

        }

        public Student(string stdId, string stdName, string stdDoB, string stdEmail, string stdBatch)
        {

        }

        public string StdId { get => stdId; set => stdId = value; }
        public string StdName { get => stdName; set => stdName = value; }
        public string StdDoB { get => stdDoB; set => stdDoB = value; }
        public string StdEmail { get => stdEmail; set => stdEmail = value; }
        public string StdBatch { get => stdBatch; set => stdBatch = value; }
    }
}

