using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        private static long toGB = 1073741824;
        private static double toMB = 1048576;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Name\tTotalSize\tTotalFreeSpace");
                var drives = DriveInfo.GetDrives();
                foreach (var drive in drives)
                {
                    if(drive.IsReady)
                        Console.WriteLine(drive.Name + "\t" + drive.TotalSize / toGB + "." + 
                            Math.Round(drive.TotalSize % toGB / toMB) + "GB\t\t" + 
                            drive.TotalFreeSpace / toGB + "." + 
                            Math.Round(drive.TotalFreeSpace % toGB / toMB) +  "GB");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
