using Core.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Validation
{
    public class BrandValidation:AbstractValidator<Brand>
    {
        public BrandValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name Alanı Boş Olamaz").NotNull().WithMessage("Name Alanı Null Olamaz");
        }
    }
}
