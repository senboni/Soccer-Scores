﻿using Microsoft.EntityFrameworkCore;
using Scores.Domain.Entities;
using System;

namespace Scores.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.LogTo(Console.WriteLine);

        public DbSet<City> Cities { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Incident> Events { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Standings> Standings { get; set; }
        public DbSet<ClubStandings> ClubStandings { get; set; }
        public DbSet<MatchPlayer> MatchPlayers { get; set; }
    }
}
