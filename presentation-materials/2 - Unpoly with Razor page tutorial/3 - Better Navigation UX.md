# Prerequisite

Add `up-main` and `up-hungry`

`_Layout.cshtml`
```cs
...
<p class="candies-events" up-hungry>
...
<nav class="flex-container-nav navigation-menu" up-hungry>
...
<section class="content" up-main>  
    @RenderBody()  
</section>
```

# Keep scroll position when navigating

`UnpolyAnchorTagHelper`:
```cs
output.Attributes.Add(new TagHelperAttribute(  
    "up-scroll",   
	"false",   
	HtmlAttributeValueStyle.DoubleQuotes));
```

`UnpolyFormTagHelper`:
```cs
output.Attributes.Add(new TagHelperAttribute(  
    "up-scroll",   
	"false",   
	HtmlAttributeValueStyle.DoubleQuotes));
```

# Link feedback animation

`website.css`
```css
/* link feedback underline animation */ 
/* https://codepen.io/hugo_newton/embed/jOGKabK/?theme-id=modal */
a {  
  padding-bottom: 2px;  
}  
a.up-active {  
  text-decoration: none;  
  border-bottom: none;  
  padding-bottom: 2px;  
  background-repeat: repeat;  
  background-image: url("data:image/svg+xml;charset=utf8,%3Csvg id='squiggle-link' xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' xmlns:ev='http://www.w3.org/2001/xml-events' viewBox='0 0 10 18'%3E%3Cstyle type='text/css'%3E.squiggle%7Banimation:shift .5s linear infinite;%7D@keyframes shift %7Bfrom %7Btransform:translateX(-10px);%7Dto %7Btransform:translateX(0);%7D%7D%3C/style%3E%3Cpath fill='none' stroke='white' stroke-width='1' class='squiggle' d='M0,17.5 c 2.5,0,2.5,-1.5,5,-1.5 s 2.5,1.5,5,1.5 c 2.5,0,2.5,-1.5,5,-1.5 s 2.5,1.5,5,1.5' /%3E%3C/svg%3E");  
}
```

# Loading zone animation (skip for demo)

```css
/* Loading zone animation */
/* https://dev.to/chokcoco/fantastic-css-border-animation-5166 */  
.content {  
  outline: 1px solid transparent;  
  outline-offset: -1px;  
  transition: all 0.3s linear;  
}  
.content.up-loading {  
  outline: 1px solid transparent;  
  background: linear-gradient(90deg, #fff 50%, transparent 0) repeat-x, linear-gradient(90deg, #fff 50%, transparent 0) repeat-x, linear-gradient(0deg, #fff 50%, transparent 0) repeat-y, linear-gradient(0deg, #fff 50%, transparent 0) repeat-y;  
  background-size: 4px 1px, 4px 1px, 1px 4px, 1px 4px;  
  background-position: 0 0, 0 100%, 0 0, 100% 0;  
  -webkit-animation: linearGradientMove 0.3s infinite linear;  
  animation: linearGradientMove 0.3s infinite linear;  
}  
  
@-webkit-keyframes linearGradientMove {  
  100% {  
    background-position: 4px 0, -4px 100%, 0 -4px, 100% 4px;  
  }}  
  
@keyframes linearGradientMove {  
  100% {  
    background-position: 4px 0, -4px 100%, 0 -4px, 100% 4px;  
  }}
```

# Next previous/search page

Add `up-hungry`, `up-transition` and `up-target`.

`Search.cshtml`
```html
<div class="flex-container next-previous" up-hungry>

<a asp-page="/Candies/Search" asp-route-pagenumber="@Model.PreviousPageNumber" asp-route-searchtext="@Model.SearchText" asp-fragment="candies"   
up-transition="move-right" up-target=".candy-search">Previous page</a>  
<a asp-page="/Candies/Search" asp-route-pagenumber="@Model.NextPageNumber" asp-route-searchtext="@Model.SearchText" asp-fragment="candies"   
up-transition="move-left" up-target=".candy-search">Next page</a>
```