using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;//DllImport

namespace AllInOne
{
    class MFCDll
    {
        [DllImport("AllInOneDll.dll")]
        public static extern void ShowDlg();

        [DllImport("AllInOneDll.dll")]
        public static extern int AutoRunFunction();

        [DllImport("AllInOneDll.dll")]
        public static extern int ExternalCloseNI6509();

        [DllImport("AllInOneDll.dll")]
        public static extern int GetProcessStep(ref int setp);

    }
}
