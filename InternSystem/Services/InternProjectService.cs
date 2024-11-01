using InternSystemClassLibrary.Models;
using InternSystemClassLibrary.Services;
using InternSystemCore.Data;

namespace InternSystemCore.Services
{
    public class InternProjectService : ServiceBase<InternProject>
    {

        public InternProjectService(SystemDbContext _db) : base(_db)
        {
        }
    }
}

