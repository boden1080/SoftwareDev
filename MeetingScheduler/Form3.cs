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
    public partial class Form3 : Form
    {
        //attributes
        Participant pete, john, phil, paul, Current;

        List<DateTime> Preference, Exclusion;

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        public Form3()
        {
            InitializeComponent();
            Participant pete = new Participant("Peter");
            Participant john = new Participant("John");
            Participant phil = new Participant("Phil");
            Participant paul = new Participant("Paul");
            Participant Current = new Participant();

            List<DateTime> Preference = new List<DateTime>();
            List<DateTime> Exclusion = new List<DateTime>();
            List<Participant> members = new List<Participant>();


            
            foreach(Participant p in members)
            {
                comboBox1.Items.Add(p);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Current = (Participant)comboBox1.SelectedItem;
            }
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            Preference.Add(e.Start);
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Current.SetPreference(Preference);
        }
    }
}
