using InternSystemClassLibrary.Models;
using InternSystemClassLibrary.Services;
using InternSystemCore.Data;

namespace InternSystemCore.Services
{
    public class PersonalDetailsService : ServiceBase<PersonalDetails>
    {
        public PersonalDetailsService(SystemDbContext _db) : base(_db)
        {
        }
    }
}
