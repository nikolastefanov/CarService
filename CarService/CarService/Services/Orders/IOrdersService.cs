
namespace CarService.Services.Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IOrdersService
    {
        void CreateOrderZero(decimal price);
    }
}
