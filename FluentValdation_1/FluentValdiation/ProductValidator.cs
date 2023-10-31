using FluentValdation_1.Entities;
using FluentValidation;

namespace FluentValdation_1.FluentValdiation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MaximumLength(15);

            

        }
    }
}
