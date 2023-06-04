using Microsoft.AspNetCore.Identity;

namespace RealEstateCourse.Models
{
    public class Users : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
