using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WhatIcookDinner.Data;
using WhatIcookDinner.Models;

namespace WhatIcookDinner.Data;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Dinner> Dinners { get; set; }
    public DbSet<Desserts> Desserts { get; set; }
    public DbSet<Soup> Soups { get; set; }
}