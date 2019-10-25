using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormControlManager.Models
{
    /// <summary>
    /// 鼠标事件
    /// </summary>
    public enum MouseEventFlag
    {
        /// <summary>
        /// 鼠标移动
        /// </summary>
        MOVE = 0x0001,

        /// <summary>
        /// 鼠标左键按下
        /// </summary>
        LEFTDOWN = 0x0002,

        /// <summary>
        /// 鼠标左键抬起
        /// </summary>
        LEFTUP = 0x0004,

        /// <summary>
        /// 鼠标右键按下 
        /// </summary>
        RIGHTDOWN = 0x0008,

        /// <summary>
        /// 鼠标右键抬起 
        /// </summary>
        RIGHTUP = 0x0010,

        /// <summary>
        /// 鼠标中键按下 
        /// </summary>
        MIDDLEDOWN = 0x0020,

        /// <summary>
        /// 鼠标中键抬起
        /// </summary>
        MIDDLEUP = 0x0040,

        /// <summary>
        /// 鼠标滚轮移动数量
        /// </summary>
        WHEEL = 0x0800,

        /// <summary>
        /// 参数dX，dy含有规范化的绝对坐标
        /// </summary>
        ABSOLUTE = 0x8000,


    }
}
