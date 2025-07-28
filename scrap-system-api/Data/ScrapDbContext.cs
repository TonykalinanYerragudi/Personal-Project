using System;
using Microsoft.EntityFrameworkCore;
using scrap_system_api.Models;

namespace scrap_system_api.Data;

public class ScrapDbContext : DbContext
{
  public ScrapDbContext(DbContextOptions<ScrapDbContext> options) : base(options)
  {

  }

  public DbSet<User> Users { get; set; }
  public DbSet<PickupRequest> PickupRequests { get; set; }
  public DbSet<Address> Addresses { get; set; }

}
