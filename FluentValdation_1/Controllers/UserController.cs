using FluentValdation_1.Entities;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace FluentValdation_1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController: ControllerBase
    {
        private readonly IValidator<User> _validator;

        public UserController(IValidator<User> validator)
        {
            _validator = validator;
        }

        [HttpPost]
        public async Task<IActionResult>  CreateUser(User user)
        {
            ValidationResult result = await _validator.ValidateAsync(user);

            if (!result.IsValid)
            {
                return Ok(result.ToDictionary());
            }

            return Ok(result);
            
        }
    }
}
