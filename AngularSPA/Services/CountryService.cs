using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularSPA.Entities;

namespace AngularSPA.Services
{

    public interface ICountryService
    {
        IList<Country> GetAll();
        Country Get(int id);
    }
    
    public class CountryService : ICountryService
    {
        private readonly DatabaseContext _dbContext;
        public CountryService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<Country> GetAll()
        {
            return _dbContext.Countries.Where(p => p.IsActive == true).ToList();
        }

        public Country Get(int id)
        {
            return _dbContext.Countries.FirstOrDefault(p => p.Id == id && p.IsActive == true);
        }
    }
}
