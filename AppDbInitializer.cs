using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporortApp.Models;

namespace TransporortApp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope=applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //TransportType
                if (!context.TransportTypes.Any())
                {
                    context.TransportTypes.AddRange(new List<TransportType>(){
                        new TransportType()
                        {
                            TransportTypeName="Легковой",
                        },
                        new TransportType()
                        {
                            TransportTypeName="Грузовой",
                        },
                    });
                    context.SaveChanges();
                }
                    //TransportCategory
                if (!context.TransportCategories.Any())
                {
                    context.TransportCategories.AddRange(new List<TransportCategory>(){
                        new TransportCategory()
                        {
                            CategoryName="Седаны",
                            TransportTypeId=1,
                        },
                        new TransportCategory()
                        {
                            CategoryName="Хэтчбеки",
                            TransportTypeId=1,
                        },
                        new TransportCategory()
                        {
                            CategoryName="Универсалы",
                            TransportTypeId=1,
                        },
                        new TransportCategory()
                        {
                            CategoryName="Купе",
                            TransportTypeId=1,
                        },
                         new TransportCategory()
                        {
                            CategoryName="Кабриолеты",
                            TransportTypeId=1,
                        },
                          new TransportCategory()
                        {
                            CategoryName="Минивэны",
                            TransportTypeId=1,
                        },
                           new TransportCategory()
                        {
                            CategoryName="Фургоны",
                            TransportTypeId=2,
                        },
                           new TransportCategory()
                        {
                            CategoryName="Пикапы",
                            TransportTypeId=2,
                        },
                           new TransportCategory()
                        {
                            CategoryName="Грузовики с контейнером",
                            TransportTypeId=2,
                        },
                            new TransportCategory()
                        {
                            CategoryName="Самосвалы",
                            TransportTypeId=2,
                        },
                    });
                    context.SaveChanges();
                }
                //FuelType
                if(!context.FuelTypes.Any())
                {
                    context.FuelTypes.AddRange(new List<FuelType>() { 
                        new FuelType()
                        { 
                            FuelTypeName="fuel_1"
                        },
                        new FuelType()
                        {
                            FuelTypeName="fuel_2"
                        },
                        new FuelType()
                        {
                            FuelTypeName="fuel_3"
                        },
                    });
                    context.SaveChanges();
                }
                //Manufacturers
                if(!context.Manufacturers.Any())
                {
                    context.Manufacturers.AddRange(new List<Manufacturer>() { 
                        new Manufacturer()
                        { 
                            ManufacturerName="manufacturer_1",
                        },
                        new Manufacturer()
                        {
                            ManufacturerName="manufacturer_2",
                        },
                        new Manufacturer()
                        {
                            ManufacturerName="manufacturer_3",
                        },


                    });
                    context.SaveChanges();
                }
                //Brand
                if(!context.TransportBrands.Any())
                {
                    context.TransportBrands.AddRange(new List<TransportBrand>() { 
                        new TransportBrand()
                        { 
                            BrandName="BrandCar1",
                            ManufacturerId=1,
                        },
                        new TransportBrand()
                        {
                            BrandName="BrandCar2",
                            ManufacturerId=2,
                        },
                        new TransportBrand()
                        {
                            BrandName="BrandCar3",
                            ManufacturerId=3,
                        },
                        new TransportBrand()
                        {
                            BrandName="BrandCar4",
                            ManufacturerId=1,
                        },


                    });
                    context.SaveChanges();
                }
                //TransportType
                if (!context.Transports.Any())
                {
                    context.Transports.AddRange(new List<Transport>(){
                        new Transport()
                        {
                            TransportName="Car-1",
                            CategoryId=1,
                            BrandId=1,
                            FuelId=1,
                        },
                         new Transport()
                        {
                            TransportName="Car-2",
                            CategoryId=2,
                            BrandId=3,
                            FuelId=1,
                        },
                          new Transport()
                        {
                            TransportName="Car-3",
                            CategoryId=1,
                            BrandId=2,
                            FuelId=1,
                        },
                           new Transport()
                        {
                            TransportName="Car-4",
                            CategoryId=4,
                            BrandId=4,
                            FuelId=2,
                        },
                            new Transport()
                        {
                            TransportName="Car-5",
                            CategoryId=10,
                            BrandId=1,
                            FuelId=3,
                        },

                    });
                    context.SaveChanges();
                }


            }
        }
    }
}
