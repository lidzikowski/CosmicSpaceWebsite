#pragma checksum "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79556c3c8056c83ee198d3479ccb813225c6b75d"
// <auto-generated/>
#pragma warning disable 1591
namespace CosmicSpaceWebsite.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using CosmicSpaceWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using CosmicSpaceWebsiteDll;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using CosmicSpaceWebsite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(0);
            __builder.AddAttribute(1, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 3 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Shared\MainLayout.razor"
                          ToastPosition.BottomRight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Shared\MainLayout.razor"
                         3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "SuccessClass", "success-toast-override");
            __builder.AddAttribute(4, "SuccessIconClass", "fa fa-thumbs-up");
            __builder.AddAttribute(5, "ErrorIconClass", "fa fa-bug");
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<Blazored.Modal.BlazoredModal>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "d-flex justify-content-center");
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", true);
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
            __builder.AddAttribute(16, "class", "nav-link");
            __builder.AddAttribute(17, "href", "");
            __builder.AddAttribute(18, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 14 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Shared\MainLayout.razor"
                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n            <img src=\"resources/Logo.png\" class=\"img-fluid\" alt=\"Cosmic Space\">\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "d-flex justify-content-center");
            __builder.AddMarkupContent(26, "\r\n\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "w-25");
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "list-group-flush p-2 m-2 menu-custom");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenComponent<CosmicSpaceWebsite.Shared.NavMenu>(33);
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenComponent<CosmicSpaceWebsite.Shared.UserMenu>(35);
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "w-75");
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "mr-3");
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.AddContent(45, 
#nullable restore
#line 32 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
