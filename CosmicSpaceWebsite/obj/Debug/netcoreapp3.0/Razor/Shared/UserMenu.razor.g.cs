#pragma checksum "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Shared\UserMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7141d36d6e5c31b06be27891ad6e5871c37cbb7a"
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
    public class UserMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Shared\UserMenu.razor"
 if (User == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "list-group-item list-group-item-dark list-group-item-action");
            __builder.AddAttribute(3, "href", "login");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        <span class=\"oi oi-person\" aria-hidden=\"true\"></span> Logowanie\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.AddContent(7, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(8);
            __builder.AddAttribute(9, "class", "list-group-item list-group-item-dark list-group-item-action");
            __builder.AddAttribute(10, "href", "register");
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n        <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span> Rejestracja\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 15 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Shared\UserMenu.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
            __builder.AddAttribute(16, "class", "list-group-item list-group-item-dark list-group-item-action");
            __builder.AddAttribute(17, "href", "userpanel");
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n        <span class=\"oi oi-person\" aria-hidden=\"true\"></span> Panel użytkownika\r\n        ");
                __builder2.OpenElement(20, "span");
                __builder2.AddAttribute(21, "class", "badge badge-primary badge-pill");
                __builder2.AddAttribute(22, "style", "float:right;");
                __builder2.AddContent(23, 
#nullable restore
#line 20 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Shared\UserMenu.razor"
                                                                           User.Pilots.Nickname

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.AddContent(26, "    ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "class", "list-group-item list-group-item-dark list-group-item-action");
            __builder.AddAttribute(29, "href", "");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Shared\UserMenu.razor"
                                                                                             OnLogout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "\r\n        <span class=\"oi oi-account-logout\" aria-hidden=\"true\"></span> Wyloguj\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 26 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Shared\UserMenu.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Shared\UserMenu.razor"
       
    private Users User;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            User = await sessionStorage.GetItemAsync<Users>("user");
        }
        catch { }
    }

    private async Task OnLogout()
    {
        await sessionStorage.SetItemAsync("user", null);
        User = null;
        navigationManager.NavigateTo("/", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
