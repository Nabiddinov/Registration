using Microsoft.AspNetCore.Identity;

namespace Registration.Areas.Identity.Data;

// Add profile data for application users by adding properties to the SampleUser class
public class SampleUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

