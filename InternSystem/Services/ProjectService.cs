using InternSystemClassLibrary.Models;
using InternSystemClassLibrary.Services;
using InternSystemCore.Data;

namespace InternSystemCore.Services
{
    public class ProjectService : ServiceBase<Project>
    {
        public ProjectService(SystemDbContext _db) : base(_db)
        {
        }
    }
}
