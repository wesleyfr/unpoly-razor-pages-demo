# Search on type

Add `up-hungry`, `up-focus="input"`, `up-autosubmit` and `up-watch-delay="100"`

`Search.cshtml`
```html
<form method="get" asp-fragment="candies" up-target=".candy-search" up-focus="input" up-watch-disable="button">  
    <input asp-for="SearchText" autofocus placeholder="Search" style="display: inline;" up-autosubmit up-watch-delay="100" />  
    <button type="submit">Search</button>  
</form>  
<p id="candies" up-hungry>Found @Model.NbSearchResult candies</p>
...
<div class="flex-container next-previous" up-hungry>
```

# Conditional form field

Add class `has-special-note-field`.
Add `up-switch=".has-special-note-field"` and `up-show-for="true"`.

`Add.cshtml`
```html
<fieldset>  
    <label asp-for="HasSpecialNote">Has special note ?</label>  
    <input asp-for="HasSpecialNote" up-switch=".has-special-note-field"/>  
    <span asp-validation-for="HasSpecialNote"></span>  
</fieldset>  
<fieldset class="has-special-note-field" up-show-for="true">  
    <label asp-for="SpecialNote">Special note</label>  
    <input asp-for="SpecialNote"/>  
    <span asp-validation-for="SpecialNote"></span>  
</fieldset>
```