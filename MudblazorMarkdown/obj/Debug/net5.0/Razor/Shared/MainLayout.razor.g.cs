#pragma checksum "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81330ff7465d9b65d3033765bc8339a0781f58db"
// <auto-generated/>
#pragma warning disable 1591
namespace MudblazorMarkdownTest.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(8);
                __builder2.AddAttribute(9, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor"
                          0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(11);
                    __builder3.AddAttribute(12, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 9 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor"
                                                                                      Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor"
                                                                                                             (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudSpacer>(17);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(19);
                    __builder3.AddAttribute(20, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor"
                              Icons.Custom.Brands.MudBlazor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor"
                                                                    Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Link", "https://mudblazor.com/");
                    __builder3.AddAttribute(23, "Target", "_blank");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(25);
                    __builder3.AddAttribute(26, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor"
                              Icons.Custom.Brands.GitHub

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "Link", "https://github.com/Garderoben/MudBlazor");
                    __builder3.AddAttribute(29, "Target", "_blank");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(31);
                __builder2.AddAttribute(32, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor"
                                                   1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor"
                           _drawerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudDrawerHeader>(36);
                    __builder3.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(38);
                        __builder4.AddAttribute(39, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 16 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(41, "MudblazorMarkdownTest");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\n        ");
                    __builder3.OpenComponent<MudblazorMarkdownTest.Shared.NavMenu>(43);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(45);
                __builder2.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudContainer>(47);
                    __builder3.AddAttribute(48, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 21 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor"
                                MaxWidth.Large

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "Class", "my-16 pt-16");
                    __builder3.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(51, 
#nullable restore
#line 22 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Dev\Aeonic\AeonicTech\Questions\BlazorMarkdown\MudblazorMarkdown\Shared\MainLayout.razor"
       
    bool _drawerOpen = true;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
