using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace WebApplication2.TagHelpers
{
    public class ExampleTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetContent("Przykladowy tag helper");
        }
    }
}
