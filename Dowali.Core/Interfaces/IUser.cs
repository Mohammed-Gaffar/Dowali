//////////////////////////////////////////////////
//Author    : Mohammed Gaffer Aidaab
//For       : King Faisual University
//Under     : ISB integrated sulution business Company
//App       : Dowali Application (())
//Date      : July - 2024 
/////////////////////////////////////////////////////


using Core.Entities;

namespace Core.Interfaces
{
    public interface IUser
    {
        public IEnumerable<User> GetAll();
        public Task<User> GetById(Guid id);
        public Task<BaseResponse> Create(User User);
        public Task<BaseResponse> Update(User User);
        public Task<BaseResponse> DeleteById(Guid id);
        public Task<User> GetByName(string Name);
    }
}
