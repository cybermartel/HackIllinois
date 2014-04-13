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
        public int UNLOCK;
        public  int LOCK;
        public int LEFT = 0;
        public int RIGHT = 0 ;
        public int DOWN = 0 ;
        public int UP = 0;
        public void run()
        {        
            if(LEFT==1)
            {
                for (int i = 0; i < 10; i++)
                {
                    SendKeys.SendWait("{LEFT}");
                }
            }

            if(RIGHT==1)
            {
                for (int i = 0; i < 10; i++)
                {
                    SendKeys.SendWait("{RIGHT}");
                }
            }

            if(DOWN==1)
            {
                for (int i = 0; i < 10; i++)
                {
                    SendKeys.SendWait("{DOWN}");
                }
            }

            if(UP==1)
            {
                for (int i = 0; i < 10; i++)
                {
                    SendKeys.SendWait("{UP}");
                }
            }

            if(LOCK==1)
            {
                Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
            }
            }
        }

    }
