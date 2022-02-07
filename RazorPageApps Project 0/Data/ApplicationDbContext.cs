using Microsoft.EntityFrameworkCore;
using RazorPageApps_Project_0.Model;

namespace RazorPageApps_Project_0.Data;

//=============================================================
//
// This file implements the Db Context and acts like a data
// layer that will connect our application with the database.
//
// It must implement the Db context clause inside the EFC
// i.e. public class ApplicationDbContext : DbContext <-- for this
// to work we must add the following up top
// using Microsoft.EntityFrameworkCore;
//
//=============================================================


public class ApplicationDbContext: DbContext
{
    // Retrieves DbContextOptions on/from ApplicationDbContext and call it as options
    // then pass it on to the base class of DbContext.
    // This line of code is needed to make our app/efc/db connection to work.
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    // Once we've properly implemented the db context clause inside
    // the EFC we can add whatever table models we'd like below

    public DbSet<Category> NameOfTableCategory { get; set; }
}
