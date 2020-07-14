using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public interface IRoomRepository
    {
        IEnumerable<Room> Gets();
        Room Get(string id);
        Room Create(Room e);
        Room Edit(Room e);
        bool Delete(string id);
    }
}
