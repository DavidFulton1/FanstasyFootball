using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class Playoffs2021Controller : Controller
    {
        private readonly IPlayoffs2021Repository _repo;
        public Playoffs2021Controller(IPlayoffs2021Repository repo)
        {
            this._repo = repo;
        }

        public IActionResult Index()
        {   
            var qfTeams = _repo.GetQFGames().ToList();
            var sfTeams=_repo.GetSFGames().ToList();
            var champTeams = _repo.GetChampionshipGame().ToList();
            var matchup1 = new PlayoffMatchup()
            
            {
                TopTeam = qfTeams[0],
                BotTeam = qfTeams[6],
                Round= "qf",
              
            };

            var matchup2 = new PlayoffMatchup()
            {
                TopTeam = qfTeams[4],
                BotTeam = qfTeams[5],
                Round="qf",
        
            };
            var matchup3 = new PlayoffMatchup()
            {
                TopTeam = qfTeams[1],
                BotTeam = qfTeams[7],
                Round= "qf",
         
            };
            var matchup4 = new PlayoffMatchup()
            {
                TopTeam = qfTeams[2],
                BotTeam = qfTeams[3],
                Round= "qf",
          
            };
            var matchup5 = new PlayoffMatchup()
            {
                TopTeam = sfTeams[0],
                BotTeam = sfTeams[3],
                Round="sf",
         
            };
            var matchup6 = new PlayoffMatchup()
            {
                TopTeam = sfTeams[1],
                BotTeam = sfTeams[2],
                Round= "sf",
           
            };
            var matchup7 = new PlayoffMatchup()
            {
                TopTeam = champTeams[1],
                BotTeam = champTeams[0],
                Round="championship",
          
            };
            var matchups = new List<PlayoffMatchup>()
            {
                matchup1,
                matchup2,
                matchup3,
                matchup4,
                matchup5,
                matchup6,
                matchup7,
            };
            var qfs = new QuarterFinals()
            {
                FirstGame = matchup1,
                SecondGame = matchup2,
                ThirdGame = matchup3,
                FourthGame = matchup4,
            };
            var sfs = new SemiFinals()
            {
                TopGame = matchup5,
                BotomGame = matchup6,
            };

            var cg = new Championship()
            {
                Finals = matchup7
            };
            var tournament = new Tournament()
            {
                Left = qfs,
                Middle = sfs,
                Right = cg,

            };

            return View(tournament);
        }
    }
}