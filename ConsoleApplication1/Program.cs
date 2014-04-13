using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;



namespace ConsoleApplication1
{
    class Program
    {
        public static void Main()
        {
            int sleep = 0;
           int left = 0;
           int right = 0 ;
            int down = 1 ;
            int up = 0;
            int a = 3;
            while(a>0)
            {
            if(left==1)
            {
                for (int i = 0; i < 10; i++)
                {
                    SendKeys.SendWait("{LEFT}");
                }
            }

            if(right==1)
            {
                for (int i = 0; i < 10; i++)
                {
                    SendKeys.SendWait("{RIGHT}");
                }
            }

            if(down==1)
            {
                for (int i = 0; i < 10; i++)
                {
                    SendKeys.SendWait("{DOWN}");
                }
            }

            if(up==1)
            {
                for (int i = 0; i < 10; i++)
                {
                    SendKeys.SendWait("{UP}");
                }
            }

            if(sleep==1)
            {
                Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
            }
            a--;
            }
        }

    }
}
