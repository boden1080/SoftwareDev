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
        private DateTime date;
        private int time;
        private bool projecter, television, whiteboard;

        //constructor
        public Meeting()
        {
            room = -1;
            date = new DateTime();
            time = -1;
            projecter = false;
            television = false;
            whiteboard = false;
        }
        public Meeting(int room, DateTime date, int time)
        {
            this.room = room;
            this.date = date;
            this.time = time;
        }
        //operations
        public int GetRoom(){return room;}
        public DateTime GetDate() { return date; }
        public int GetTime() { return time; }

        public void SetRoom(int room)
        {
            this.room = room;
        }
        public void SetDate(DateTime date)
        {
            this.date = date;
        }
        public void SetTime(int time)
        {
            this.time = time;
        }
        public void SetProjector()
        {
            projecter = true;
        }
        public void SetTelevision()
        {
            television = true;
        }
        public void SetWhiteboard()
        {
            whiteboard = true;
        }
        public override string ToString()
        {
            string proj, tele, white;
            if (projecter == true)
            {
                proj = "\nAdded Projector";
            }
            else
                proj = null;
            if (television == true)
            {
                tele = "\nAdded Television";
            }
            else
                tele = null;
            if (whiteboard == true)
            {
                white = "\nAdded Whiteboard";
            }
            else
                white = null;
            return string.Format("Room: "+ room.ToString()+ "\nDate: "+ date + "\nTime: "+ time.ToString() + proj + tele + white);
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
            date = (DateTime)info.GetValue("Date", typeof(DateTime));
            time = (int)info.GetValue("Time", typeof(int));
        }
    }
}
