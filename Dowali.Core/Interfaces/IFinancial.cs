using Core.Entities;
using Dowali.Core.Entities;

namespace Dowali.Core.Interfaces
{
    public interface IFinancial
    {
        Task<BaseResponse> Create(Financial_Section financial);

        public Task<IEnumerable<Financial_Section>> GetAllFinanctial();

        public Task<Financial_Section> GetFinantialByProjectID(int ProjectId);

    }
}
