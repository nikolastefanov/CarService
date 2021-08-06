
namespace CarService.Services.Mechanics
{
    using CarService.Data;
    using CarService.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class MechanicsService : IMechanicsService
    {
        private readonly ApplicationDbContext data;

        public MechanicsService(ApplicationDbContext data)
        {
            this.data = data;
        }
   
        public bool BecomeMechanic(string fullName ,string phoneNumber,string userId)
        {
            var userIdAlreadyMechanic = this.data
                   .Mechanics
                   .Any(d => d.UserId == userId);

            if (userIdAlreadyMechanic)
            {
                return false;
            }

            var mechanicData = new Mechanic
             {
                 FullName = fullName,
                 PhoneNumber = phoneNumber,
                 UserId = userId
             };

            if (mechanicData==null)
            {
                return false;
            }

            this.data.Mechanics.Add(mechanicData);

            this.data.SaveChanges();

            return true;
        }
    }
}
