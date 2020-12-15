﻿using Scores.Domain.Infrastructure;
using System.Threading.Tasks;

namespace Scores.Application.StandingsAdmin
{
    [Service]
    public class UpdateStandings
    {
        private readonly IStandingsManager standingsManager;

        public UpdateStandings(IStandingsManager standingsManager)
        {
            this.standingsManager = standingsManager;
        }

        public class Request
        {
            public int Id { get; set; }
            public int TeamCount { get; set; }
            public bool Deactivated { get; set; }
            public int TournamentId { get; set; }
        }

        public class Response
        {
            public int Id { get; set; }
            public int TeamCount { get; set; }
            public bool Deactivated { get; set; }
            public int TournamentId { get; set; }
        }

        public async Task<Response> Do(Request request)
        {
            var standings = standingsManager.GetStandingsById(request.Id, x => x);

            standings.TeamCount = request.TeamCount;
            standings.Deactivated = request.Deactivated;
            standings.TournamentId = request.TournamentId;

            await standingsManager.UpdateStandings(standings);

            return new Response
            {
                Id = standings.Id,
                TeamCount = standings.TeamCount,
                Deactivated = standings.Deactivated,
                TournamentId = standings.TournamentId,
            };
        }
    }
}