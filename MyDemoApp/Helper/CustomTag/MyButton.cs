using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyDemoApp.Helper.CustomTag
{
    public static class MyButton
    {
        public static string Render(string text, string color)
        {
            return $"<button style='background-color:{color};'>{text}</button>";
        }
        public static IHtmlContent Button(this IHtmlHelper html, string type, string value)
        {
            return new HtmlString($"<input type='{type}' value='{value}'/>");
        }
        public static IHtmlContent Button(this IHtmlHelper html, string type, string value, string attribute)
        {
            return new HtmlString($"<input type='{type}' value='{value}' class='{attribute}'/>");
        }
        public static IHtmlContent Button(this IHtmlHelper html, string type, string value, string attribute, string _id)
        {
            return new HtmlString($"<input type='{type}' value='{value}' class='{attribute}' id='{_id}'/>");
        }
    }
}
