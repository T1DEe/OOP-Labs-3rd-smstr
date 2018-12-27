using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/Users/artemymarkovsky/Documents/Учебка/ООП (2к1с)/Лабы/OOP_Lab13/";
            Console.WriteLine(MAGDiskInfo.GetDiskInfo());
            MAGLog.Write(MAGDiskInfo.GetDiskInfo());

            Console.WriteLine(MAGFileInfo.GetFileInfo());
            MAGLog.Write(MAGFileInfo.GetFileInfo());
            Console.WriteLine(MAGFileInfo.GetPath());
            MAGLog.Write(MAGFileInfo.GetPath());
            Console.WriteLine(MAGFileInfo.GetTimeCreation());
            MAGLog.Write(MAGFileInfo.GetTimeCreation());

            Console.WriteLine(MAGDirInfo.GetCreationTime());
            MAGLog.Write(MAGDirInfo.GetCreationTime());
            Console.WriteLine(MAGDirInfo.GetDirCount());
            MAGLog.Write(MAGDirInfo.GetDirCount());
            Console.WriteLine(MAGDirInfo.GetFilesCount());
            MAGLog.Write(MAGDirInfo.GetFilesCount());
            Console.WriteLine(MAGDirInfo.GetDirList());
            MAGLog.Write(MAGDirInfo.GetDirList());
            MAGLog.Write("$Session - " + DateTime.Now.Date.ToString() + "$");

            MAGFileManager.MoveFiles(path);
            MAGFileManager.MoveDirectoriesByExtension(path, ".js");
            MAGFileManager.ToZip(path);

            Console.WriteLine("======================================");
            Console.WriteLine("============= FROM FILE ==============");
            Console.WriteLine($"============= COUNT: {MAGLog.GetRecordCount()}================");
            Console.WriteLine("======================================\n");
            Console.WriteLine(MAGLog.GetInfoByDay(DateTime.Now.Date));

            MAGLog.Close();

        }
    }
}