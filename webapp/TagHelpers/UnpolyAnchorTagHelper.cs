    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    namespace webapp.TagHelpers;

    [HtmlTargetElement("a")]
    public class UnpolyAnchorTagHelper : AnchorTagHelper
    {
        public UnpolyAnchorTagHelper(IHtmlGenerator generator)
            : base(generator)
        {
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
        }
    }