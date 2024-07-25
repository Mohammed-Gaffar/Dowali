using Core.Entities;
using Dowali.Core.Entities;

namespace Dowali.Core.Interfaces
{
    public interface IProject
    {
        Task<BaseResponse> CreateProject(Project Project);

        Guid GetProjectID(Project Project);

        public Task<IEnumerable<Project>> GetAllProjects();

        public Task<Project> GetProjectByID(Guid ProjectId);

        public Task<IEnumerable<Project>> GetUserProjects(string P_User);

        public Task<BaseResponse> projectConfirmation(Guid projectID);
    }
}
