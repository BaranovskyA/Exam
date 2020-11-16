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
                Console.WriteLine("Введите количество носителей, которое следует отобразить:");
                int count = int.Parse(Console.ReadLine());

                if(count > 0)
                {
                    Console.WriteLine($"Name\tTotalSize\tTotalFreeSpace");
                    var drives = DriveInfo.GetDrives();
                    var drivesCount = DriveInfo.GetDrives().Count();
                    for(int i = 0; i <= count; i++)
                    {
                        if (i == drivesCount)
                            break;
                        if (drives[i].IsReady)
                            Console.WriteLine(drives[i].Name + "\t" + drives[i].TotalSize / toGB + "." +
                                Math.Round(drives[i].TotalSize % toGB / toMB) + "GB\t\t" +
                                drives[i].TotalFreeSpace / toGB + "." +
                                Math.Round(drives[i].TotalFreeSpace % toGB / toMB) + "GB");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
