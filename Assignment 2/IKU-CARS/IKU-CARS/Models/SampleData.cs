using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace IKU_CARS.Models
{
    public class SampleData : DropCreateDatabaseAlways<IKUCarDB>
    {
        protected override void Seed(IKUCarDB context)
        {
            var cars = new List<Car>
            {
                new Car
                {
                    Maker = "Audi",
                    Model = "R8",
                    Year = 2021,
                    CType = "Sport",
                    CImage = "Audi_R8.jpg",
                    Price = 95.25m,
                    CAvailable = true
                },
                new Car
                {
                    Maker = "Audi",
                    Model = "A3",
                    Year = 2022,
                    CType = "Sport",
                    CImage = "Audi_a3.jpg",
                    Price = 32.99m,
                    CAvailable = true
                },
                new Car
                {
                    Maker = "Audi",
                    Model = "Sedan",
                    Year = 2020,
                    CType = "Normal",
                    CImage = "Audi_Sedan.png",
                    Price = 84.5m,
                    CAvailable = false
                },
                new Car
                {
                    Maker = "Audi",
                    Model = "VAN",
                    Year = 2021,
                    CType = "Family",
                    CImage = "Audi_Van.jpg",
                    Price = 21.84m,
                    CAvailable = true
                },
                new Car
                {
                    Maker = "BMW",
                    Model = "i7",
                    Year = 2022,
                    CType = "Normal",
                    CImage = "BMW_i7.png",
                    Price = 12.6m,
                    CAvailable = true
                },
                new Car
                {
                    Maker = "BMW",
                    Model = "i8",
                    Year = 2022,
                    CType = "Sport",
                    CImage = "BMW_i8.jpg",
                    Price = 56.38m,
                    CAvailable = true
                },
                new Car
                {
                    Maker = "BMW",
                    Model = "VAN",
                    Year = 2021,
                    CType = "Family",
                    CImage = "BMW_Van.jpg",
                    Price = 41.29m,
                    CAvailable = false
                },
                new Car
                {
                    Maker = "BMW",
                    Model = "X5",
                    Year = 2021,
                    CType = "Family",
                    CImage = "BMW_X5.png",
                    Price = 18.73m,
                    CAvailable = true
                },
                new Car
                {
                    Maker = "Hyundai",
                    Model = "VAN",
                    Year = 2022,
                    CType = "Family",
                    CImage = "Hundai_Van.jpg",
                    Price = 38.88m,
                    CAvailable = true
                },
                new Car
                {
                    Maker = "Hyundai",
                    Model = "bayon",
                    Year = 2020,
                    CType = "Family",
                    CImage = "Hundai_bayon.jpg",
                    Price = 16.59m,
                    CAvailable = true
                },
                new Car
                {
                    Maker = "Hyundai",
                    Model = "Elantra",
                    Year = 2021,
                    CType = "Normal",
                    CImage = "Hundai_Elantra.jpg",
                    Price = 21.05m,
                    CAvailable = false
                },
                new Car
                {
                    Maker = "Hyundai",
                    Model = "i10",
                    Year = 2021,
                    CType = "Normal",
                    CImage = "Hundai_i10.jpg",
                    Price = 11.5m,
                    CAvailable = true
                },
                new Car
                {
                    Maker = "Hyundai",
                    Model = "i20",
                    Year = 2021,
                    CType = "Family",
                    CImage = "Hundai_i20.jpg",
                    Price = 17.6m,
                    CAvailable = true
                },
                new Car
                {
                    Maker = "Hyundai",
                    Model = "Kona",
                    Year = 2022,
                    CType = "Family",
                    CImage = "Hundai_kona.jpg",
                    Price = 30.3m,
                    CAvailable = true
                },
                new Car
                {
                    Maker = "Hyundai",
                    Model = "F1",
                    Year = 2022,
                    CType = "Sport",
                    CImage = "Hundai_Sport.jpg",
                    Price = 105.59m,
                    CAvailable = true
                },
                new Car
                {
                    Maker = "Hyundai",
                    Model = "Tucson",
                    Year = 2021,
                    CType = "Normal",
                    CImage = "Hundai_Tucson.jpg",
                    Price = 29.2m,
                    CAvailable = false
                }
            };

            cars.ForEach(c => context.Cars.Add(c));
            context.SaveChanges();
        }
    }
}
