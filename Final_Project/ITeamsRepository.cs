using Final_Project.Models;

namespace Final_Project
{
    public interface ITeamsRepository
    {
        public IEnumerable<Teams> GetAllTeams();
    }
}
