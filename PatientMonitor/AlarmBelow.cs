using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientMonitor
{
    public partial class AlarmBelow : Form
    {
        public AlarmBelow()
        {

            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        //add soundplayer function which will play a resource file
        SoundPlayer MutableAlarm = new SoundPlayer(ResourceAlarm.MutableAlarm);

        //add int value to work as a visable counter
        int i = 0;
        private void tmrBelowLimit_Tick(object sender, EventArgs e)
        {
            //play alarm sound when timer starts and command it to loop
            MutableAlarm.PlayLooping();
            i++;
            //convert int value to appear as text
            lblCounterBelow.Text = i.ToString() + " Seconds";
        }

        private void btnDisableBelow_Click(object sender, EventArgs e)
        {
            //stop the timer and alarm sound when user clicks disable
            tmrBelowLimit.Stop();
            MutableAlarm.Stop();
        }
    }
}
