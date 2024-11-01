using InternSystemClassLibrary.Models;
using InternSystemClassLibrary.Services;
using InternSystemCore.Data;

namespace InternSystemCore.Services
{
    public class InternService : ServiceBase<Intern>
    {
        public InternService(SystemDbContext _db) : base(_db)
        {
        }
    }
}
