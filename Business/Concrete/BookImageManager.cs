using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BookImageManager : IBookImageService
    {
        IBookImageDal _bookImageDal;

        public BookImageManager(IBookImageDal bookImageDal)
        {
            _bookImageDal = bookImageDal;
        }

        public IResult Add(BookImage bookImage, IFormFile file)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(BookImage bookImage, IFormFile file)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<BookImage>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Book> GetById(int BookId)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(BookImage bookImage, IFormFile file)
        {
            throw new System.NotImplementedException();
        }
    }
}
