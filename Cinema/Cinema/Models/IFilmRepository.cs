using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public interface IFilmRepository
    {
        IEnumerable<Film> Gets();
        Film Get(string id);
        Film Create(Film e);
        Film Edit(Film e);
        bool Delete(string id);
    }
}
