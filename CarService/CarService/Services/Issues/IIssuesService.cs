using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Services.Issues
{
    public interface IIssuesService
    {
        void AddIssueToCar(string description, int carId);

        CarIssuesServiceModel GetAllIssues(int carId);

        CarIssuesServiceModel DetailsIssue(int issueId, int carId);

        void DeleteToIssue(int issueId, int carId);

        void EditIssue(int issueId, int carId, string description);
    }
}
