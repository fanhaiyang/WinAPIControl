using FormControlManager;
using FormControlManager.Manager;
using FormControlManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControl
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 程序路径
        /// </summary>
        public static string SourceAppPath = @"E:\workspace\WindowsFormsControl\WindowsFormView\bin\Debug\WindowsFormView.exe";

        /// <summary>
        /// 程序进程名称
        /// </summary>
        public static string ProcessName = "WindowsFormView";

        /// <summary>
        /// 程序主窗体句柄
        /// </summary>
        public static IntPtr MainWindows = IntPtr.Zero;

        public Form1()
        {
            InitializeComponent();

            // 通告进程名称获取Form2窗体进程
            Process[] p = Process.GetProcessesByName(ProcessName);
            if (p.Count() > 0)
            {
                Process mainProcess = p[0];
                Thread.Sleep(500);
                MainWindows = mainProcess.MainWindowHandle;
            }
            else
            {
                // 打开主窗体
                Process openPro = Process.Start(SourceAppPath);
                Thread.Sleep(500);
                MainWindows = openPro.MainWindowHandle;
            }
        }

        /// <summary>
        /// Form2确定按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ok_Btn_Click(object sender, EventArgs e)
        {
            if (MainWindows != IntPtr.Zero)
            {
                IntPtr handle = Command.Findview(MainWindows, null, "确定");
                // 单击
                Command.BtnLeftClick(handle);
                //// 按下左键
                //WinApiServer.SendMessage(handle, 0x0201, 0, 0);
                //// 释放左键
                //WinApiServer.SendMessage(handle, 0x0202, 0, 0);
            }
        }

        /// <summary>
        /// Form2取消按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancle_Btn_Click(object sender, EventArgs e)
        {
            //if (MainWindows != IntPtr.Zero)
            //{
            //    IntPtr handle = Command.Findview(MainWindows, null, "取消");
            //    //单击
            //    Command.BtnLeftClick(handle);
            //}

            // 调用FormControlManager
            ControlManager manager = new ControlManager();
            manager.BtnClickEvent("Form2", "取消", "groupBox1");
            MainWindows = ConfigConst.MainFormHandle;
        }

        /// <summary>
        /// Form3确定按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form3Ok_Btn_Click(object sender, EventArgs e)
        {
            // 获取Form3窗体句柄
            IntPtr form3Handle = WinApiServer.FindWindow(null, "Form3");
            if (form3Handle == IntPtr.Zero)
            {
                if (MainWindows != IntPtr.Zero)
                {
                    // Form2中"打开Form3"按钮句柄
                    IntPtr openForm3Handle = Command.Findview(MainWindows, null, "打开Form3");
                    // 打开Form3
                    Command.BtnLeftClick(openForm3Handle);
                    // 获取Form3窗体句柄
                    form3Handle = WinApiServer.FindWindow(null, "Form3");
                }

                // 如果为空，先打开Form2，层层递归，打开目标按钮所在窗体，获取按钮句柄，暂省略...
            }
            IntPtr form3OKHandle = Command.Findview(form3Handle, null, "这是Form3的确定按钮");
            // 单击
            Command.BtnLeftClick(form3OKHandle);
        }

        /// <summary>
        /// Form3取消按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form3Cancle_Btn_Click(object sender, EventArgs e)
        {
            // 获取Form3窗体句柄
            IntPtr form3Handle = WinApiServer.FindWindow(null, "Form3");
            if (form3Handle == IntPtr.Zero)
            {
                if (MainWindows != IntPtr.Zero)
                {
                    // Form2中"打开Form3"按钮句柄
                    IntPtr openForm3Handle = Command.Findview(MainWindows, null, "打开Form3");
                    // 打开Form3
                    Command.BtnLeftClick(openForm3Handle);
                    // 获取Form3窗体句柄
                    form3Handle = WinApiServer.FindWindow(null, "Form3");
                }
            }
            IntPtr form3CancleHandle = Command.Findview(form3Handle, null, "这是Form3的取消按钮");
            // 单击
            Command.BtnLeftClick(form3CancleHandle);
        }

        /// <summary>
        /// 测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string formName = this.FormName.Text;
            string buttonTxt = ButtonTxt.Text;
            // 调用FormControlManager
            ControlManager manager = new ControlManager();
            string result = manager.BtnClickEvent(formName, buttonTxt);
            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show(result);
            }
        }
    }
}
