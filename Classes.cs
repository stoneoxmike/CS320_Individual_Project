using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS320_Individual_Project
{
    internal class Classes
    {
        string name;
        int startHour;
        int endHour;
        int startMinute;
        int endMinute;
        bool M;
        bool T;
        bool W;
        bool Th;
        bool F;

        public Classes(string name, int startHour, int endHour, int startMinute, int endMinute, bool M, bool T, bool W, bool Th, bool F)
        {
            this.name = name;
            this.startHour = startHour;
            this.endHour = endHour;
            this.startMinute = startMinute;
            this.endMinute = endMinute;
            this.M = M;
            this.T = T;
            this.W = W;
            this.Th = Th;
            this.F = F;
        }

        public DateTime getClassTime()
        {
            return new DateTime(this.endHour - this.startHour, (DateTimeKind) (this.endMinute - this.startMinute));
        }


    }
}
