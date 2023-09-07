﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPrograms
{
    internal class FileHandling
    {
        public void CreateFile()
        {
            FileInfo fi = new
                FileInfo("Sample.txt");
            using StreamWriter str = fi.CreateText();
            Console.WriteLine("File has been created");

            str.WriteLine("hello There");
            str.WriteLine("HI");
            Console.WriteLine("Written");

        }
        public void DeleteFile()
        {
            FileInfo fi = new
               FileInfo("Sample.txt");
            fi.Delete();
        }
        public void CopyMoveFile()
        {
            FileInfo fi1 = new FileInfo("Sample.txt");
            // Copy the first file to the second file
            fi1.CopyTo("C:\\Users\\vmuser\\Desktop\\Temp\\Sample.txt");
            fi1.MoveTo("C:\\Users\\vmuser\\Desktop\\Temp2\\Sample.txt");
        }
        public void WriteData()
        {
            FileStream fs = new FileStream("Sample.txt",
                FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the text which " +
                "you want to write to the file");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void ReadData()
        {
            FileStream fs = new FileStream("Sample.txt",
                FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        public void FileProperties()
        {
            FileInfo fi = new FileInfo("Sample.txt");
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.Length.ToString());
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.Exists);
            Console.WriteLine(fi.LastWriteTime);

        }
    }
}
