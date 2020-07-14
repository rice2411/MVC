using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class SqlFilmRepository : IFilmRepository
        
    {
        private readonly AppDbContext context;
        public SqlFilmRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Film Create(Film f)
        {
            context.Films.Add(f);
            context.SaveChanges();
       
            return f;
        }

        public bool Delete(string id)
        {
            var delFilm = context.Films.Find(id);
            if (delFilm != null)
            {
                context.Films.Remove(delFilm);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public Film Edit(Film f)
        {
            var editFilm = context.Films.Attach(f);
            editFilm.State = EntityState.Modified;
            context.SaveChanges();
            return f;
        }

        public Film Get(string id)
        {
            return context.Films.Find(id);
        }

        public IEnumerable<Film> Gets()
        {
            return context.Films;
        }
    }
}
