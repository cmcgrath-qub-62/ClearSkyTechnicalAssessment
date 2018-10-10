using ClearSkyLogicTechnicalAssessment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClearSkyLogicTechnicalAssessment.Database
{
    public class SubscriberDbContext : DbContext
    {
        public DbSet<Subscriber> Subscribers { get; set; }

        public SubscriberDbContext(DbContextOptions<SubscriberDbContext> options) : base(options)
        {

        }
    }
}
