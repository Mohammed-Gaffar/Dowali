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

        public async Task<IEnumerable<Project>> GetAllProjects()
        {
            IEnumerable<Project> projects = _dbcon.Projects;

            return projects;
        }

        public async Task<Project> GetProjectByID(Guid ProjectId)
        {
            Project project = await _dbcon.Projects.FindAsync(ProjectId);
            return project;
        }

        public Guid GetProjectID(Project Project)
        {

            var Db_Project = _dbcon.Projects.FirstOrDefault(x => x.Main_Field == Project.Main_Field);
            return Db_Project.ID;
        }


        //public Task<IEnumerable<Project>> GetProjectsWithData()
        //{
        //IEnumerable<ProjectsDTO> result = from project in _dbcon.Projects
        //             join investgators in _dbcon.Investigators on project.ID equals investgators.Project_Id
        //             join Financtial in _dbcon.Financial_Sections on project.ID equals Financtial.Project_Id
        //             select new
        //             {
        //                 project,
        //                 investgators,
        //                 Financtial
        //             };

        // return result.ToList();
        //}
    }
}
