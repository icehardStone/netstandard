//--------------------------------------------------------------------------------------------------------------------------
// Copyrgith iceharstone
// @Ttitle:    
// @DateTime:  2020-01-04 21:27
// @Author:    胡光华
//---------------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;

namespace sample_filesystemwatcher
{
    public class File_System_Watcher
    {
        public FileSystemWatcher watcher{set;get;}

        public File_System_Watcher(string filepath)
        {
            watcher = new FileSystemWatcher();

            // 监控文件或者目录路径
            watcher.Path = filepath;
            watcher.Filter = ".json";
            watcher.NotifyFilter = NotifyFilters.FileName     //文件名称
                             | NotifyFilters.LastAccess //上次接入
                             | NotifyFilters.LastWrite  //上次写入
                             | NotifyFilters.Size;      //文件大小
            watcher.Renamed += OnRenamed;           // 重命名文件
            watcher.Changed += OnChanged;            // 改变文件
            watcher.Deleted += OnDeleted;           // 删除文件
            watcher.Error   += OnErrored;             // 文件错误

        }
        public static void OnRenamed(object source, RenamedEventArgs evt )
        {
            Console.WriteLine("Rename File");
        }
        public static void OnChanged(object source, FileSystemEventArgs evt)
        {
            Console.WriteLine("Changed File");
        }
        public static void OnDeleted(object source,FileSystemEventArgs evt)
        {
            Console.WriteLine("Deleted File");
        }
        public static void OnErrored(object source, ErrorEventArgs evt)
        {
            Console.WriteLine("OnErrored File");
        }
    }
}