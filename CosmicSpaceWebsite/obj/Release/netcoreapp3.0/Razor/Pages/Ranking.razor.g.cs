#pragma checksum "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\Ranking.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a42ccfaab328ec179fbff652ad48ad492e877735"
// <auto-generated/>
#pragma warning disable 1591
namespace CosmicSpaceWebsite.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ranking")]
    public class Ranking : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Ranking</h1>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\Ranking.razor"
 if (Pilots == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<div class=\"d-flex justify-content-center\">\r\n        <div class=\"spinner-border\" role=\"status\">\r\n            <span class=\"sr-only\">Loading...</span>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\Ranking.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-hover table-dark");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, @"<thead>
                <tr>
                    <th scope=""col"">Nickname</th>
                    <th scope=""col"">Statek</th>
                    <th scope=""col"">Level</th>
                    <th scope=""col"">Doświadczenie</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(10, "tbody");
            __builder.AddMarkupContent(11, "\r\n\r\n");
#nullable restore
#line 36 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\Ranking.razor"
                 foreach (Pilots pilot in Pilots)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                    ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 39 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\Ranking.razor"
                             pilot.Nickname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 40 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\Ranking.razor"
                             pilot.Ship.Shipname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 41 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\Ranking.razor"
                             pilot.Level

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 42 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\Ranking.razor"
                             pilot.Experience

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "data-toggle", "modal");
            __builder.AddAttribute(31, "data-target", "#exampleModalCenter");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\Ranking.razor"
                                                                                                      e =>
     {
         var parameters = new ModalParameters();
         parameters.Add(nameof(Pilots), pilot);
         Modal.Show<AchievementModal>("Osiągnięcia gracza", parameters);
     }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "\r\n                                Osiągnięcia\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 54 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\Ranking.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 59 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\Ranking.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\Ranking.razor"
       
    private IEnumerable<Pilots> Pilots;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Pilots = await sessionStorage.GetItemAsync<IEnumerable<Pilots>>("allPilots");

            if (Pilots == null)
            {
                Pilots = await Utils.HttpGetAsync<IEnumerable<Pilots>>(Http, ApiTypeService.game, ApiService.GetPilots);
                Pilots = Pilots.OrderByDescending(o => o.Experience);
                await sessionStorage.SetItemAsync("allPilots", Pilots);
            }
        }
        catch { }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
