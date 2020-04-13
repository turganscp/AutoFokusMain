using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoFokus.Models;

namespace AutoFokus.Services
{
    public class FakeCarItemService : ICarService
    {
        public Task<Car[]> GetIncompleteItemsAsync()
        {
            var item1 = new Car
            {
                CarId = 1,
                Brand = "Test",
                Price = 100000,
                Describtion = "I dårlig stand",
                Year = 2005

            };
            var item2 = new Car
            {
                CarId = 1,
                Brand = "Test",
                Price = 100000,
                Describtion = "I god stand",
                Year = 2005
            };
            return Task.FromResult(new[] { item1, item2 });
        }
    }
}
