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
            output.Attributes.Add(new TagHelperAttribute(  
                "up-submit",   
                null,  
                HtmlAttributeValueStyle.Minimized));  
            output.Attributes.Add(new TagHelperAttribute(  
                "up-disable",   
                "button",   
                HtmlAttributeValueStyle.DoubleQuotes));
            output.Attributes.Add(new TagHelperAttribute(  
                "up-scroll",   
                "false",   
                HtmlAttributeValueStyle.DoubleQuotes));
        }
    }