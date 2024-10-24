
using SimpleLogin.Database.EfCore;
using SimpleLogin.Database.Repository;
using SimpleLogin.Repository;

namespace SimpleLogin.Database
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LoginDbContext _context;

        public UnitOfWork(LoginDbContext context)
        {
            this.Samples = new SampleRepository(context);
        }

        public ISampleRepository Samples {  get; set; }
    }
}