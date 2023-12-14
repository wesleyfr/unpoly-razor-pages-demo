
# Install Unpoly JS & CSS

Add `unpoly.min.css` and `unpoly.min.js`

`_Layout.cshtml`
```html
<link rel="stylesheet" href="~/css/water.css" />  
<link rel="stylesheet" href="~/css/snackbar.css" />  
<link rel="stylesheet" href="~/lib/unpoly/unpoly.min.css" />
...
...
<script src="~/lib/unpoly/unpoly.min.js"></script>  
<script src="~/js/site.js" asp-append-version="true"></script>
```



# Manual setup (to learn Unpoly)

## Setup links

Add `up-follow` to anchor tags

`_Layout.cshtml`
```html
<a is-active-page asp-area="" asp-page="/Candies/Search" up-follow>All candies</a>  
<a is-active-page asp-area="" asp-page="/Candy/Add" up-follow>Add a candy</a>  
<a is-active-page asp-area="" asp-page="/Privacy" up-follow>Privacy</a>  
<a is-active-page asp-area="" asp-page="/BrokenPage" up-follow>Broken page</a>
```

👉 Loading indicator
👉 No more blinking, pages are not full reloaded, only what changed
👉 Page loading are faster because of caching
👉 ⚠️ But caching broke the page Privacy with its current time

## Disable caching

Add `up-cache=false` to anchor tags

```html
	<a is-active-page asp-area="" asp-page="/Candies/Search" up-follow up-cache="false">All candies</a>  
	<a is-active-page asp-area="" asp-page="/Candy/Add" up-follow>Add a candy</a>  
	<a is-active-page asp-area="" asp-page="/Privacy" up-follow up-cache="false">Privacy</a>  
	<a is-active-page asp-area="" asp-page="/BrokenPage" up-follow up-cache="false">Broken page</a>
```
👉 cache is removed for dynamic pages
👉 cache is enabled for static form `/Candy/Add`

## Setup forms

Add `up-submit` and `up-disable="button"`
https://unpoly.com/disabling-forms

`Add.cshtml`:
```html
<form method="post" id="add-candy-form" asp-fragment="add-candy-form" up-submit  up-disable="button">
```


# Automatic setup
## Setup razor tag helper

Remove custom attributes in `_Layout.cshtml`:
```html
<a is-active-page asp-area="" asp-page="/Candies/Search">All candies</a>  
<a is-active-page asp-area="" asp-page="/Candy/Add" up-cache="true">Add a candy</a>  
<a is-active-page asp-area="" asp-page="/Privacy">Privacy</a>
<a is-active-page asp-area="" asp-page="/BrokenPage">Broken page</a>
```

Remove custom attributes in `Add.cshtml`:
```html
<form method="post" id="add-candy-form" asp-fragment="add-candy-form"> 
```

Add file `UnpolyAnchorTagHelper`:
```cs
using Microsoft.AspNetCore.Mvc.TagHelpers;  
using Microsoft.AspNetCore.Mvc.ViewFeatures;  
using Microsoft.AspNetCore.Razor.TagHelpers;  
  
namespace webapp.TagHelpers;  
  
[HtmlTargetElement("a")]  
public class UnpolyAnchorTagHelper : AnchorTagHelper  
{  
    public UnpolyAnchorTagHelper(IHtmlGenerator generator)  
        : base(generator)  
    {    }  
    
    public override void Process(
	    TagHelperContext context, 
	    TagHelperOutput output)  
    {        
	    output.Attributes.Add(new TagHelperAttribute(  
			"up-follow",   
			null,  
			HtmlAttributeValueStyle.Minimized));  
	    output.Attributes.Add(new TagHelperAttribute(  
	        "up-cache",   
			"false",   
			HtmlAttributeValueStyle.DoubleQuotes));  
    }
}
```

Add file `UnpolyFormTagHelper`:
```cs
using Microsoft.AspNetCore.Mvc.TagHelpers;  
using Microsoft.AspNetCore.Mvc.ViewFeatures;  
using Microsoft.AspNetCore.Razor.TagHelpers;  
  
namespace webapp.TagHelpers;  
  
[HtmlTargetElement("form")]  
public class UnpolyFormTagHelper : FormTagHelper  
{  
    public UnpolyFormTagHelper(IHtmlGenerator generator)  
        : base(generator)  
    {    }  
    
    public override void Process(
	    TagHelperContext context, 
	    TagHelperOutput output)  
    {        
	    output.Attributes.Add(new TagHelperAttribute(  
           "up-submit",   
			null,  
            HtmlAttributeValueStyle.Minimized));  
        output.Attributes.Add(new TagHelperAttribute(  
            "up-disable",   
			"button",   
			HtmlAttributeValueStyle.DoubleQuotes));  
    }
}
```

# Benefits

By Adding:
 - Unpoly JS and CSS
 - classes `UnpolyAnchorTagHelper.cs` and `UnpolyFormTagHelper.cs` 
 - a tag `up-cache="true"` on `/Candy/Add`

We:
 - Increased loading performances
 - Better navigation/loading UX (progress bar + no blinking)
 - Better form UX (disabled buttons as an indicator of submission)
 - Removed double click form submission common issue