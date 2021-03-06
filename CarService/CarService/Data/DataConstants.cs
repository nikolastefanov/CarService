
namespace CarService.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class DataConstants
    {
        public class Car
        {
            public const int MakeMinLength = 1;
            public const int MakeMaxLength = 20;
            public const string CarRegexPlateNumber = @"\w{8}"; //@"[A-Z]{2}[0-9]{4}[A-Z]{2}";
            public const int ModelMinLength = 1;
            public const int ModelMaxLength = 30;
            public const int YearMinValue = 1950;
            public const int YearMaxValue = 2021;
        }


        public class Mechanic
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 20;
            public const int PhoneNumberMinLength = 5;
            public const int PhoneNumberMaxLength = 10;
        }


        public class Issue
        {
            public const int DescripMinLength = 5;
            public const int DescripMaxLength = 300;
            public const int InpMinLength = 5;
            public const int InpMaxLength = 300;
        }


        public class IssueType
        {
            public const int IsTypeNameMinLength = 5;
            public const int IsTypeNameMaxLength = 100;

            public const int  IssueTypeMinLength= 5;
            public const int  IssueTypeMaxLength = 300;

   
        }

     
        public class Review
        {
            public const int ContentMinLength = 5;
            public const int ContentMaxLength = 300;
        }




        public class Work
        {
            public const int WorkMinLength = 10;
            public const int WorkMaxLength = 300;
            public const decimal WorkMinPrice = 0.0M;
            public const decimal WorkMaxPrice = 79228162514264337593543950335.0M;
        }
    }
}
