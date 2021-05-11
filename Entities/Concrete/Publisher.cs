using Core.Entities.Abstact;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Publisher : IEntity
    {
        [Key]
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }

    }
}
