using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IResult UpdateSpecificInfos(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int Id);
        IDataResult<User> GetByEmail(string email);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<OperationClaim> GetClaimById(int userId);

    }
}
