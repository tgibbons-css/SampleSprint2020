using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleSprint2020.Models
{
    interface IMessageRepository
    {
        IEnumerable<MessageRecord> GetMessagesForRoomID(int roomID);

        void AddMessageToRoom(int roomID, string authorName, string text);

    }
}
