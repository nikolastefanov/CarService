
namespace CarService.Services.Works
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IWorksService
    {
        bool CreateWork(string userId,int issueId,string description, decimal price,int carId);

        IEnumerable<IssueWorkServiceModel> GetAllWorks(int issueId,int carId);

        void DeleteToWork(int workId, int issueId,int carId);

        WorkServiceModel DetailsWork(int workId, int issueId, int carId);

        bool EditToWork(int workId, int iissueId, int carId
                     , string description, decimal price);
    }
}
