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
    public class InvestgatorRepository : IInvestgator
    {
        private readonly DowaliContext _context;

        public InvestgatorRepository(DowaliContext context)
        {
            _context = context;
        }

        public async Task<BaseResponse> Create(Investigator investgator)
        {
            _context.Investigators.Add(investgator);
            await _context.SaveChangesAsync();

            return new BaseResponse { IsSuccess = true, };
        }

        public async Task<IEnumerable<Investigator>> GetAllInvestgators()
        {
            IEnumerable<Investigator> investigators = _context.Investigators;

            return investigators;
        }
    }
}
