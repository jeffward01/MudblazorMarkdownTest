// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MudblazorMarkdownTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\_Imports.razor"
using MudblazorMarkdownTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\_Imports.razor"
using MudblazorMarkdownTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Pages\FetchData.razor"
using MudblazorMarkdownTest.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
