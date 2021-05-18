using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }


        public IResult Add(Book book)
        {
            _bookDal.Add(book);

            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<Book>> GetBooksByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(b => b.CategoryId == categoryId));
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);

            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll());
        }

        public IDataResult<List<BookDetailDto>> GetBookDetails(int bookId)
        {
            return new SuccessDataResult<List<BookDetailDto>>(_bookDal.GetBookDetails());
        }

        public IDataResult<List<Book>> GetBooksByAuthor(int authorId)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(b=>b.AuthorId==authorId));
        }


        public IDataResult<List<Book>> GetBooksByFilter(int authorId, int publisherId)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll
                (b=> b.AuthorId==authorId && b.PublisherId==publisherId));
        }

        public IDataResult<List<Book>> GetBooksByPublisher(int publisherId)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(b=>b.PublisherId==publisherId));
        }

        public IDataResult<Book> GetById(int bookId)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(b => b.BookId == bookId));
        }

        public IResult Update(Book book)
        {
            _bookDal.Update(book);

            return new SuccessResult(Messages.Updated);
        }
    }
}
