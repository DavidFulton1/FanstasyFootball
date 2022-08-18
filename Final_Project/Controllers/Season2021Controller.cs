using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class Season2021Controller : Controller
    {
        private readonly ISeason2021Repository repo;

        public Season2021Controller(ISeason2021Repository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var records = repo.GetSeason();
            return View();
        }
    }
}