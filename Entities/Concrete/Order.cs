using Core.Entities.Abstact;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        [Key]
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }


    }
}
