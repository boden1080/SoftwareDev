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
    [Serializable()]
    public class Participant : ISerializable
    {
        //attributes
        public string Name;
        public List<DateTime> Preference;
        public List<DateTime> Exclusion;


        //constructor
        public Participant()
        {
            Name = "default";
            Preference = new List<DateTime>();
            Exclusion = new List<DateTime>();
        }
        public Participant(string Name)
        {
            this.Name = Name;
            Preference = new List<DateTime>();
            Exclusion = new List<DateTime>();
        }
        
        //Methods
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return Name;
        }
        public List<DateTime> GetPreferences()
        {
            return Preference;
        }
        public void AddPreferenceDate(DateTime p)
        {
            Preference.Add(p);
        }
        public List<DateTime> GetExclusion()
        {
            return Exclusion;
        }
        public void AddExclusionDate(DateTime e)
        {
            Exclusion.Add(e);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Preference dates", Preference);
            info.AddValue("Exclusion dates", Exclusion);
        }
        public Participant(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Preference = (List<DateTime>)info.GetValue("Preference dates", typeof(List<DateTime>));
            Exclusion = (List<DateTime>)info.GetValue("Exclusion dates", typeof(List<DateTime>));
        }

    }
}
