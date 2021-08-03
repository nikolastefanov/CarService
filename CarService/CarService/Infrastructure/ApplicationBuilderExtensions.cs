
namespace CarService.Infrastructure
{
    using CarService.Data;
    using CarService.Data.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System.Linq;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(
             this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<ApplicationDbContext>();

            data.Database.EnsureCreated();

            SeedCategories(data);

            return app;
        }

        private static void SeedCategories(ApplicationDbContext data)
        {
            if (!data.IssueTypes.Any())
            {

                   data.IssueTypes.AddRange(new[]
                   {
                       new IssueType { Name = "Engine" ,ImageUrl="https://fcache1.pakwheels.com/original/3X/4/d/4d9606406f5850e351b358bbfe9d3cb91e07c0fe.jpg "},
                       new IssueType { Name = "Transmission",ImageUrl="https://www.mediastorehouse.com.au/p/617/modern-car-5-speed-manual-gearbox-cross-section-9596591.jpg " },
                       new IssueType { Name = "Diagnostics" ,ImageUrl="https://previews.123rf.com/images/nitroxelmares/nitroxelmares1604/nitroxelmares160400021/55664614-car-diagnostics-test-service-illustration-isolated-on-white.jpg "},
                       new IssueType { Name = "Brake system" ,ImageUrl="https://www.anatomynote.com/wp-content/uploads/2019/05/6189/Car-brake-system-diagram.jpg "},
                       new IssueType { Name = "Electrical system" ,ImageUrl="https://www.newkidscar.com/wp-content/uploads/2019/04/electrical-system.jpg "},
                       new IssueType { Name = "Body" ,ImageUrl="https://us.123rf.com/450wm/nosua/nosua1609/nosua160900260/63522079-concept-car-painted-red-body-and-primed-parts-near-isolated-on-white-background-3d-render.jpg?ver=6"},
                       new IssueType { Name = "Tires " ,ImageUrl="https://www.napolitan.it/wp-content/uploads/2019/06/pneumatici-4-stagioni-300x260.jpg"},
                         new IssueType { Name = "air conditioner" ,ImageUrl=" https://media.istockphoto.com/photos/car-air-conditioner-system-in-car-garage-car-air-conditioner-check-picture-id1179826380"},
                         new IssueType { Name = "Technical inspeccion" ,ImageUrl="https://www.theolivepress.es/wp-content/uploads/2020/01/itvvv.jpg?width=1200&enable=upscale"},
                   });
                 
                   data.SaveChanges();              
            }

           return;
        }
     
    }
}
