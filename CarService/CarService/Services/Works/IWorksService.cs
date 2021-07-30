
namespace CarService.Services.Works
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IWorksService
    {
        bool CreateWork(string description, decimal price);
    }
}
