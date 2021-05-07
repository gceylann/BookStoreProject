using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfBookDal : EfEntityRepositoryBase<Book, DatabaseContext>, IBookDal
    {
        public List<BookDetailDto> GetBookDetails(Expression<Func<Book, bool>> filter = null)
        {
            using (DatabaseContext context=new DatabaseContext())
            {
                var result = from book in context.Books
                             join category in context.Categories
                             on book.CategoryId equals category.CategoryId
                             join image in context.BookImages
                             on book.BookId equals image.BookId
                             select new BookDetailDto
                             {
                                 BookId = book.BookId,
                                 BookName = book.BookName,
                                 Author = book.Author,
                                 Page = book.Page,
                                 Price = book.Price,
                                 Description = book.Description,
                                 CategoryId = book.CategoryId,
                                 CategoryName = category.CategoryName,
                                 ImagePath = image.ImagePath
                             };
                           return result.ToList();
            }
        }
    }

}
