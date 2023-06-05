namespace mvc_energy_plants.Models
{
    public class ProjectStopLog
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public DateTime StopDate { get; set; }
        public string Classification { get; set; }
        public string Cause { get; set; }
        public string Action { get; set; }
    }
}
