using System.Diagnostics.CodeAnalysis;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp.BindingHelpers;
using webapp.Models;

namespace webapp.Pages.Candy;

public class AddModel : PageModel
{
    [BindFromForm]
    public string? CandyName { get; set; }
    
    [BindFromForm]
    public DateTimeOffset? ExpirationDate { get; set; }

    [BindFromForm] 
    public bool HasSpecialNote { get; set; } = false;
    
    [BindFromForm]
    public string? SpecialNote { get; set; }

    public IActionResult OnPost()
    {
        if (!ValidatePostedForm())
        {
            return Page();
        }
        
        var isAdded = CandiesRepository.AddCandy(CandyName, ExpirationDate, HasSpecialNote, SpecialNote);
        
        if(!isAdded)
        {
            ModelState.AddModelError(nameof(CandyName), "Another candy have this name");
            return Page();
        }
        
        return RedirectToPage("/Candy/Added");
    }

    [MemberNotNullWhen(true, nameof(CandyName))]
    [MemberNotNullWhen(true, nameof(ExpirationDate))]
    [MemberNotNullWhen(true, nameof(HasSpecialNote))]
    public bool ValidatePostedForm()
    {
        return AddModelValidator.Check(this);
    }
    
    public class AddModelValidator : PageModelValidator<AddModelValidator, AddModel>
    {
        public AddModelValidator() 
        {
            RuleFor(x => x.CandyName).NotEmpty();
            RuleFor(x => x.ExpirationDate).NotEmpty();
            RuleFor(x => x.HasSpecialNote).NotNull();
            RuleFor(x => x.SpecialNote).NotNull()
                .When(x => x.HasSpecialNote);
        }
    }
}