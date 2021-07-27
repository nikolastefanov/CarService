

namespace CarService.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IIssueTypesService
    {
        IEnumerable<AllIssueTypeModel> GetAllCategory();

        void AddNewCategory(string name, string imageUrl);

        IssueTypeModel Details(int id);

        bool Edit(int id, string name, string imageUrl);

        void Delete(int id);
    }
}
