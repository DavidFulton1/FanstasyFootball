using Dapper;
using Final_Project.Models;
using System.Data;
using System.Linq;

namespace Final_Project
{
    public class Playoffs2021Repository : IPlayoffs2021Repository
    {
        private readonly IDbConnection _conn;
        public Playoffs2021Repository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<PlayoffTeam2021> GetChampionshipGame()
        {
            return _conn.Query<PlayoffTeam2021>("SELECT * FROM PLAYOFFS2021 WHERE CHAMPIONSHIP = 1  ORDER BY SEED");
        }

        public IEnumerable<PlayoffTeam2021> GetQFGames()
        {

            return _conn.Query<PlayoffTeam2021>("SELECT * FROM PLAYOFFS2021 ORDER BY SEED");
        }

        public IEnumerable<PlayoffTeam2021> GetSFGames()
        {
            return _conn.Query<PlayoffTeam2021>("SELECT * FROM PLAYOFFS2021 WHERE SEMIFINALS = 1  ORDER BY SEED");
        }
    }
}