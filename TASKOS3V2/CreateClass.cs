using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace TASKOS3V2
{
    internal class CreateClass
    {
        public string name;
        public string description;

        public CreateClass(string Name, string Description)
        {
            name = Name;
            description = Description;

        }
        public void createfile() {
            FileStream fscreate = new FileStream(name + ".text", FileMode.Create);
            fscreate.Close();
        }
        public void writenfile(string description)
        {
            FileStream fswrite = new FileStream(name + ".text", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fswrite);
            sw.Write(description);
            sw.Flush();
            fswrite.Close();
        }
        public void readfile()
        {
            FileStream fsread = new FileStream(name + ".text", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsread);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string line = sr.ReadLine();
            while(line != null)
            {
                MessageBox.Show(line);
                line = sr.ReadLine();
            }
            fsread.Close();
        }
        public void deletefile() {

            if (File.Exists(name + ".text"))
            {
                File.Delete(name + ".text");
                if(File.Exists(name +".text")==false)
                {
                    MessageBox.Show("File is Deleted");
                }
            }
        }
    }
}
