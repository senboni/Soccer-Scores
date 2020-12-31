﻿using Scores.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scores.Domain.Infrastructure
{
    public interface IPlayerManager
    {
        Task<int> CreatePlayer(Player player);
        Task<int> DeletePlayer(int id);
        Task<int> UpdatePlayer(Player player);

        TResult GetPlayerById<TResult>(int id, Func<Player, TResult> selector);
        IEnumerable<TResult> GetPlayersByClubId<TResult>(int id, Func<Player, TResult> selector);
    }
}
