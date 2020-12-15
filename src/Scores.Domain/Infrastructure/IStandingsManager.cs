﻿using Scores.Domain.Models;
using System;
using System.Threading.Tasks;

namespace Scores.Domain.Infrastructure
{
    public interface IStandingsManager
    {
        Task<int> CreateStandings(Standings standings);
        Task<int> DeleteStandings(int id);
        Task<int> UpdateStandings(Standings standings);

        TResult GetStandingsById<TResult>(int id, Func<Standings, TResult> selector);

        Task<int> AddClub(int standingsId, int clubId);
        Task<int> RemoveClub(int id);
    }
}
