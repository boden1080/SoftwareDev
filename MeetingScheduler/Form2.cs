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
using static System.Windows.Forms.CheckedListBox;

namespace MeetingScheduler
{
    public partial class Form2 : Form
    {
        //attributes
        Setup session;
        Meetings meetings;
        Meeting meeting;

        public Form2()
        {
            InitializeComponent();
            session = new Setup();
            meetings = new Meetings();
            meeting = new Meeting();
            

            //button disables
            monthCalendar1.Enabled = false;
            buttonTime1.Enabled = false;
            buttonTime2.Enabled = false;
            buttonTime3.Enabled = false;
            buttonTime4.Enabled = false;
            buttonTime5.Enabled = false;
            buttonSubmit.Enabled = false;

            //populate checkbox
            checkedListBox1.Items.Add("Projector");
            checkedListBox1.Items.Add("Television");
            checkedListBox1.Items.Add("Whiteboard");
        }

        private void room1Button_Click(object sender, EventArgs e)
        {
            //session.RoomSelected(1);
            meeting.SetRoom(1);
            UpdateForm();
        }

        private void room2Button_Click(object sender, EventArgs e)
        {
            //session.RoomSelected(2);
            meeting.SetRoom(2);
            UpdateForm();
        }

        private void room3Button_Click(object sender, EventArgs e)
        {
            //session.RoomSelected(3);
            meeting.SetRoom(3);
            UpdateForm();
        }

        private void room4Button_Click(object sender, EventArgs e)
        {
            //session.RoomSelected(4);
            meeting.SetRoom(4);
            UpdateForm();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar1.SelectionStart.Date;
            meeting.SetDate(date);
            UpdateForm();
        }

        private void buttonTime1_Click(object sender, EventArgs e)
        {
            //session.TimeSelected(10);
            meeting.SetTime(10);
            UpdateForm();
        }

        private void buttonTime2_Click(object sender, EventArgs e)
        {
            //session.TimeSelected(11);
            meeting.SetTime(11);
            UpdateForm();
        }

        private void buttonTime3_Click(object sender, EventArgs e)
        {
            //session.TimeSelected(12);
            meeting.SetTime(12);
            UpdateForm();
        }

        private void buttonTime4_Click(object sender, EventArgs e)
        {
            //session.TimeSelected(13);
            meeting.SetTime(13);
            UpdateForm();
        }

        private void buttonTime5_Click(object sender, EventArgs e)
        {
            //session.TimeSelected(14);
            meeting.SetTime(14);
            UpdateForm();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            CheckedIndexCollection equipment = checkedListBox1.CheckedIndices;
            if (equipment.Contains(0))
            {
                meeting.SetProjector();
            }
            if (equipment.Contains(1))
            {
                meeting.SetTelevision();
            }
            if (equipment.Contains(2))
            {
                meeting.SetWhiteboard();
            }
            string status = "Meeting scheduled for\n" + meeting.ToString();
            meetings.Add(meeting);
            meetings.SaveToFile();
            MessageBox.Show(status);
            Close();
        }
        private void UpdateForm()
        {
            if (meeting.GetRoom() > 0)
            {
                monthCalendar1.Enabled = true;
            }
            if (meeting.GetDate() != null)
            {
                buttonTime1.Enabled = true;
                buttonTime2.Enabled = true;
                buttonTime3.Enabled = true;
                buttonTime4.Enabled = true;
                buttonTime5.Enabled = true;
            }
            if (meeting.GetTime() > 0)
            {
                buttonSubmit.Enabled = true;
            }
        }
    }
}
