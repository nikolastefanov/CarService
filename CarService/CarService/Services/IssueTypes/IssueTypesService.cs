

namespace CarService.Services
{
    using CarService.Data;
    using CarService.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class IssueTypesService : IIssueTypesService
    {
        private readonly ApplicationDbContext data;

        public IssueTypesService(ApplicationDbContext data)
        {
            this.data = data;
        }


        public void AddNewCategory(string name, string imageUrl)
        {
            var issueType = new IssueType
            {
                Name = name,
                ImageUrl = imageUrl,
            };

            this.data.Add(issueType);

            this.data.SaveChanges();
        }

        public void Delete(int id)
        {
            var issueData = this.data
                .IssueTypes.Where(x => x.Id == id)
                .FirstOrDefault();

            this.data.IssueTypes.Remove(issueData);

            this.data.SaveChanges();
        }

        public IssueTypeModel Details(int id)
        {
            var issueType = this.data.IssueTypes
                .Where(x => x.Id == id)
                .Select(x => new IssueTypeModel
                {
                    Id=x.Id,
                    Name = x.Name,
                    ImageUrl = x.ImageUrl,
                }).FirstOrDefault();

            return issueType;
        }

        public bool Edit(int id, string name, string imageUrl)
        {

            var issueData = this.data.IssueTypes.Find(id);

        //TODO proverka dali ima issuetype
            if(false)
            {
                
            }

            issueData.Name = name;
            issueData.ImageUrl = imageUrl;

            this.data.SaveChanges();

            return true;
        }

        public IEnumerable<AllIssueTypeModel> GetAllCategory()
        {
            var category = this.data.IssueTypes
                      .Select(x => new AllIssueTypeModel
                      {
                          Id = x.Id,
                          Name = x.Name,
                          ImageUrl = x.ImageUrl,
                      })
                      .ToList();

            return category;
        }

        
    }
}
