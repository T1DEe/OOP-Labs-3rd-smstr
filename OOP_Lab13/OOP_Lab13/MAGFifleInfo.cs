using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab13
{
    public static class MAGFileInfo
    {
        private const string path = @"/Users/artemymarkovsky/Documents/Учебка/ООП (2к1с)/Лабы/OOP_Lab13/maglogfile.txt";
        private static FileInfo fi;

        static MAGFileInfo() => fi = new FileInfo(path);

        public static string GetPath() => "Dir name " + fi.DirectoryName + '\n';

        public static string GetFileInfo()
        {
            string res = "";
            res += "Space " + fi.Length + '\n';
            res += "Extension " + fi.Extension + '\n';
            res += "Name " + fi.Name + "\n\n";
            return res;
        }

        public static string GetTimeCreation() => "Time creation " + fi.CreationTime.ToString() + "\n\n";
    }
}
