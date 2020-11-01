using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AssessmentEngine.Web.TagHelpers
{
    [HtmlTargetElement("Sort-Icon")]
    public class SortIconTagHelper : TagHelper
    {
        public string Key { get; set; }
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.Content.SetHtmlContent(@"<span v-if=""sortOrders['" + Key + @"'] > 0"">
    <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-caret-up-fill"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
      <path d=""M7.247 4.86l-4.796 5.481c-.566.647-.106 1.659.753 1.659h9.592a1 1 0 0 0 .753-1.659l-4.796-5.48a1 1 0 0 0-1.506 0z""/>
    </svg>
</span>
<span v-if=""sortOrders['" + Key + @"'] < 0"">
    <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-caret-down-fill"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
      <path d=""M7.247 11.14L2.451 5.658C1.885 5.013 2.345 4 3.204 4h9.592a1 1 0 0 1 .753 1.659l-4.796 5.48a1 1 0 0 1-1.506 0z""/>
    </svg>
</span>");
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}