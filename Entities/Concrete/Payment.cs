using Core.Entities.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Payment:IEntity
    {
        public int PaymentId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime ProcessDate { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
