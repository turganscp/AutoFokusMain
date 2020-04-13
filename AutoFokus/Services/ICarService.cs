using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoFokus.Models;


namespace AutoFokus.Services
{
    public interface ICarService
    {
        Task<Car[]> GetIncompleteItemsAsync();
    }
}
