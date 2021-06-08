using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBookImageService
    {
        IResult Add(BookImage bookImage, IFormFile file);
        IResult Delete(BookImage bookImage);
        IResult Update(BookImage bookImage, IFormFile file);
        IDataResult<List<BookImage>> GetAll();
        IDataResult<BookImage> GetById(int BookImageId);


    }
}