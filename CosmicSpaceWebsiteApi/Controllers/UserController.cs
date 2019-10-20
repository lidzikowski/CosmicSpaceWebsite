using System;
using System.Linq;
using CosmicSpaceWebsiteApi.Database;
using CosmicSpaceWebsiteDll;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CosmicSpaceWebsiteApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> logger;
        private readonly cosmicspaceContext dbContext;

        public UserController(ILogger<UserController> logger, cosmicspaceContext dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
        }

        [HttpGet("GetUser")]
        public Users GetUser(string username, string password)
        {
            Users user = dbContext.Users
                .Include(o => o.Pilots)
                .SingleOrDefault(o => o.Usernamehash.Equals(username) && o.Passwordhash.Equals(password));

            if (user != null)
            {
                user.Authtoken = Hash.HashString($"cs={user.Userid}/{user.Registerdate}/{DateTime.Now}");
                dbContext.SaveChangesAsync();

                if (user.Pilots != null)
                    user.Pilots.User = null;
            }

            return user;
        }
    }
}