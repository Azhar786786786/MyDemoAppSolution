using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MyDemoApp.Helper.CustomTag
{
    public class ImageTagHelper : TagHelper
    {
        public string Src { get; set; }
        public string Alt { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";
            output.Attributes.SetAttribute("src", $"{Src}");
            output.Attributes.SetAttribute("alt", $"{Alt}");
            output.Attributes.SetAttribute("width", $"{Width}");
            output.Attributes.SetAttribute("height", $"{Height}");
        }
    }
}
