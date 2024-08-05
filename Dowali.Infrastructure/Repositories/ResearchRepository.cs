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
    public class ResearchRepository : IResearch
    {
        private readonly DowaliContext _dbcon;

        public ResearchRepository(DowaliContext dbcon)
        {
            _dbcon = dbcon;
        }

        public async Task<BaseResponse> CreateProject(Research Project)
        {
            _dbcon.Researches.Add(Project);
            await _dbcon.SaveChangesAsync();

            return new BaseResponse { IsSuccess = true, Message = "project added" };
        }

        public async Task<IEnumerable<Research>> GetAllResearches()
        {
            IEnumerable<Research> Researches = _dbcon.Researches;

            return Researches;
        }

        public async Task<Research> GetProjectByID(Guid ProjectId)
        {
            Research project = await _dbcon.Researches.FindAsync(ProjectId);
            return project;
        }

        public Guid GetProjectID(Research Project)
        {

            var Db_Project = _dbcon.Researches.FirstOrDefault(x => x.Main_Field == Project.Main_Field);
            return Db_Project.ID;
        }


        public async Task<IEnumerable<Research>> GetUserResearches(string P_User)
        {
            IEnumerable<Research> Researches = _dbcon.Researches.Where(x => x.owner == P_User);

            return Researches;
        }

        public async Task<BaseResponse> projectConfirmation(Guid projectID)
        {
            var db_project = _dbcon.Researches.Find(projectID);

            if (db_project != null)
            {
                db_project.satatus = 1;

                var res = _dbcon.Researches.Update(db_project);
                await _dbcon.SaveChangesAsync();

                return new BaseResponse { IsSuccess = true };

            }
            else
            {
                return new BaseResponse { IsSuccess = false };
            }

        }


        //public Task<IEnumerable<Project>> GetResearchesWithData()
        //{
        //IEnumerable<ResearchesDTO> result = from project in _dbcon.Researches
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
