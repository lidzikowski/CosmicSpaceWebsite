#pragma checksum "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceGame\CosmicSpaceWebsite\CosmicSpaceWebsite\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abefecc3087931e2393bd5e0554e429df6855ee3"
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
#line 1 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceGame\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceGame\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceGame\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceGame\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceGame\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceGame\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceGame\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceGame\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using CosmicSpaceWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceGame\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using CosmicSpaceWebsite.Shared;

#line default
#line hidden
#nullable disable
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "nav flex-column");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "li");
            __builder.AddAttribute(4, "class", "nav-item px-2");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(6);
            __builder.AddAttribute(7, "class", "nav-link");
            __builder.AddAttribute(8, "href", "");
            __builder.AddAttribute(9, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 4 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceGame\CosmicSpaceWebsite\CosmicSpaceWebsite\Shared\NavMenu.razor"
                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "class", "nav-item px-2");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(17);
            __builder.AddAttribute(18, "class", "nav-link");
            __builder.AddAttribute(19, "href", "ranking");
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(21, "\r\n            <span class=\"oi oi-bar-chart\" aria-hidden=\"true\"></span> Ranking\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591