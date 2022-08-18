using Dapper;
using Final_Project.Models;
using System.Data;

namespace Final_Project
{
    public class Season2021Repository : ISeason2021Repository
    {
        private readonly IDbConnection _conn;
        public Season2021Repository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Season2021> GetSeason()
        {
            return _conn.Query<Season2021>("SELECT * FROM SEASON2021;");
        }
    }
}
