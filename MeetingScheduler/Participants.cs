using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace MeetingScheduler
{
    class Participants
    {
        private List<Participant> participants = new List<Participant>();
        public Participants()
        {

        }

        //operations
        public List<Participant> GetParticipants()
        {
            return participants;
        }
        public void Add(Participant p)
        {
            participants.Add(p);
        }
        public void Remove(Participant p)
        {
            participants.Remove(p);
        }
        public void SaveToFile(Participant p)
        {
            Stream stream = File.Open("Participants.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, p);
            stream.Close();
        }

        public void Load()
        {
            Stream stream = File.Open("Participants.dat", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Deserialize(stream);
            stream.Close();
        }

        public bool HasMeetings()
        {
            foreach (Participant p in participants)
            {
                return true;
            }
            return false;
        }
    }
}
