

namespace CarService.Services.Cars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface ICarsService
    {

        IEnumerable<CarIssueTypeServiceModel> AllIssueTypes();

        void AddCar(string userId
            ,string make
            , string model
            , string plateNumber
            , string imageUrl
            , int year
            , int issueType);

        IEnumerable<CarListingServiceModel> GetAllCar();

        IEnumerable<CarServiceModel> GetAllCarAdmin();

        CarDetailsServiceModel CarDetails(int id);

        bool EditCar(
               int id
              , string make
              , string model
              , String plateNumber
              , string imageUrl
              , int year
              , int issueTypeId);

        void DeleteCar(int carId);
    }
 
}
