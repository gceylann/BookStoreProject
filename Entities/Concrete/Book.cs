using Core.Entities.Abstact;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book:IEntity
    {
        [Key]
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Page { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }


    }
}
