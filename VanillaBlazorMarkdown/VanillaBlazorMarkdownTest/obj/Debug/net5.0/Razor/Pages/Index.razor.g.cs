#pragma checksum "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\VanillaBlazorMarkdown\VanillaBlazorMarkdownTest\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c513ca0ba03fcd9f9514cc4d118092515d7f2e8f"
// <auto-generated/>
#pragma warning disable 1591
namespace VanillaBlazorMarkdownTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\VanillaBlazorMarkdown\VanillaBlazorMarkdownTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\VanillaBlazorMarkdown\VanillaBlazorMarkdownTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\VanillaBlazorMarkdown\VanillaBlazorMarkdownTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\VanillaBlazorMarkdown\VanillaBlazorMarkdownTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\VanillaBlazorMarkdown\VanillaBlazorMarkdownTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\VanillaBlazorMarkdown\VanillaBlazorMarkdownTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\VanillaBlazorMarkdown\VanillaBlazorMarkdownTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\VanillaBlazorMarkdown\VanillaBlazorMarkdownTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\VanillaBlazorMarkdown\VanillaBlazorMarkdownTest\_Imports.razor"
using VanillaBlazorMarkdownTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\VanillaBlazorMarkdown\VanillaBlazorMarkdownTest\_Imports.razor"
using VanillaBlazorMarkdownTest.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "PageTitle");
            __builder.AddContent(1, "Index");
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.AddMarkupContent(3, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<VanillaBlazorMarkdownTest.Shared.SurveyPrompt>(4);
            __builder.AddAttribute(5, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
