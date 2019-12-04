using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MeetingScheduler 
{
    [Serializable()]
    class Meeting : ISerializable
    {
        //attributes
        private int room;
        private string date;
        private int time;
        private bool projecter, television, whiteboard;

        //constructor
        public Meeting()
        {
            room = -1;
            date = "null";
            time = -1;
            projecter = false;
            television = false;
            whiteboard = false;
        }
        public Meeting(int room, string date, int time)
        {
            this.room = room;
            this.date = date;
            this.time = time;
        }
        //operations
        public int GetRoom(){return room;}
        public string GetDate() { return date; }
        public int GetTime() { return time; }

        public void SetRoom(int room)
        {
            this.room = room;
        }
        public void SetDate(string date)
        {
            this.date = date;
        }
        public void SetTime(int time)
        {
            this.time = time;
        }
        public override string ToString()
        {
            return string.Format("Room: "+ room.ToString()+ "\nDate: "+ date + "\nTime: "+ time.ToString());
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Room", room);
            info.AddValue("Date", date);
            info.AddValue("Time", time);
        }
        public Meeting(SerializationInfo info, StreamingContext context)
        {
            room = (int)info.GetValue("Room", typeof(int));
            date = (string)info.GetValue("Date", typeof(string));
            time = (int)info.GetValue("Time", typeof(int));
        }
    }
}
