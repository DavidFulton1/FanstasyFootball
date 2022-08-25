using Final_Project.Models;

namespace Final_Project
{
    public interface IPlayoffs2021Repository
    {
       
        public IEnumerable<PlayoffTeam2021> GetQFGames();
        public IEnumerable<PlayoffTeam2021> GetSFGames();
        public IEnumerable<PlayoffTeam2021> GetChampionshipGame();
    }
}

