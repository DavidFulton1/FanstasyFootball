using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class TeamsController : Controller
    {
        private readonly ITeamsRepository repo;
        public TeamsController(ITeamsRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var teams = repo.GetAllTeams();
            return View(teams);
        }
    }
}
