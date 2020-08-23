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

        public string LecId { get => lecId; set => lecId = value; }
        public string LecName { get => lecName; set => lecName = value; }
        public string LecDoB { get => lecDoB; set => lecDoB = value; }
        public string LecEmail { get => lecEmail; set => lecEmail = value; }
        public string LecBatch { get => lecBatch; set => lecBatch = value; }
        public string LecAddress { get => lecAddress; set => lecAddress = value; }

        public Lecturer()
        {

        }

        public Lecturer(string lecId, string lecName, string lecDoB, string lecEmail, string lecBatch)
        {

        }

        
    }
}
