using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace UnmanageCodeLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        public int X;
        public int Y;
    }

    [SecurityCritical]
    public class PInvokeExample : MarshalByRefObject
    {
        [DllImport("user32.dll")]
        static extern long SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point point);

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public void DoInvokeWork() {
            /*Thread.Sleep(1000);
            SetCursorPos(300, 200);*/

            var point = new Point { X = 0, Y = 0 };
            GetCursorPos(ref point);

            Console.WriteLine($"{nameof(point.X)} : {point.X}");
            Console.WriteLine($"{nameof(point.Y)} : {point.Y}");

            point.X = 1910;
            point.Y = 5;

            SetCursorPos(point.X, point.Y);
            Console.WriteLine($"{nameof(point.X)} : {point.X}");
            Console.WriteLine($"{nameof(point.Y)} : {point.Y}");

            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, point.X, point.Y, 0, 0);
        }
    }
}
