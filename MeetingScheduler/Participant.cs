using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    class Participant
    {
        //attributes
        public string Name;
        private List<DateTime> Preference;
        private List<DateTime> Exclusion;


        //constructor
        public Participant()
        {
            Name = "default";
            Preference = null;
            Exclusion = null;
        }
        public Participant(string Name)
        {
            this.Name = Name;
        }

        Participant John = new Participant("John Lennon");
        Participant Peter = new Participant("Peter Boden");
        Participant Steve = new Participant("Steve Jobs");
        Participant Mehmet = new Participant("Mehmet Ozcan");
        Participant Babak = new Participant("Babak Khazaei");
        Participant Souyma = new Participant("Soumya Basu");
        Participant Andrew = new Participant("Andrew Bissett");
        
        //Methods
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetPreference(List<DateTime> p)
        {
            this.Preference = p;
        }
    }
}
