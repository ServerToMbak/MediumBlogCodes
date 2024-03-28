using System.ComponentModel.DataAnnotations;

namespace UOWAndGenericRepoısitory.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
