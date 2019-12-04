using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace MeetingScheduler
{
    public partial class Form3 : Form
    {
        //attributes
        Participant current;
        Participants participants;
        List<DateTime> Preference, Exclusion;

        public Form3()
        {
            InitializeComponent();
            current = new Participant();
            participants = new Participants();
            participants.Load();

            List<DateTime> Preference = new List<DateTime>();
            List<DateTime> Exclusion = new List<DateTime>();
        }
        private void PrefCalendar1_DateSelected(object sender, DateRangeEventArgs p)
        {
            DateTime newDate = p.Start.Date;
            current.AddPreferenceDate(newDate);
            PrefCalendar1.AddBoldedDate(newDate);
            PrefCalendar1.UpdateBoldedDates();
        }
        private void ExcluCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime newEDate = e.Start.Date;
            current.AddExclusionDate(newEDate);
            ExcluCalendar1.AddBoldedDate(newEDate);
            ExcluCalendar1.UpdateBoldedDates();
        }

        private void SubmitParticipant_Click(object sender, EventArgs e)
        {
            current.SetName(textBox1.Text);
            string status = current.GetName() + ": Added! ";
            participants.Add(current);
            participants.SaveToFile(current);

            MessageBox.Show(status);
            Close();
        }
    }
}
