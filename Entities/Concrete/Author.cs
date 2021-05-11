using Core.Entities.Abstact;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Author : IEntity
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

    }
}
