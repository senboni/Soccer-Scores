﻿using Scores.Domain.Infrastructure;
using Scores.Domain.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Scores.Database
{
    public class CityManager : ICityManager
    {
        private readonly AppDbContext context;

        public CityManager(AppDbContext context)
        {
            this.context = context;
        }

        public Task<int> CreateCity(City city)
        {
            context.Cities.Add(city);

            return context.SaveChangesAsync();
        }

        public TResult GetCityById<TResult>(int id, Func<City, TResult> selector) =>
             context.Cities
                .Where(x => x.Id == id)
                .Select(selector)
                .FirstOrDefault();
    }
}
