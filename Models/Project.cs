using System.ComponentModel.DataAnnotations;

namespace mvc_energy_plants.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string CustomerName { get; set; }
        public string Country { get; set; }
        public double PowerGeneration { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        [Display(Name = "Operation Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }


    }
}
