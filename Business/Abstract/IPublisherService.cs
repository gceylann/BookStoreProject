using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPublisherService
    {
        IResult Add(Publisher publisher);
        IResult Delete(Publisher publisher);
        IResult Update(Publisher publisher);
        IDataResult<List<Publisher>> GetAll();
        IDataResult<Publisher> GetById(int publisherId);

    }
}
