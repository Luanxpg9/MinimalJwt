using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalJwt.Models;

namespace MinimalJwt.Repositories
{
    public class UserRepository
    {
        // Everyday I criticize Java, and then I remember that Minecraft is made in it.
        public static List<User> Users = new()
        {
            new() { Username = "luke_admin", EmailAddress = "luke.admin@email.com", Password = "MyPass_w0rd", GivenName = "Luke", Surname = "Rogers", Role = "administrator" },
            new() { Username = "lydia_standard", EmailAddress = "lydia.standard@email.com", Password = "MyPass_w0rd", GivenName = "Elyse", Surname = "Burton", Role = "Standard" }
        };
        
    }
}
