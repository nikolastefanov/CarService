
namespace CarService.Services.Mechanics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IMechanicsService
    {
        bool BecomeMechanic(
            string fullName);
            //, string phoneNumber);

    }
}
