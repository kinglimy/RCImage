using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace FileDeleteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath;
            int deleteFileCount = 0;

            Image pic = null;

            Console.WriteLine("Enter file path");
            filePath = Console.ReadLine();

            Console.WriteLine("You entered:" + filePath);

            if (Directory.Exists(filePath))
            {
                DirectoryInfo folder = new DirectoryInfo(filePath);

                foreach (FileInfo file in folder.GetFiles("*.*", SearchOption.AllDirectories))
                {
                    if (file.Name.Substring(0, file.Name.Length - 4).Length > 7)
                    {
                        file.Delete();
                        deleteFileCount++;
                    }

                    try
                    {
                        pic = Image.FromFile(Path.GetFullPath(file.FullName));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(file.FullName + " " + ex.Message);
                        file.Delete();
                        deleteFileCount++;
                    }
                }
            }

            Console.WriteLine("You have deleted " + deleteFileCount + " files!");
            Console.ReadLine();
        }

        public static void DeleteFolder(string deleteDirectory)
        {
            if (Directory.Exists(deleteDirectory))
            {
                //foreach (string deleteFile in Directory.GetFileSystemEntries(deleteDirectory))
                //{
                //    if (File.Exists(deleteFile))
                //        //File.Delete(deleteFile);
                //        Console.WriteLine(deleteFile);
                //    //else
                //    //    DeleteFolder(deleteFile);
                //}

                //Directory.Delete(deleteDirectory);

                DirectoryInfo folder = new DirectoryInfo(deleteDirectory);

                 foreach (FileInfo file in folder.GetFiles("*.*", SearchOption.AllDirectories))
                 {
                     if (file.Name.Substring(0, file.Name.Length - 4).Length > 7)
                     {
                         file.Delete();
                     }
                 }
            }
        }  
    }
}
