using System.Diagnostics.CodeAnalysis;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp.BindingHelpers;
using webapp.Models;

namespace webapp.Pages.Candy;

public class CommentsModel : PageModel
{
    [BindFromRoute]
    public required string CandyId { get; set; }
    
    [BindFromForm]
    public string? Comment { get; set; }
    
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
        var candyFound = CandiesRepository.GetCandy(CandyId);
        if (candyFound is null)
        {
            return new NotFoundResult();
        }
        Candy = candyFound;
        
        if (!ValidatePostedForm())
        {
            return Page();
        }
        
        CandiesRepository.AddCandyComment(Candy.Id, Comment);
        Comment = string.Empty;

        return Page();
    }
    
    
    [MemberNotNullWhen(true, nameof(Comment))]
    public bool ValidatePostedForm()
    {
        return CommentsModelValidator.Check(this);
    }
    
    public class CommentsModelValidator : PageModelValidator<CommentsModelValidator, CommentsModel>
    {
        public CommentsModelValidator() 
        {
            RuleFor(x => x.Comment)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(200);
        }
    }
}