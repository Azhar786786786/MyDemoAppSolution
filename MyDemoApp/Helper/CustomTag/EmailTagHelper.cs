using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MyDemoApp.Helper.CustomTag
{
    public class EmailTagHelper : TagHelper
    {
        public string Address { get; set; }
        public string Value { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", $"mailto:{Address}");
            output.Content.SetContent(Value);
        }
    }
}
