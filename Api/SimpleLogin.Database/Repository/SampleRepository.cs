using Microsoft.EntityFrameworkCore;
using SimpleLogin.Database.EfCore;
using SimpleLogin.Domain;
using SimpleLogin.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogin.Database.Repository
{
    public class SampleRepository : ISampleRepository
    {
        private readonly LoginDbContext _context;

        public SampleRepository(LoginDbContext context)
        {
            _context = context;
        }

        public List<Sample> GetSamples()
        {
            return _context.Samples.AsNoTracking().ToList();
        }
    }
}
