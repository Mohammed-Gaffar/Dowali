using Core.Entities;
using Dowali.Core.Entities;

namespace Dowali.Core.Interfaces
{
    public interface IProject
    {
        Task<BaseResponse> CreateProject(Project Project);

        int GetProjectID(Project Project);
    }
}
