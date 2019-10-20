using System.Collections.Generic;
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
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> logger;
        private readonly cosmicspaceContext dbContext;

        public GameController(ILogger<GameController> logger, cosmicspaceContext dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
        }

        private bool Auth(string token)
        {
            return dbContext.Users.Any(o => o.Authtoken == token);
        }

        [HttpGet("GetPilots")]
        public IEnumerable<Pilots> GetPilots()
        {
            List<Pilots> pilots = dbContext.Pilots
                .Include(o => o.Ship)
                .ToList();

            foreach (Pilots pilot in pilots)
            {
                pilot.Primarykeyid = default;
                pilot.Userid = default;

                pilot.Mapid = default;
                pilot.Positionx = default;
                pilot.Positiony = default;

                pilot.Scrap = default;
                pilot.Metal = default;

                pilot.Isdead = default;
                pilot.Killerby = default;

                pilot.Ship.Pilots = null;
            }

            return pilots;
        }
    }
}