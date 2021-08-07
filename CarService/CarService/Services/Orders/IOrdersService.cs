
namespace CarService.Services.Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IOrdersService
    {
        void CreateOrderZero(decimal price,string userId);

        void AddWorkToOrder(string userId,int workId, int issueId, int carId);

        IEnumerable<OrderServiceModel> GetAllOrders(string userId);

        DetailsOrderServiceModel DetailsOrder(string orderId,string  userId);

        void DeleteOrderService(string orderId, string userId);

        string GetUserByName(string userId);
    }
}
