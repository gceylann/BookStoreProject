using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAuthorService
    {
        IResult Add(Author author);
        IResult Delete(Author author);
        IResult Update(Author author);
        IDataResult<List<Author>> GetAll();
        IDataResult<Author> GetById(int authorId);

    }
}
