using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsIOSerialize.IO
{
    public class MyIO
    {
        private static string LogPath = ConfigurationManager.AppSettings["LogPath"];
        private static string LogMovePath = ConfigurationManager.AppSettings["LogMovePath"];


        public static void Show() {
            //{
            //    if (!Directory.Exists(LogPath))
            //    { //检测文件夹是否存在 
            //        Console.WriteLine("文件夹不存在");
            //        return;
            //    }
            //    //不存在也不会报错
            //    DirectoryInfo directory = new DirectoryInfo(LogPath);
            //    Console.WriteLine(string.Format("文件夹路径：{0}；文件夹创建时间： {1}；文件夹最后修改时间： {2}", directory.FullName,directory.CreationTime,directory.LastWriteTime));
                
            //    if (!File.Exists(Path.Combine(LogPath,"info.txt"))) {
            //        Console.WriteLine("文件不存在");
            //        return;
            //    }
            //    FileInfo fileInfo = new FileInfo(Path.Combine(LogPath, "info.txt"));
            //    Console.WriteLine(string.Format("文件路径：{0}；文件创建时间： {1}；文件最后修改时间： {2}", directory.FullName, directory.CreationTime, directory.LastWriteTime));
            //}
            //{
            //    if (!Directory.Exists(LogPath)) {
            //        //一次性创建全部子路径
            //        DirectoryInfo directoryInfo = Directory.CreateDirectory(LogPath);
            //    }
            //    //移动文件夹
            //    Directory.Move(LogMovePath, LogPath);
            //    //删除空文件夹
            //    Directory.Delete(LogPath);
            //}
            { 
            
            }
        }
    }
}
