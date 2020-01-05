# FileSystemWatcher 类
## &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;用于[FileSystemWatcher](https://docs.microsoft.com/zh-cn/dotnet/api/system.io.filesystemwatcher?redirectedfrom=MSDN&view=netcore-3.1)类监视目录中的更改。可以监视目录中的文件和子目录的更改。你可以创建一个组件，用于监视本地计算机，网络驱动器或者远程计算机上的文件。
  
  * 监视所有文件中的更改，[Filter]() 属性设置为空字符串 [("")]() 或者使用通配符号 [("*.*")]() .若要查看特定文件，请将[Filter]() 属性设置为特定文件名。
  * 可以监视目录或者文件中的[重命名](),[删除](),或者[创建](),例如，
  
## 使用FileSystemWatcher类时候，注意以下各项
  * 不会忽略隐藏的文件
  * 某些系统中的[FileSystemWatcher]()使用短文件格式对文件进行更改。
  * 此类包含应用于所有成员的类级别的链接要求和继承要求。当直接调用方法或者派生类不具有完全信任权限的时候u。
  * 可为[InternalBufferSize]()通过网络监视目录的属性设置的最大大小为 **64kb**

## 若要通知文件夹内容已经移动或者复制到监视的文件夹，请提供[OnChanged]()下表所描述的和[OnRenamed]()事件处理方法

| 事件处理程序 | 处理的事件 | 担任   |
| :------      | :------   | :------ |
| OnChanged   | Changed,Created,Deleted | 报告文件属性的更改，创建的文件和删除的文件 |
| OnRenamed   | Renamed | 列出重命名的文件和文件夹的新路径，如果需要，请进行递归扩展  |

## 示例:
``` C#
using System;
using System.IO;
using System.Security.Permissions;

public class Watcher
{
    public static void Main()
    {
        Run();
    }

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    private static void Run()
    {
        string[] args = Environment.GetCommandLineArgs();

        // If a directory is not specified, exit program.
        if (args.Length != 2)
        {
            // Display the proper way to call the program.
            Console.WriteLine("Usage: Watcher.exe (directory)");
            return;
        }

        // Create a new FileSystemWatcher and set its properties.
        using (FileSystemWatcher watcher = new FileSystemWatcher())
        {
            watcher.Path = args[1];

            // Watch for changes in LastAccess and LastWrite times, and
            // the renaming of files or directories.
            watcher.NotifyFilter = NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.FileName
                                 | NotifyFilters.DirectoryName;

            // Only watch text files.
            watcher.Filter = "*.txt";

            // Add event handlers.
            watcher.Changed += OnChanged;
            watcher.Created += OnChanged;
            watcher.Deleted += OnChanged;
            watcher.Renamed += OnRenamed;

            // Begin watching.
            watcher.EnableRaisingEvents = true;

            // Wait for the user to quit the program.
            Console.WriteLine("Press 'q' to quit the sample.");
            while (Console.Read() != 'q') ;
        }
    }

    // Define the event handlers.
    private static void OnChanged(object source, FileSystemEventArgs e) =>
        // Specify what is done when a file is changed, created, or deleted.
        Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");

    private static void OnRenamed(object source, RenamedEventArgs e) =>
        // Specify what is done when a file is renamed.
        Console.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}");
}
```