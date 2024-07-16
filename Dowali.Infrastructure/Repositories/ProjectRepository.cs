//////////////////////////////////////////////////
//Author    : Mohammed Gaffer Aidaab
//For       : King Faisual University
//Under     : ISB integrated sulution business Company
//App       : Dowali Application (())
//Date      : July - 2024 
/////////////////////////////////////////////////////



using Core.Entities;
using Dowali.Core.Entities;
using Dowali.Core.Interfaces;
using Infrastructure.Context;

namespace Dowali.Infrastructure.Repositories
{
    public class ProjectRepository : IProject
    {
        private readonly DowaliContext _dbcon;

        public ProjectRepository(DowaliContext dbcon)
        {
            _dbcon = dbcon;
        }

        public async Task<BaseResponse> CreateProject(Project Project)
        {
            _dbcon.Projects.Add(Project);
            await _dbcon.SaveChangesAsync();

            return new BaseResponse { IsSuccess = true, Message = "project added" };
        }

        public int GetProjectID(Project Project)
        {

            var Db_Project = _dbcon.Projects.FirstOrDefault(x => x.Main_Field == Project.Main_Field);


            return Db_Project.ID;
        }
    }
}
