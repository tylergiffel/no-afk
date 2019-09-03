using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
using WindowsInput;

namespace NoAFK
{
    public partial class frmMain : Form
    {
        private System.Timers.Timer _clickTimer;
        private bool _started = false;
        delegate void SetTextCallback(string text);
        private Random _randomKey;


        public frmMain()
        {
            InitializeComponent();

            _clickTimer = new System.Timers.Timer(10000);
            _clickTimer.Enabled = false;
            _clickTimer.Elapsed += _clickTimer_Elapsed;

            _randomKey = new Random(4);
        }

        private void _clickTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _clickTimer.Stop();
            var random = new Random();
            int interval = random.Next(1000, 10000) * 60;
            //int interval = random.Next(1000, 10000);

            TimeSpan t = TimeSpan.FromMilliseconds(interval);

            var humanReadableLength = string.Format("{1:D2}:{2:D2}:{3:D3}",
                                    t.Hours,
                                    t.Minutes,
                                    t.Seconds,
                                    t.Milliseconds);

            SetTimerText(humanReadableLength);

            SendRandomKeys();

            _clickTimer.Interval = interval;

            _clickTimer.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(_started)
            {
                btnStart.Text = "Start";
                txtbxTimer.Text = "";
                _clickTimer.Stop();
                _started = false;
            }
            else
            {
                btnStart.Text = "Stop";
                _clickTimer.Start();
                _started = true;
                
            }
          

        }

        private void SendRandomKeys()
        {
            var inputSim = new InputSimulator();

          

            int rand = _randomKey.Next(4);

            var random = new Random();
            

            switch (rand)
            {
                case 0:
                    inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_W);
                    Thread.Sleep(random.Next(250, 2000));
                    inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_W);
                    break;
                case 1:
                    inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_A);
                    Thread.Sleep(random.Next(250, 2000));
                    inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_A);
                    break;
                case 2:
                    inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_S);
                    Thread.Sleep(random.Next(250, 2000));
                    inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_S);
                    break;
                case 3:
                    inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_D);
                    Thread.Sleep(random.Next(250, 2000));
                    inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_D);
                    break;
            }
            Thread.Sleep(300);
            
            inputSim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.SPACE);
        }

        private void SetTimerText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtbxTimer.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTimerText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtbxTimer.Text = text;
            }
        }

    }
}
