    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    namespace webapp.TagHelpers;

    [HtmlTargetElement("form")]
    public class UnpolyFormTagHelper : FormTagHelper
    {
        public UnpolyFormTagHelper(IHtmlGenerator generator)
            : base(generator)
        {
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
        }
    }