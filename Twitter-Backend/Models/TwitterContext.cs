using System;
using Microsoft.EntityFrameworkCore;

namespace Twitter_Backend.Models
{
    public class TwitterContext : DbContext
    {
        public TwitterContext(DbContextOptions<TwitterContext> options)
            : base(options)
        {
        }

        public DbSet<Tweet> Tweets { get; set; }
    }
}
