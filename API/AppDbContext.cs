using System;
using System.Security.Cryptography.X509Certificates;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API;

public class AppDbContext: DbContext
{

public AppDbContext(DbContextOptions options): base(options)
{
}
    public DbSet<AppUser> AppUsers {get;set;}

}
