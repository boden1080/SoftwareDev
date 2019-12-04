using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    class Setup
    {
        //attributes
        private Meeting meeting;
        private bool roomPicked;
        private bool datePicked;
        private bool timeSelected;

        public Setup()
        {
            meeting = new Meeting();
        }

        //operations
        public void RoomSelected(int room)
        {
            meeting.SetRoom(room);
        }
        public void DateSelected(DateTime date)
        {
            meeting.SetDate(date);
        }
        public void TimeSelected(int time)
        {
            meeting.SetTime(time);
        }

        public int GetRoomPicked() { return meeting.GetRoom(); }
        public DateTime GetDate() { return meeting.GetDate(); }
        public int GetTime() { return meeting.GetTime(); }

        public Meeting GetMeeting() { return meeting; }
        public bool IsRoomPicked()
        {
            if (meeting.GetRoom() > 0)
            {
                return true;
            }
            else
                return false;
        }
        public bool IsDatePicked()
        {
            if (meeting.GetDate() != null)
            {
                return true;
            }
            else
                return false;
        }
        public bool IsTimeSeleced()
        {
                if (meeting.GetTime() > 0)
                {
                    return true;
                }
                else
                    return false;
        }
    }
}
