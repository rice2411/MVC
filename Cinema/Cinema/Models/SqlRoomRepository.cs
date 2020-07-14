using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class SqlRoomRepository : IRoomRepository
    {
        private readonly AppDbContext context;
        public SqlRoomRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Room Create(Room r)
        {
            context.Rooms.Add(r);
            context.SaveChanges();
            return r;
        }

        public bool Delete(string id)
        {
            var delR = context.Rooms.Find(id);
            if (delR != null)
            {
                context.Rooms.Remove(delR);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public Room Edit(Room r)
        {
            var edtR = context.Rooms.Attach(r);
            edtR.State = EntityState.Modified;
            context.SaveChanges();
            return r;
        }

        public Room Get(string id)
        {
            return context.Rooms.Find(id);
        }

        public IEnumerable<Room> Gets()
        {
            return context.Rooms;
        }
    }
}
