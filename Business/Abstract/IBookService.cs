using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookService
    {
        IResult Add(Book book);
        IResult Delete(Book book);
        IResult Update(Book book);
        IDataResult<List<Book>> GetAll();
        IDataResult<Book> GetById(int bookId);
        IDataResult<List<BookDetailDto>> GetBookDetails(int bookId);
        IDataResult<List<Book>> GetBooksByCategory(int categoryId);
        IDataResult<List<Book>> GetBooksByAuthor(int authorId);
        IDataResult<List<Book>> GetBooksByPublisher(int publisherId);
        IDataResult<List<Book>> GetBooksByFilter(int authorId, int publisherId);

    }
}