using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MyDemoApp.Helper.CustomTag
{
    public class FileTagHelper : TagHelper
    {
        public string Name { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "input";
            output.Attributes.SetAttribute("type", "file");
            output.Attributes.SetAttribute("name", $"{Name}");
        }
    }
}
