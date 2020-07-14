using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public interface IScreeningRepository
    {
        IEnumerable<Screening> Gets();
        Screening Get(string id);
        Screening Create(Screening s);
        Screening Edit(Screening s);
        bool Delete(string id);
    }
}
