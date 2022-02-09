using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageApps_Project_0.Data;
using RazorPageApps_Project_0.Model;

// testing repo push

namespace RazorPageApps_Project_0.Pages.Categories;

public class IndexModel : PageModel
{
    // 1. Add readonly class with using statement '_db'
    private readonly ApplicationDbContext _db;

    // 4a. Create property that will hold the category list
    // from OnGet() below
    public IEnumerable<Category> Categories { get; set; } // 4b. Create enumerable on Category table called Categories

    // 2. Add constructor (ctor) to implement _db class above
    // using dependency injection
    //
    // 2a. If you registered anything inside the container and
    // want to implement it, see below
    // IndexModel(NameOfRegisteredAppService GiveToUsInVariableName)
    public IndexModel(ApplicationDbContext db)
    {
        _db = db; // 3. Locally assign our private var _db to db ... now _db will have an implementation that already connects to the database and we can use it from here
    }

    public void OnGet() // 4. Retrieve a list of all categories
    {
        Categories = _db.Category; // 4c. Populate Categories from the database
    }
}
