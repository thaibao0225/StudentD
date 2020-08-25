using System;
using System.Collections.Generic;
using System.Text;

namespace StudentD
{
    class Lecturer
    {
        string lecId;
        string lecName;
        string lecDoB;
        string lecAddress;
        string lecEmail;
        string lecBatch;

        string lecSearch;

        string[] lecArr;

        string[] lecArrClo;


        public string LecId { get => lecId; set => lecId = value; }
        public string LecName { get => lecName; set => lecName = value; }
        public string LecDoB { get => lecDoB; set => lecDoB = value; }
        public string LecEmail { get => lecEmail; set => lecEmail = value; }
        public string LecBatch { get => lecBatch; set => lecBatch = value; }
        public string LecAddress { get => lecAddress; set => lecAddress = value; }
        public string[] LecArr { get => lecArr; set => lecArr = value; }
        public string LecSearch { get => lecSearch; set => lecSearch = value; }
        public string[] LecArrClo { get => lecArrClo; set => lecArrClo = value; }

        public Lecturer()
        {

        }

        public Lecturer(string lecId, string lecName, string lecDoB, string lecEmail, string lecBatch)
        {

        }

        
    }
}
