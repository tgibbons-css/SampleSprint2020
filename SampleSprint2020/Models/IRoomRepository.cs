using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleSprint2020.Models
{
    interface IRoomRepository
    {
        void CreateRoom(string name);

        IEnumerable<RoomRecord> GetAllRooms();
    }
}
