using Dapper;
using Final_Project.Models;
using System.Data;

namespace Final_Project
{
    public class TeamsRepository : ITeamsRepository
    {
        private readonly IDbConnection _conn;
        public TeamsRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Teams> GetAllTeams()
        {
            return _conn.Query<Teams>("SELECT * FROM TEAMS2021;");
        }
    }
}
