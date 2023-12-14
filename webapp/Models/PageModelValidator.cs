using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Models;

public class PageModelValidator<TValidator, TPageModel> : AbstractValidator<TPageModel>
    where TPageModel : PageModel
    where TValidator : AbstractValidator<TPageModel>, new() 
{
#if DEBUG
    private static TValidator Instance => new();
#else
    private static readonly TValidator Instance = new();
#endif

    public static bool Check(TPageModel pageModel)
    {
        var result = Instance.Validate(pageModel);
        if (!result.IsValid) 
        {
            // Copy the validation results into ModelState.
            // ASP.NET uses the ModelState collection to populate 
            // error messages in the View.
            result.AddToModelState(pageModel.ModelState);
        }

        return result.IsValid;
    }
}