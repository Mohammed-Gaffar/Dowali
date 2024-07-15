using Core.Entities;
using Dowali.Core.Entities;

namespace Dowali.Core.Interfaces
{
    public interface IFinancial
    {
        Task<BaseResponse> Create(Financial_Section financial);

    }
}
