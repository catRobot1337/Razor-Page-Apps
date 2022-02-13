using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageApps_Project_0.Model;

namespace RazorPageApps_Project_0.Pages.Categories;

public class CreateModel : PageModel
{

    public Category Category { get; set; }

    public void OnGet()
    {
    }
}
