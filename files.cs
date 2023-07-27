using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace text_editor
{
    class files
    {
        static public void Save(string fileofname, string inputStr)
        {
            StreamWriter writefile = new StreamWriter(fileofname, true, Encoding.Unicode);
            writefile.WriteLine(inputStr);
            writefile.Close();
        }
        static public string Open(string fileofname)
        {
            string text = string.Empty; // NULL
            StreamReader readfile = new StreamReader(fileofname);
            while (!readfile.EndOfStream)
            {
                text += readfile.ReadLine() + "\n";
            }
            readfile.Close();
            return text;
        }
    }
}
