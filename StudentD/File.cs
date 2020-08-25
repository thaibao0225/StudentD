using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StudentD
{
    class File
    {
        public File()
        {

        }


        //---------------------------------------------Student----------------------------------------------
        public void WriteFileStudent(string file, Student student)
        { 
            String filepath = file;// đường dẫn của file muốn tạo
            FileStream fs = new FileStream(filepath, FileMode.Create);//Tạo file mới tên là test.txt   
            

            string[,] str1 = student.StdArr;

            int countLine = str1.GetLength(0);

            

            string[,] str = new string[countLine + 2 ,10];

            // chuyen str1 sang str
            if (countLine != 0)
            {
                for (int i = 0; i < countLine; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        str[i, j] = str1[i, j];
                    }
                }
            }


            str[countLine, 0] = student.StdId;
            str[countLine, 1] = student.StdName;
            str[countLine, 2] = student.StdDoB;
            str[countLine, 3] = student.StdEmail;
            str[countLine, 4] = student.StdAddress;
            str[countLine, 5] = student.StdBatch;


            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 
                                                                       // y is line , x is obj


            if (countLine == -1) countLine = 0;

            for (int i = 0; i < countLine + 1; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    sWriter.Write(str[i, j]);
                    string test = str[i, j];
                    sWriter.Write("|");
                }
                sWriter.WriteLine();
            }

            student.StdArr = str;

            MessageBox.Show("Successful!!!", "Succes", MessageBoxButtons.OK);
            // Ghi và đóng file
            sWriter.Flush();
            fs.Close();
        }

        public void ReadFileStudent(string file, Student student)
        {
            try
            {
                int count = CountLine(file);

                string[] datafile = new string[count];
                string[,] str = new string[count, 7];

                // danh cho datafile
                int counti = 0;

                using (StreamReader sr = new StreamReader(file))
                {
                    string line;

                    //doc va hien thi cac dong trong file cho toi
                    // khi tien toi cuoi file.
                    while ((line = sr.ReadLine()) != null)
                    {
                        //dua tung hang vao bien chuoi tong 
                        datafile[counti] = line;

                        student.StdArrClo = SliptString(datafile, counti);


                        for (int j = 0; j < 6; j++)
                        {
                            str[counti,j] = student.StdArrClo[j];
                        }
                            
                        counti++;
                    }
                }

                student.StdArr = str;
            }
            catch (Exception e)
            {
                //thong bao loi 
                MessageBox.Show("Can not read datafile!", "Infor", MessageBoxButtons.OK);
            }
        }

        public void DeleteFileStudent(string file, Student student)
        {
            String filepath = file;// đường dẫn của file muốn tạo
            FileStream fs = new FileStream(filepath, FileMode.Create);//Tạo file mới tên là test.txt   


            string[,] str1 = student.StdArr;

            int countLine = str1.GetLength(0);

            string[,] str = new string[countLine + 2, 10];

            string[,] tamArr = new string[countLine + 2, 10];

            // chuyen str1 sang str
            if (countLine != 0)
            {
                for (int i = 0; i < countLine; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        tamArr[i, j] = str1[i, j];
                    }
                }
            }

            // giai doan xoa
            int iStr = 0;
            int iTamArr = 0;

            do
            {

                if (tamArr[iStr, 0] == student.StdId)
                {
                    iTamArr++;
                }
                for (int j = 0; j < 7; j++)
                {
                    str[iStr, j] = tamArr[iTamArr, j];
                }

                iStr++;
                iTamArr++;
            }
            while (iStr != countLine - 1);



            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 
            // y is line , x is obj



            for (int i = 0; i < countLine - 1; i++)

            {
                for (int j = 0; j < 6; j++)
                {
                    //sWriter.Write(str[i, j]);
                    sWriter.Write(str[i, j]);
                    //string test = str[i, j];
                    sWriter.Write("|");
                }
                sWriter.WriteLine();
            }

            //student.StdArr = str;
            student.StdArr = str;



            MessageBox.Show("Successful!!!", "Succes", MessageBoxButtons.OK);

            // Ghi và đóng file
            sWriter.Flush();
            fs.Close();
        }

        public void UpdateFileStudent(string file, Student student)
        {
            String filepath = file;// đường dẫn của file muốn tạo
            FileStream fs = new FileStream(filepath, FileMode.Create);//Tạo file mới tên là test.txt   


            string[,] str1 = student.StdArr;

            int countLine = str1.GetLength(0);

            string[,] str = new string[countLine + 2, 10];

            string[,] tamArr = new string[countLine + 2, 10];

            // chuyen str1 sang str
            if (countLine != 0)
            {
                for (int i = 0; i < countLine; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        tamArr[i, j] = str1[i, j];
                    }
                }
            }

            // giai doan xoa
            int iStr = 0;

            do
            {

                if (tamArr[iStr, 0] == student.StdId)
                {
                    //iTamArr++;
                    //str[iStr, 0] = student.StdId;
                    str[iStr, 1] = student.StdName;
                    str[iStr, 2] = student.StdDoB;
                    str[iStr, 3] = student.StdEmail;
                    str[iStr, 4] = student.StdAddress;
                    str[iStr, 5] = student.StdBatch;

                }
                else
                {
                    for (int j = 0; j < 7; j++)
                    {
                        str[iStr, j] = tamArr[iStr, j];
                    }
                }
                
                iStr++;
                
            }
            while (iStr != countLine );

            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 
            // y is line , x is obj

            for (int i = 0; i < countLine; i++)

            {
                for (int j = 0; j < 6; j++)
                {
                    sWriter.Write(str[i, j]);
                    sWriter.Write("|");
                }
                sWriter.WriteLine();
            }

            //student.StdArr = str;
            student.StdArr = str;



            MessageBox.Show("Successful!!!", "Succes", MessageBoxButtons.OK);

            // Ghi và đóng file
            sWriter.Flush();
            fs.Close();
        }

        public void SearchFileStudent(string file, Student student)
        {
            String filepath = file;// đường dẫn của file muốn tạo
            //FileStream fs = new FileStream(filepath, FileMode.Create);//Tạo file mới tên là test.txt   

            string[,] str1 = student.StdArr;

            int countLine = str1.GetLength(0);

            string[,] tamArr = new string[countLine + 2, 10];

            // chuyen str1 sang str
            if (countLine != 0)
            {
                for (int i = 0; i < countLine; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        tamArr[i, j] = str1[i, j];
                    }
                }
            }

            for(int i = 0; i< countLine; i++ )
            {
                if (tamArr[i, 1] == student.StdSearch)
                {
                    student.StdId = tamArr[i, 0];
                    student.StdName = tamArr[i, 1];
                    student.StdDoB = tamArr[i, 2];
                    student.StdEmail = tamArr[i, 3];
                    student.StdAddress = tamArr[i, 4];
                    student.StdBatch = tamArr[i, 5];
                }
            }
        }
        //---------------------------------------------Student----------------------------------------------

        //---------------------------------------------Lecturer----------------------------------------------

        public void ReadFileStudent(string file, Student student)
        {
            try
            {
                int count = CountLine(file);

                string[] datafile = new string[count];
                string[,] str = new string[count, 7];

                // danh cho datafile
                int counti = 0;

                using (StreamReader sr = new StreamReader(file))
                {
                    string line;

                    //doc va hien thi cac dong trong file cho toi
                    // khi tien toi cuoi file.
                    while ((line = sr.ReadLine()) != null)
                    {
                        //dua tung hang vao bien chuoi tong 
                        datafile[counti] = line;

                        student.StdArrClo = SliptString(datafile, counti);


                        for (int j = 0; j < 6; j++)
                        {
                            str[counti, j] = student.StdArrClo[j];
                        }

                        counti++;
                    }
                }

                student.StdArr = str;
            }
            catch (Exception e)
            {
                //thong bao loi 
                MessageBox.Show("Can not read datafile!", "Infor", MessageBoxButtons.OK);
            }
        }

        //---------------------------------------------Lecturer----------------------------------------------

        public int CountLine(string file)
        {
            var lineCounter = 0L;
            try
            {
                using (var reader = new StreamReader(file))
                {
                    while (reader.ReadLine() != null)
                    {
                        lineCounter++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't countline!!!", "Infor", MessageBoxButtons.OK);
            }


            return (int)lineCounter;
        }


        private string [] SliptString(string [] datafile, int index)
        {
            string[] stringArr;

            stringArr = new string[7];

            stringArr = datafile[index].Split('|');

            return stringArr ;
        }
    }
}
