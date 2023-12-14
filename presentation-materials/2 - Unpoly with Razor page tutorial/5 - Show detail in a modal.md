Add `up-layer="new"`

`Search.cshtml`
```cs
<a asp-page="/Candy/Details" asp-route-candyid="@candy.Id" up-layer="new">
```

Add `up-layer="parent"`

`Details.cshtml`
```html
<form method="post" up-layer="parent">  
    <div asp-validation-summary="All"><span>Error while deleting the candy</span></div>  
    <button type="submit">Delete this candy</button>  
</form>
```

`site.css`
```css
up-modal-box {  
  background-color: rgb(56, 64, 74);  
  padding: 20px;  
}
```