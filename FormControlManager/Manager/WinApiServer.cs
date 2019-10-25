using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FormControlManager.Models;

namespace FormControlManager.Manager
{
    public class WinApiServer
    {
        /// <summary>
        /// 随机声音
        /// </summary>
        /// <param name="frenquency">频率</param>
        /// <param name="duration">声音持续时间</param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frenquency, int duration);

        /// <summary>
        /// 系统声音
        /// </summary>
        /// <param name="beepType"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool MessageBeep(BeepType beepType);

        /// <summary>
        /// 将指定的消息发送到一个或多个窗口。
        /// 此函数为指定的窗口调用窗口程序，直到窗口程序处理完消息再返回。
        /// 而和函数PostMessage不同，PostMessage是将一个消息寄送到一个线程的消息队列后就立即返回。
        /// </summary>
        /// <param name="hwnd">其窗口程序将接收消息的窗口的句柄。如果此参数为HWND_BROADCAST，则消息将被发送到系统中所有顶层窗口，包括无效或不可见的非自身拥有的窗口、被覆盖的窗口和弹出式窗口，但消息不被发送到子窗口。</param>
        /// <param name="wMsg">指定被发送的消息。</param>
        /// <param name="wParam">指定附加的消息特定信息。</param>
        /// <param name="lParam">指定附加的消息特定信息。</param>
        /// <returns>返回值指定消息处理的结果，依赖于所发送的消息。</returns>
        /// 备注：需要用HWND_BROADCAST通信的应用程序应当使用函数RegisterWindowMessage来为应用程序间的通信取得一个唯一的消息。
        [DllImport("user32.dll", EntryPoint = "SendMessage", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// 将一个消息放入（寄送）到与指定窗口创建的线程相联系消息队列里，
        /// 不等待线程处理消息就返回，是异步消息模式。
        /// 消息队列里的消息通过调用GetMessage和PeekMessage取得。
        /// </summary>
        /// <param name="hwnd">其窗口程序接收消息的窗口的句柄。可取有特定含义的两个值：
        ///HWND_BROADCAST：消息被寄送到系统的所有顶层窗口，包括无效或不可见的非自身拥有的窗口、 被覆盖的窗口和弹出式窗口。消息不被寄送到子窗口
        ///NULL：此函数的操作和调用参数dwThread设置为当前线程的标识符PostThreadMessage函数一样</param>
        /// <param name="wMsg">指定被寄送的消息。</param>
        /// <param name="wParam">指定附加的消息特定的信息。</param>
        /// <param name="lParam">指定附加的消息特定的信息。</param>
        /// <returns>如果函数调用成功，返回非零，否则函数调用返回值为零</returns>
        [DllImport("user32.dll", EntryPoint = "PostMessage")]
        public static extern int PostMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// 鼠标事件
        /// </summary>
        /// <param name="dwFlags"></param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <param name="dwData"></param>
        /// <param name="dwExtraInfo"></param>
        [DllImport("user32.dll")]
        public extern static void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);

        /// <summary>
        /// 该函数合成一次击键事件。
        /// 系统可使用这种合成的击键事件来产生WM_KEYUP或WM_KEYDOWN消息，键盘驱动程序的中断处理程序调用keybd_event函数。
        /// 在Windows NT中该函数己被使用SendInput来替代它完成操作。
        /// </summary>
        /// <param name="bVk">定义一个虚拟键码。键码值必须在1～254之间。</param>
        /// <param name="bScan">定义该键的硬件扫描码。</param>
        /// <param name="dwFlags">定义函数操作的各个方面的一个标志位集。应用程序可使用如下一些预定义常数的组合设置标志位。
        /// KEYEVENTF_EXTENDEDKEY：若指定该值，则扫描码前一个值为OXEO（224）的前缀字节。 
        ///　KEYEVENTF_KEYUP：若指定该值，该键将被释放；若未指定该值，该键将被按下。</param>
        /// <param name="dwExtraInfo">定义与击键相关的附加的32位值。</param>
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);  //dwFlags是整数类型  0 为按下，2为释放 //dwExtraInfo是整数类型 一般情况下设成为 0 


        /// <summary>
        ///  查找句柄
        /// </summary>
        /// <param name="lpClassName">窗体类名</param>
        /// <param name="lpWindowName">窗体名称</param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// 在窗口列表中寻找与指定条件相符的第一个子窗口
        /// </summary>
        /// <param name="hwndParent">要查找的子窗口所在的父窗口的句柄</param>
        /// <param name="hwndChildAfter">子窗口句柄</param>
        /// <param name="lpszClass">指向一个指定了类名的空结束字符串，或一个标识类名字符串的成员的指针</param>
        /// <param name="lpszWindow">指向一个指定了窗口名（窗口标题）的空结束字符串。如果该参数为 NULL，则为所有窗口全匹配。</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
    }
}
