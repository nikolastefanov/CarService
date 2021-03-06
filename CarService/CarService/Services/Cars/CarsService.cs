

namespace CarService.Services.Cars
{
    using CarService.Data.Models;
    using CarService.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    using static CarService.Data.DataConstants;
    using Car = Data.Models.Car;

    public class CarsService : ICarsService
    {
        private readonly ApplicationDbContext data;

        public CarsService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public void AddCar(string userId
            ,string make
            ,string model
            , string plateNumber
            , string imageUrl
            , int year
            , int issueType)
        {
            var carData = new Car
            {
                UserId=userId,
                Make=make,
                Model=model,
                PlateNumber=plateNumber,
                ImageUrl=imageUrl,
                Year=year,
                IssueTypeId=issueType,
                IsDelete=false,
            };
            
             this.data.Cars.Add(carData);
             this.data.SaveChanges();
        }

        public IEnumerable<CarIssueTypeServiceModel> AllIssueTypes()
        {
            var issueTypes = this.data
                .IssueTypes
                .Select(c => new CarIssueTypeServiceModel
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToList();
                
            return issueTypes;
        }

        public CarDetailsServiceModel CarDetails(int id)
        {
            var car = this.data
                .Cars
                .Where(x => x.Id == id && x.IsDelete==false )
                .Select(x => new CarDetailsServiceModel
                {
                    Id=x.Id,
                    Make=x.Make,
                    Model=x.Model,
                    PlateNumber=x.PlateNumber,
                    ImageUrl=x.ImageUrl,
                    Year=x.Year,
                    IssueTypeId=x.IssueTypeId,                
                })
                .FirstOrDefault();

                return car; 
        }

        public void DeleteCar(int carId)
        {

            var carData = this.data
                .Cars.Where(x => x.Id == carId && x.IsDelete==false)
                .FirstOrDefault();

            carData.IsDelete = true;
            
            this.data.SaveChanges();
        }

        public bool EditCar(
              int id
            , string make
            , string model
            , string plateNumber
            , string imageUrl
            , int year
            , int issueTypeId)
        {
            var carData = this.data
              .Cars
              .Where(x => x.IsDelete == false)
              .FirstOrDefault(x => x.Id == id);
            
             
              if (carData==null)
              {
                return false;
              }

            carData.Make = make;
             carData.Model = model;
            carData.PlateNumber = plateNumber;
            carData.ImageUrl = imageUrl;
            carData.Year = year;
            carData.IssueTypeId = issueTypeId;

              this.data.SaveChanges();
         
            return true;
        }

        public IEnumerable<CarListingServiceModel> GetAllCar(string userId)
        {
            var cars = this.data
                .Cars
                .Where(x=>x.UserId==userId && x.IsDelete==false)
                .Select(x => new CarListingServiceModel
                {
                    Id=x.Id,
                    Make=x.Make,
                    Model=x.Model,
                    PlateNumber=x.PlateNumber,
                    ImageUrl=x.ImageUrl,
                    Year=x.Year,
                    IssueTypeId=x.IssueTypeId,
                    IssueType=x.IssueType.Name,
                    RemainingIssues = x.Issues.Count(i => !i.IsFixed),
                    FixedIssues = x.Issues.Count(i => i.IsFixed),
                })
                .ToList();
            
                return cars;
        }

        public IEnumerable<CarListingServiceModel> GetAllCar()
        {
            var cars = this.data
                .Cars
                .Where(x=>x.IsDelete==false)
                .Select(x => new CarListingServiceModel
                {
                    Id = x.Id,
                    Make = x.Make,
                    Model = x.Model,
                    PlateNumber = x.PlateNumber,
                    ImageUrl = x.ImageUrl,
                    Year = x.Year,
                    IssueTypeId = x.IssueTypeId,
                    IssueType = x.IssueType.Name,
                    RemainingIssues = x.Issues.Count(i => !i.IsFixed),
                    FixedIssues = x.Issues.Count(i => i.IsFixed),
                })
                .ToList();

            return cars;
        }


        public IEnumerable<CarServiceModel> GetAllCarAdmin()
        {
            var cars = this.data.Cars
                .Where(x=>x.IsDelete==false)
                .Select(x => new CarServiceModel
                {
                    Id=x.Id,
                    Make=x.Make,
                    Model=x.Model,
                    PlateNumber=x.PlateNumber,
                    Year=x.Year,
                    ImageUrl=x.PlateNumber,
                    IssueTypeName=x.IssueType.Name,
                    
                })
                .ToList();

                return cars;
        }

      
    }  
   
}

