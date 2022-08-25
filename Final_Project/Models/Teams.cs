namespace Final_Project.Models
{
    public class Teams
    { public Teams() { }

        public string TeamName { get; set; }=String.Empty;
        public string Owner { get; set; } = String.Empty;
        public string Division { get; set; }= String.Empty;
        public string record { get; set; } = String.Empty;
        public bool MadePlayoffs { get; set; }

    }
}
