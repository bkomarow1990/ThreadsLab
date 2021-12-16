using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadLab
{
    public partial class Form1 : Form
    {
        Thread[] threads = null;
        EventWaitHandle[] waitHandlers = null;
        bool[] states = null;
        private bool isStart = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (countNumeric.Value <= 0)
            {
                MessageBox.Show("Count of threads must be more than 0");
                return;
            }
            if (isStart)
            {
                numsListBox.Items.Clear();
            }
            ParameterizedThreadStart threadstart = new ParameterizedThreadStart(NumsPrint);
            threads = new Thread[(int)countNumeric.Value];
            waitHandlers = new ManualResetEvent[(int)countNumeric.Value];
            states = new bool[(int)countNumeric.Value];
            for (int i = 0; i < countNumeric.Value; i++)
            {
                threads[i] = new Thread(threadstart);
                threads[i].IsBackground = true;
                waitHandlers[i] = new ManualResetEvent(initialState: true);
                states[i] = false;
            }
            for (int i = 0; i < countNumeric.Value; i++)
            {
                threads[i].Start((object)(i+1));
            }
            isStart = !isStart;
        }
        private void NumsPrint(object obj)
        {
            int thread_index = (obj as int?).GetValueOrDefault()-1;
            int i = thread_index * 100;
            while (true)
            {
            
                waitHandlers[thread_index].WaitOne();
                lock (this) { 
                    this.Invoke(new Action(() =>
                    {
                        numsListBox.Items.Add(++i);
                    }));
                }
            }
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            
            int index = (int)threadNumberNumeric.Value;
            if (index < 0 || index>=states.Length)
            {
                MessageBox.Show("Incorrect index of thread number which you want to pause/resume");
                return;
            }
            states[index] = !states[index];
            if (states[index])
            {
                waitHandlers[index].Reset();
                return;
            }
            waitHandlers[index].Set();
        }
    }
}
