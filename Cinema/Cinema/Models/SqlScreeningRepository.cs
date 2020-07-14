using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class SqlScreeningRepository : IScreeningRepository
    {
        private readonly AppDbContext context;
        public SqlScreeningRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Screening Create(Screening s)
        {
            context.CinemaManagements.Add(s);
            context.SaveChanges();
            return s;
        }

        public bool Delete(string id)
        {
            var delSc = context.CinemaManagements.Find(id);
            if (delSc != null)
            {
                context.CinemaManagements.Remove(delSc);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public Screening Edit(Screening s)
        {
            var editSC = context.CinemaManagements.Attach(s);
            editSC.State = EntityState.Modified;
            context.SaveChanges();
            return s;
        }

        public Screening Get(string id)
        {
            return context.CinemaManagements.Find(id);
        }

        public IEnumerable<Screening> Gets()
        {
            return context.CinemaManagements;
        }
    }
}
