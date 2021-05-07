using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public partial class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(b => b.BookName).MinimumLength(2);
            RuleFor(b => b.BookName).NotEmpty();
            RuleFor(b => b.Price).GreaterThan(0);

        }
    }
}
