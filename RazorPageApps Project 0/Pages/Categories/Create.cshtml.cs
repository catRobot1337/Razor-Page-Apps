using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageApps_Project_0.Data;
using RazorPageApps_Project_0.Model;

namespace RazorPageApps_Project_0.Pages.Categories;

public class CreateModel : PageModel
{

    private readonly ApplicationDbContext _db;

    public CreateModel(ApplicationDbContext db)
    {
        _db = db;
    }

    [BindProperty] // Will bind Category object properties with the UI cshtml in asp-for and will populate inside the same 'Category' object
    public Category Category { get; set; } // Model for Category. Get category object set it as 'Category'

    public void OnGet()
    {
    }

    // In an MVC environment we would create an OnPost() action method.
    // But in Razor pages, we create handlers.
    // Handlers always start with the keyword "On" following the HTTP word that the handler will do.
    // IActionResult returns to some page or redirects to a view
    public async Task<IActionResult> OnPost()
    {
        _db.AddAsync(Category);
        _db.SaveChanges();
        return RedirectToPage("Index");
    }
}
