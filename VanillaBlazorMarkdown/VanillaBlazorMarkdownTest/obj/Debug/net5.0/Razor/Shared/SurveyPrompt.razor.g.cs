#pragma checksum "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\VanillaBlazorMarkdown\VanillaBlazorMarkdownTest\Shared\SurveyPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fdf5426d59ca5237991185820025af56e969c92"
// <auto-generated/>
#pragma warning disable 1591
namespace VanillaBlazorMarkdownTest.Shared
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
    public partial class SurveyPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            __builder.AddMarkupContent(2, "<span class=\"oi oi-pencil me-2\" aria-hidden=\"true\"></span>\r\n    ");
            __builder.OpenElement(3, "strong");
            __builder.AddContent(4, 
#nullable restore
#line 3 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\VanillaBlazorMarkdown\VanillaBlazorMarkdownTest\Shared\SurveyPrompt.razor"
             Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n    ");
            __builder.AddMarkupContent(6, "<span class=\"text-nowrap\">\r\n        Please take our\r\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2149017\">brief survey</a></span>\r\n    and tell us what you think.\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\VanillaBlazorMarkdown\VanillaBlazorMarkdownTest\Shared\SurveyPrompt.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string? Title { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
