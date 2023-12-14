using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp.BindingHelpers;
using webapp.Models;

namespace webapp.Pages.Candy;

public class DetailsModel : PageModel
{
    [BindFromRoute]
    public required string CandyId { get; set; }
    
    public Models.Candy? Candy { get; set; }
    
    public IActionResult OnGet()
    {   
        var candyFound = CandiesRepository.GetCandy(CandyId);
        if (candyFound is null)
        {
            return new NotFoundResult();
        }

        Candy = candyFound;
        return Page();
    }
    
    public IActionResult OnPost()
    {
        CandiesRepository.RemoveCandy(CandyId);

        return RedirectToPage("/Candy/Deleted");
    }
}