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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Dowali.Infrastructure.Repositories
{
    public class FinanctialRepository : IFinancial
    {
        private readonly DowaliContext _context;

        public FinanctialRepository(DowaliContext context)
        {
            _context = context;
        }

        public async Task<BaseResponse> Create(Financial_Section financial)
        {
            try
            {
                _context.Financial_Sections.Add(financial);
                await _context.SaveChangesAsync();

                return new BaseResponse { IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new BaseResponse { IsSuccess = false, Message = ex.ToString() };
            }

        }

        public async Task<IEnumerable<Financial_Section>> GetAllFinanctial()
        {
            IEnumerable<Financial_Section> financial_Sections = _context.Financial_Sections;

            return financial_Sections;
        }

        public async Task<Financial_Section> GetFinantialByProjectID(int ProjectId)
        {
            Financial_Section financial = await _context.Financial_Sections.FirstOrDefaultAsync(x => x.Project_Id == ProjectId);

            return financial;
        }
    }
}
