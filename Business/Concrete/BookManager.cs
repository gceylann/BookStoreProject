using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
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

        //[SecuredOperation("admin")]
        [ValidationAspect(typeof(BookValidator))]
        [CacheRemoveAspect("IBookService.Get")]
        public IResult Add(Book book)
        {
            _bookDal.Add(book);

            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);

            return new SuccessResult(Messages.Deleted);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll());
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<BookDetailDto>> GetBookDetails(int bookId)
        {
            if (bookId == 0)
            {
                return new SuccessDataResult<List<BookDetailDto>>(_bookDal.GetBookDetails());
            }
            else
            {
                return new SuccessDataResult<List<BookDetailDto>>(_bookDal.GetBookDetails(b => b.BookId == bookId));
            }
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Book>> GetBookDetailsByAuthor(int authorId)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(b => b.AuthorId == authorId));
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Book>> GetBookDetailsByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(b => b.CategoryId == categoryId));
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<Book> GetById(int bookId)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(b => b.BookId == bookId));
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Book>> GetBookDetailsByFilter(int categoryId, int authorId)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(b => b.CategoryId == categoryId && b.AuthorId ==authorId));
        }

        public IResult Update(Book book)
        {
            _bookDal.Update(book);

            return new SuccessResult(Messages.Updated);
        }
    }
}
