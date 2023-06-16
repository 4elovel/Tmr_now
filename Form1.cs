using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tmr_now
{
    public partial class Form1 : Form
    {
        private void ShowTime(object vObj, EventArgs e)
        {
            
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private static Timer vTimer = new Timer();
        public Form1()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToLongTimeString();
            vTimer.Tick += new EventHandler(ShowTime);
            vTimer.Interval = 1000;
            vTimer.Start();
        }
    }
}
