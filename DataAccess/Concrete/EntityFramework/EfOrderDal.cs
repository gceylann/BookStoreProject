using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace DataAccess.Concrete
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, DatabaseContext>, IOrderDal
    {
        public List<OrderDetailDto> GetOrderDetails(Expression<Func<Order, bool>> filter = null)
        {
            using (DatabaseContext context=new DatabaseContext())
            {
                var result = from order in context.Orders
                             join book in context.Books
                             on order.BookId equals book.BookId
                             join user in context.Users
                             on order.UserId equals user.Id
                             select new OrderDetailDto
                             {
                               OrderId=order.OrderId,
                               BookId=book.BookId,
                               BookName=book.BookName,
                               Price=book.Price,
                               UserId=user.Id,
                               UserFirstName=user.FirstName,
                               UserLastName=user.LastName,
                               OrderDate=order.OrderDate
                             };

                return result.ToList();
            }
        }
    }

}
