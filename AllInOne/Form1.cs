using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;     //线程

namespace AllInOne
{
    public partial class Form1 : Form
    {
        Thread workThread;
        static bool bFirstClickAutoRunBtn = false;
        static bool newStart = false;
        static int timeCount = 0;
        string strTimer;
        static int iReturnError = 0;
        static int iTestState = 0;  // 0:start 1:running 2:finish

        public Form1()
        {
            InitializeComponent();
            //设置窗体不能拉伸
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        void WorkThreadFunction()
        {
            while (true)
            {
                if (newStart == false)
                {
                    System.Threading.Thread.Sleep(1000);
                    continue;
                }
                iReturnError = MFCDll.AutoRunFunction();
                iTestState = 2;
                newStart = false;
            }
        }

        /************************************************************************/
        /* Auto run button                                                      */
        /************************************************************************/
        private void button_AutoRun_Click(object sender, EventArgs e)
        {
            //iReturnError = MFCDll.AutoRunFunction();
            //MFCDll.AutoRunFunction();
            //如果线程处于没有启动状态，则启动线程
            if (bFirstClickAutoRunBtn == false)
            {
                workThread = new Thread(new ThreadStart(WorkThreadFunction));
                workThread.Start();
                bFirstClickAutoRunBtn = true;
                //start the update UI timer
                this.UpdateUITimer.Start();
            }
            if (newStart == false)
            {
                System.Threading.Thread.Sleep(500);//ensure to enter the thread
                newStart = true;
                iTestState = 1;
                timeCount = 0;
            }
        }

        /************************************************************************/
        /* Debug button                                                         */
        /************************************************************************/
        private void button_Debug_Click(object sender, EventArgs e)
        {
            MFCDll.ShowDlg();
        }

        private void UpdateUITimer_Tick(object sender, EventArgs e)
        {
            this.UpdateUITimer.Stop();
            if (iTestState == 0)
            {
                this.TimerLabel.Text = "Read to test";
            }
            else if (iTestState == 1)
            {
                strTimer = timeCount.ToString();
                timeCount++;
                this.TimerLabel.Text = strTimer;
            }
            else
            {
                this.TimerLabel.Text = "Test Finish";
                UpdateUIResult(iReturnError);
            }
            //int setp = 0;
            //MFCDll.GetProcessStep(ref setp);
            //UpdateStep(setp);
            this.UpdateUITimer.Start();
        }

        /************************************************************************
         Close the form                                                                    
        ************************************************************************/
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MFCDll.ExternalCloseNI6509();
        }

        /************************************************************************
        update the UI result                                                                      
        ************************************************************************/
        private void UpdateUIResult(int resultCase)
        {
            switch(resultCase)
            {
                case 0:     //iReturnOK
                    this.TimerLabel.BackColor = Color.Green;
                    break;
                case 1:     //InitialNIFail
                    this.TimerLabel.BackColor = Color.Red;
                    this.TimerLabel.Text = "InitialNIFail";
                    break;
                case 2:     //WriteNIFail
                    this.TimerLabel.BackColor = Color.Red;
                    this.TimerLabel.Text = "WriteNIFail";
                    break;
                case 3:     //ReadNIFail
                    this.TimerLabel.BackColor = Color.Red;
                    this.TimerLabel.Text = "ReadNIFail";
                    break;
                case 4:     //SafetyStart
                    this.TimerLabel.BackColor = Color.Red;
                    this.TimerLabel.Text = "SafetyStart";
                    break;
            }

        }

        /************************************************************************
        update the prcoss                                                                    
        ************************************************************************/
         private void UpdateStep(int step)
        {
            switch (step)
            {
                case 0:
                    ShowMessage.Text = "InitialNI";
                    break;
                case 1:
                    ShowMessage.Text = "Check_Door_Carrier";
                    break;
                case 2:
                    ShowMessage.Text = "Open_Door";
                    break;
                case 3:
                    ShowMessage.Text = "Big_Carrier_Out";
                    break;
                case 4:
                    ShowMessage.Text = "Small_Carrier_Out";
                    break;
                case 5:
                    ShowMessage.Text = "Wait_Put_Dut";
                    break;
                case 6:
                    ShowMessage.Text = "Inhale";
                    break;
                case 7:
                    ShowMessage.Text = "Wait_Press_Start";
                    break;
                case 8:
                    ShowMessage.Text = "Small_Carrier_Back";
                    break;
                case 9:
                    ShowMessage.Text = "Big_Carrier_Back";
                    break;
                case 10:
                    ShowMessage.Text = "Close_Door";
                    break;
             }
        }
    }
}
