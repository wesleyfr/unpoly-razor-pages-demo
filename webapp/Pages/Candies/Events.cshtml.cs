using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp.Models;

namespace webapp.Pages.Candies;

public class EventsModel : PageModel
{
    public void OnPost()
    {
        CandiesRepository.MarkEventsAreRead();
    }
}