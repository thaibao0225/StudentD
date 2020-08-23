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

        public void WriteFile(string file)
        {
            String filepath = file;// đường dẫn của file muốn tạo
            FileStream fs = new FileStream(filepath, FileMode.Create);//Tạo file mới tên là test.txt            
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 
            // y is line , x is obj

            sWriter.WriteLine("1");
            sWriter.Write("2");



            MessageBox.Show("Successful!!!", "Succes", MessageBoxButtons.OK);
            // Ghi và đóng file
            sWriter.Flush();
            fs.Close();
        }

        public void ReadFile()
        {

        }

        private int CountLine(string file)
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
                    //MessageBox.Show(lineCounter.ToString(), "ok", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't countline!!!", "Infor", MessageBoxButtons.OK);
            }

            return (int)lineCounter;
        }
    }
}
