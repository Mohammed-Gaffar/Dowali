using Core.Entities;
using Dowali.Core.Entities;

namespace Dowali.Core.Interfaces
{
    public interface IResearch
    {
        Task<BaseResponse> CreateProject(Research Project);

        Guid GetProjectID(Research Project);

        public Task<IEnumerable<Research>> GetAllResearches();

        public Task<Research> GetProjectByID(Guid ProjectId);

        public Task<IEnumerable<Research>> GetUserResearches(string P_User);

        public Task<BaseResponse> projectConfirmation(Guid projectID);
    }
}
