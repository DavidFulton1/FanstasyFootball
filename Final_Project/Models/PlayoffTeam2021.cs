namespace Final_Project.Models
{
    public class PlayoffTeam2021
    {
        public PlayoffTeam2021() { }

        public string Team { get; set; }=String.Empty;
        public bool QuarterFinals { get; set; }
        public bool SemiFinals { get; set; }
        public bool Championship { get; set; }
        public bool Winner { get; set; }
        public int Seed { get; set; }
        //public string QfOpp { get; set; } = String.Empty;
        //public string SfOpp { get; set; } = String.Empty;
        //public string ChampOpp { get; set; } = String.Empty;

    }
}
