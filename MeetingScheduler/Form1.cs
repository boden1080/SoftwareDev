using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingScheduler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMeeting_Click(object sender, EventArgs e)
        {
            Form2 scheduler = new Form2();
            scheduler.FormClosed += new FormClosedEventHandler(meeting_FormClosed);
            this.Hide();
            scheduler.Show();
        }
        void meeting_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void buttonPreferences_Click(object sender, EventArgs e)
        {
            Form3 settings = new Form3();
            settings.FormClosed += new FormClosedEventHandler(meeting_FormClosed);
            this.Hide();
            settings.Show();

        }
    }
}
