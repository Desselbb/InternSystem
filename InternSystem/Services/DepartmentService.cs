using InternSystemClassLibrary.Services;
using System.Security.Claims;
using InternSystemClassLibrary.Models;
using InternSystemCore.Data;

namespace InternSystemCore.Services
{
    public class DepartmentService: ServiceBase<Department>
    {

        public DepartmentService(SystemDbContext _db) : base(_db)
        {
        }


    }
}

