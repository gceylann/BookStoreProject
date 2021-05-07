using Core.Entities.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BookImage:IEntity
    {
        public int ImageId { get; set; }
        public int BookId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }

    }
}
