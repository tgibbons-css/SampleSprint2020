using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleSprint2020.Models
{
    public class RoomRecord
    {
        public RoomRecord(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            private set;
        }
    }
}
