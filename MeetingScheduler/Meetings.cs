using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace MeetingScheduler
{
    class Meetings
    {
        private List<Meeting> meetings = new List<Meeting>();

           //operations
           public List<Meeting> GetMeetings()
        {
            return meetings;
        }
        public void Add(Meeting m)
        {
            meetings.Add(m);
        }
        public void Remove(Meeting m)
        {
            meetings.Remove(m);
        }
        public void SaveToFile()
        {
            Stream stream = File.Open("Meetings.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, meetings);
            stream.Close();
        }
        public bool HasMeetings()
        {
            foreach (Meeting m in meetings)
            {
                return true;
            }
            return false;
        }
    }
}
