using CinemaWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebApi.Data
{
    public class CinemaDbContext : DbContext
    {
        //dbcontext is what applies CRUD operation

        //thedbcontextoptions contains the database provider to use, connection strings , and any other DB related config information

        public CinemaDbContext(DbContextOptions<CinemaDbContext>options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
