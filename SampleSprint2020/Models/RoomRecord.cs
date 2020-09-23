using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleSprint2020.Models
{
    public class RoomRecord
    {
        public RoomRecord(string name, int roomId)
        {
            Name = name;
            RoomId1 = roomId;
        }

        int RoomId;
        public string Name
        {
            get;
            private set;
        }
        public int RoomId1 { get => RoomId; set => RoomId = value; }
    }
}
