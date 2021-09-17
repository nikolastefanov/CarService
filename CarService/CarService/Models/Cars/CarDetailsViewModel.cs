

namespace CarService.Models.Cars
{
    public class CarDetailsViewModel
    {
    
        public int Id { get; set; }

        public string Make { get; init; }

        public string Model { get; init; }

        public string PlateNumber { get; set; }

        public string ImageUrl { get; init; }
    
        public int Year { get; init; }

    }
}
