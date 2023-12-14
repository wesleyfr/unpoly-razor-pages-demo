using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace webapp.TagHelpers;

[HtmlTargetElement("a", Attributes = "is-active-page")]
public class ActiveClassTagHelper : AnchorTagHelper
{
    public ActiveClassTagHelper(IHtmlGenerator generator)
        : base(generator)
    {
    }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        var currentPage = ViewContext.RouteData.Values["page"] as string;
        var currentArea = ViewContext.RouteData.Values["area"] as string ?? string.Empty;

        var baseArea = base.Area ?? RazorViewEngine.GetNormalizedRouteValue(ViewContext, "area");

        if (currentPage == base.Page && currentArea == baseArea)
        {
            var classValue = "active";
            output.AddClass(classValue, HtmlEncoder.Default);
        }
    }
}