using Core.Entities.Abstact;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Payment:IEntity
    {
        [Key]
        public int PaymentId { get; set; }
        public int RentalId { get; set; }
        public string NameSurname { get; set; }
        public string CardNo { get; set; }
        public string ExpirationDate { get; set; }
        public string Cvc { get; set; }

    }
}
