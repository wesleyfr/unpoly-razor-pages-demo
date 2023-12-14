using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp.BindingHelpers;
using webapp.Models;

namespace webapp.Pages.Candies;

public class SearchModel : PageModel
{
    public const int TopCountCandiesSearch = 6;
    
    [BindFromQueryString]
    public string? SearchText { get; set; }
    
    [BindFromQueryString]
    public int? PageNumber { get; set; }

    public int PageNumberNotNull => PageNumber ?? 0;
    public int NextPageNumber => PageNumberNotNull + 1;
    public int PreviousPageNumber => Math.Max(0, PageNumberNotNull - 1);
        
    public IReadOnlyList<Models.Candy> CandiesSearchResult { get; private set; } = new List<Models.Candy>();
    public int NbSearchResult { get; private set; }

    private void Search()
    {
        (NbSearchResult, CandiesSearchResult) = 
            CandiesRepository.SearchCandies(
                SearchText, 
                PageNumberNotNull * TopCountCandiesSearch, 
                TopCountCandiesSearch);
    }

    public void OnGet()
    {
        Search();
    }

    public IActionResult OnPost()
    {
        PageNumber = 0;
        Search();
        return Page();
    }
}
