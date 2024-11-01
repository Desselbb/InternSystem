using InternSystemClassLibrary.Models;
using InternSystemClassLibrary.Services;
using InternSystemCore.Data;

namespace InternSystemCore.Services
{
    public class ProjectCommentService : ServiceBase<ProjectComments>
    {
        public ProjectCommentService(SystemDbContext _db) : base(_db)
        {

        }
    }
}
