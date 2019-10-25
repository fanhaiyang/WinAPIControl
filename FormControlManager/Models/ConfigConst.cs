using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormControlManager.Models
{
    public class ConfigConst
    {
        /// <summary>
        /// 程序路径
        /// </summary>
        public static string SourceAppPath = ConfigurationManager.AppSettings["SourceAppPath"].ToString();

        /// <summary>
        /// 程序进程名称
        /// </summary>
        public static string ProcessName = ConfigurationManager.AppSettings["ProcessName"].ToString();

        /// <summary>
        /// 程序主窗体句柄
        /// </summary>
        public static IntPtr MainFormHandle = IntPtr.Zero;

        /// <summary>
        /// 目标窗体句柄
        /// </summary>
        public static IntPtr SourceFormHandle = IntPtr.Zero;
    }
}
