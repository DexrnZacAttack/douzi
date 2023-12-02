﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PintoNS.General
{
    public class PInvoke
    {
        public const int SC_RESTORE = 0xF120;
        public const int WM_SYSCOMMAND = 0x0112;
        public const int MF_STRING = 0x00;
        public const int MF_SEPARATOR = 0x0800;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool AppendMenu(IntPtr hMenu, int uFlags, int uIDNewItem, string lpNewItem);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool InsertMenu(IntPtr hMenu, int uPosition, int uFlags, int uIDNewItem, string lpNewItem);

        [DllImport("ntdll.dll", EntryPoint = "wine_get_version")]
        public static extern string GetWineVersion();
    }
}
