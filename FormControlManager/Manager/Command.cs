using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FormControlManager.Models;

namespace FormControlManager.Manager
{
    public class Command
    {
        /// <summary>
        /// 检查主程序是否启动，若未启动，则启动
        /// </summary>
        /// <returns></returns>
        public static void CheckMainProcess()
        {
            // 通过进程名称获取窗体进程
            Process[] p = Process.GetProcessesByName(ConfigConst.ProcessName);
            if (p.Count() > 0)
            {
                Process mainProcess = p[0];
                Thread.Sleep(50);
                ConfigConst.MainFormHandle = mainProcess.MainWindowHandle;
            }
            else
            {
                // 打开主窗体
                Process openPro = Process.Start(ConfigConst.SourceAppPath);
                Thread.Sleep(50);
                ConfigConst.MainFormHandle = openPro.MainWindowHandle;
            }
        }

        /// <summary>
        /// 更新目标窗体句柄，由于窗体重开句柄会修改，所以需更新句柄
        /// </summary>
        /// <returns></returns>
        public static string UpdateSourceHandle(string formName)
        {
            string result = "";
            // 获取目标窗体句柄
            var sourceHandle = FindWindow(null, formName);
            if (sourceHandle != IntPtr.Zero)
            {
                ConfigConst.SourceFormHandle = sourceHandle;
            }
            else
            {
                result= "目标窗体已关闭，请打开";
            }
            return result;
        }

        /// <summary>
        ///  查找句柄
        /// </summary>
        /// <param name="lpClassName">窗体类名</param>
        /// <param name="lpWindowName">窗体名称</param>
        /// <returns></returns>
        public static IntPtr FindWindow(string classname, string windowName)
        {
            IntPtr hwndtemp = WinApiServer.FindWindow(classname, windowName);
            return hwndtemp;
        }

        /// <summary>
        /// 通告父级查找指定控件句柄
        /// </summary>
        /// <param name="parent">父句柄</param>
        /// <param name="classname"></param>
        /// <param name="text">为Null时则为所有窗口全匹配</param>
        /// <returns></returns>
        public static IntPtr Findview(IntPtr parent, string classname, string text)
        {
            IntPtr hwndtemp = WinApiServer.FindWindowEx(parent, IntPtr.Zero, classname, text);
            return hwndtemp;
        }

        /// <summary>
        /// 查找所有子控件-广度遍历
        /// </summary>
        /// <param name="parent"></param>
        /// <returns></returns>
        public static List<IntPtr> Findallchild(IntPtr parent)
        {
            List<IntPtr> allchild = new List<IntPtr>();
            allchild.Add(parent);   //第一个添加父句柄，最后再删除
            for (int i = 0; i < allchild.Count; i++)
            {
                IntPtr patenttemp = allchild[i];
                IntPtr hwnd = WinApiServer.FindWindowEx(patenttemp, IntPtr.Zero, null, null);
                while (hwnd != IntPtr.Zero)
                {
                    allchild.Add(hwnd);
                    hwnd = WinApiServer.FindWindowEx(patenttemp, hwnd, null, null);
                }
            }
            allchild.RemoveAt(0);
            return allchild;
        }

        /// <summary>
        /// 鼠标左键单击事件
        /// </summary>
        public static void BtnLeftClick(IntPtr handle)
        {
            // 按下左键
            WinApiServer.SendMessage(handle, 0x0201, 0, 0);
            // 释放左键
            WinApiServer.SendMessage(handle, 0x0202, 0, 0);
        }

        /// <summary>
        /// 系统提示音
        /// </summary>
        public static void SystemSound()
        {
            Random random = new Random();
            Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    WinApiServer.Beep(random.Next(500), 500);
                    WinApiServer.MessageBeep(BeepType.SimpleBeep);
                }
            });
        }
    }
}
