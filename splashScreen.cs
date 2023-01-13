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

namespace Biblioteka
{
    public partial class splashScreen : Form
    {
        Thread th;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public splashScreen()
        {
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            timer.Interval = 2000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            InitializeComponent();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            th.Start();
            this.Close();
        }
        private void opennewform(object obj)
        {
            Application.Run(new mainMenuForm());
        }
    }
}
