using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyDemoApp.Helper.CustomTag
{
    public static class CustomControl
    {
        //public static IHtmlContent Button(this IHtmlHelper html, string type, string value, string attribute)
        //{
        //    return new HtmlString($"<input type='{type}' value='{value}' class='{attribute}'/>");
        //}
        public static IHtmlContent Image(this IHtmlHelper html, string src, string width, string height, string attribute)
        {
            return new HtmlString($"<img src='{src}' width='{width}' height='{height}' class='{attribute}'/>");
        }
    }
}
