﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IResult Add(Order order);
        IResult Delete(Order order);
        IResult Update(Order order);
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> GetById(int orderId);
        IDataResult<List<OrderDetailDto>> GetOrderDetails(int orderId);

    }
}
