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

        [HttpGet(nameof(ApiService.GetPilots))]
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

        [HttpGet(nameof(ApiService.GetTasks))]
        public IEnumerable<Tasks> GetTasks()
        {
            List<Tasks> tasks = dbContext.Tasks
                .Include(o => o.Reward)
                .ThenInclude(o => o.Itemreward)
                .ThenInclude(o => o.Item)
                .Include(o => o.Taskquest)
                .ThenInclude(o => o.Quest)
                .ThenInclude(o => o.Questtype)

                .Include(o => o.Taskquest)
                .ThenInclude(o => o.Quest)
                .ThenInclude(o => o.Questmap)
                .ThenInclude(o => o.Map)
                .ToList();

            foreach (Tasks task in tasks)
            {
                task.Reward.Tasks = default;

                foreach (Itemreward itemreward in task.Reward.Itemreward)
                {
                    itemreward.Reward = default;
                    itemreward.Item.Itemreward = default;
                }

                foreach (Taskquest taskquest in task.Taskquest)
                {
                    taskquest.Task = default;
                    taskquest.Quest.Taskquest = default;
                    taskquest.Quest.Questtype.Quests = default;

                    foreach (Questmap questmap in taskquest.Quest.Questmap)
                    {
                        questmap.Quest = default;
                        questmap.Map.Questmap = default;
                    }
                }
            }

            return tasks;
        }

        [HttpGet(nameof(ApiService.GetQuestTypes))]
        public IEnumerable<Questtypes> GetQuestTypes()
        {
            List<Questtypes> questtypes = dbContext.Questtypes
                .ToList();

            return questtypes;
        }

        [HttpGet(nameof(ApiService.AddQuestTypes))]
        public bool AddQuestTypes(byte questTypeId, long? targetId, long? quantity, string selectedMaps)
        {
            Quests quest = new Quests()
            {
                Questtypeid = questTypeId,
                Targetid = targetId,
                Quantity = quantity
            };

            List<Maps> maps = DllUtils.DeserializeObject<List<Maps>>(selectedMaps);

            dbContext.Quests
                .Add(quest);

            if(dbContext.SaveChanges() > 0)
            {
                if(maps != null)
                {
                    foreach (Maps map in maps)
                    {
                        dbContext.Questmap
                            .Add(new Questmap()
                            {
                                Mapid = map.Mapid,
                                Questid = quest.Questid
                            });
                    }
                    return dbContext.SaveChanges() > 0;
                }
                return true;
            }
            else
            {
                return false;
            }
        }



        [HttpGet(nameof(ApiService.AddRewards))]
        public bool AddRewards(string copyReward)
        {
            Rewards reward = DllUtils.DeserializeObject<Rewards>(copyReward);

            dbContext.Rewards
                .Add(reward);

            return dbContext.SaveChanges() > 0;
        }

        [HttpGet(nameof(ApiService.GetRewards))]
        public IEnumerable<Rewards> GetRewards()
        {
            List<Rewards> rewards = dbContext.Rewards
                .Include(o => o.Itemreward)
                .ThenInclude(o => o.Item)
                .ToList();

            foreach (Rewards reward in rewards)
            {
                foreach (Itemreward itemreward in reward.Itemreward)
                {
                    itemreward.Reward = default;
                    itemreward.Item.Itemreward = default;
                }
            }

            return rewards;
        }



        [HttpGet(nameof(ApiService.GetMaps))]
        public List<Maps> GetMaps()
        {
            List<Maps> maps = dbContext.Maps
                .ToList();

            return maps;
        }

        [HttpGet(nameof(ApiService.GetItems))]
        public List<Items> GetItems()
        {
            List<Items> items = dbContext.Items
                .Include(o => o.Itemtype)
                .ToList();

            foreach (Items item in items)
            {
                item.Itemtype.Items = default;
            }

            return items;
        }

        [HttpGet(nameof(ApiService.GetAmmunitions))]
        public List<Ammunitions> GetAmmunitions()
        {
            List<Ammunitions> ammunitions = dbContext.Ammunitions
                .ToList();

            return ammunitions;
        }



        [HttpGet(nameof(ApiService.GetQuests))]
        public List<Quests> GetQuests()
        {
            List<Quests> quests = dbContext.Quests
                .Include(o => o.Questtype)
                .Include(o => o.Questmap)
                .ThenInclude(o => o.Map)
                .ToList();

            foreach (Quests quest in quests)
            {
                quest.Questtype.Quests = default;

                foreach (Questmap questmap in quest.Questmap)
                {
                    questmap.Quest = default;
                    questmap.Map.Questmap = default;
                }
            }

            return quests;
        }

        [HttpGet(nameof(ApiService.AddQuests))]
        public bool AddQuests(string taskJson)
        {
            Tasks task = DllUtils.DeserializeObject<Tasks>(taskJson);

            dbContext.Tasks
                .Add(task);

            return dbContext.SaveChanges() > 0;
        }
    }
}