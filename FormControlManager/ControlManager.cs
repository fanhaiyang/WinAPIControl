using FormControlManager.Manager;
using FormControlManager.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FormControlManager
{
    public class ControlManager
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ControlManager()
        {
            Command.CheckMainProcess();
        }

        /// <summary>
        /// 按钮单击事件
        /// </summary>
        /// <param name="sourceFormName">目标窗体名称</param>
        /// <param name="btnName">目标按钮名称</param>
        public string BtnClickEvent(string sourceFormName, string btnName, string pannelName = "")
        {
            string result = "";
            Command.CheckMainProcess();

            // 更新目标窗体句柄
            result = Command.UpdateSourceHandle(sourceFormName);
            if (!string.IsNullOrEmpty(result))
            {
                return result;
            }

            // 获取目标容器句柄
            IntPtr handle = Command.Findview(ConfigConst.SourceFormHandle, null, pannelName);
            if (handle != IntPtr.Zero)
            {
                // 获取目标按钮句柄
                IntPtr handleBtn = Command.Findview(handle, null, btnName);
                // 单击
                Command.BtnLeftClick(handleBtn);
            }
            else
            {
                result = "无法找到目标按钮";
            }
            return result;
        }
    }
}
