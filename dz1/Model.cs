using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    public class Model : IModel
    {
        public string Result { get; set; }
        
        public void Save()
        {
            StreamWriter sw = new StreamWriter("file.txt", true);
            sw.WriteLine(Result);
            sw.Close();
        }
        public void Load()
        {
            try
            {
                StreamReader sr = new StreamReader("file.txt", Encoding.UTF8);
                if (sr != null)
                    Result = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception)
            {

            }
        }
        public void Search()
        {
            try
            {
                string temp = "";
                StreamReader sr = new StreamReader("file.txt", Encoding.UTF8);
                if (sr != null)
                {
                    temp = sr.ReadToEnd();
                }
                sr.Close();
                List<string> strings = new List<string>(temp.Split('\n'));
                temp = "";
                foreach (string s in strings)
                {
                    if (s.Contains(Result))
                        temp += s + "\n";
                }
                Result = temp;
            }
            catch(Exception)
            {

            }
        }
    }
}
