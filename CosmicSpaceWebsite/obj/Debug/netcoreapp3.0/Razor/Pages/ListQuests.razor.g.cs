#pragma checksum "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6738e1fa84dd9679177cba5477d07bd8abca209"
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
#line 11 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listquests")]
    public class ListQuests : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Quests</h1>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
 if (Tasks == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<div class=\"d-flex justify-content-center\">\r\n        <div class=\"spinner-border\" role=\"status\">\r\n            <span class=\"sr-only\">Loading...</span>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "p");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-secondary");
            __builder.AddAttribute(10, "data-toggle", "modal");
            __builder.AddAttribute(11, "data-target", "#exampleModalCenter");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                                                                                                e =>
        {
            var parameters = new ModalParameters();
            //parameters.Add(nameof(Pilots), Pilot);
            Modal.Show<RewardModal>("Nowa nagroda", parameters);
        }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n                Dodaj nową nagrodę\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n        ");
            __builder.OpenElement(16, "p");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-secondary");
            __builder.AddAttribute(20, "data-toggle", "modal");
            __builder.AddAttribute(21, "data-target", "#exampleModalCenter");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                                                                                                e =>
        {
            var parameters = new ModalParameters();
            //parameters.Add(nameof(Pilots), Pilot);
            Modal.Show<QuestTypeModal>("Nowy rodzaj zadania", parameters);
        }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "\r\n                Dodaj nowy rodzaj zadania\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        \r\n        ");
            __builder.OpenElement(26, "p");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-secondary");
            __builder.AddAttribute(30, "data-toggle", "modal");
            __builder.AddAttribute(31, "data-target", "#exampleModalCenter");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                                                                                                e =>
        {
            var parameters = new ModalParameters();
            //parameters.Add(nameof(Pilots), Pilot);
            Modal.Show<QuestModal>("Nowe zadanie", parameters);
        }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "\r\n                Dodaj nowe zadanie\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.AddContent(37, "    ");
            __builder.OpenElement(38, "div");
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "table");
            __builder.AddAttribute(41, "class", "table table-hover table-dark");
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.AddMarkupContent(43, @"<thead>
                <tr>
                    <th scope=""col"">ID</th>
                    <th scope=""col"">Nazwa</th>
                    <th scope=""col"">Level</th>
                    <th scope=""col"">Nagroda</th>
                    <th scope=""col"">Cel zadania</th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(44, "tbody");
            __builder.AddMarkupContent(45, "\r\n\r\n");
#nullable restore
#line 71 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                 foreach (Tasks task in Tasks)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "                    ");
            __builder.OpenElement(47, "tr");
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 74 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                             task.Taskid

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 75 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                             task.Taskname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 76 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                             task.Level

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.OpenElement(58, "td");
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 78 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                             if (task.Reward.Experience != default)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                                ");
            __builder.OpenElement(61, "p");
            __builder.AddMarkupContent(62, "Doświadczenie ");
            __builder.AddContent(63, 
#nullable restore
#line 80 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                                  task.Reward.Experience

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 81 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                             if (task.Reward.Metal != default)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "                                ");
            __builder.OpenElement(66, "p");
            __builder.AddContent(67, "Metal ");
            __builder.AddContent(68, 
#nullable restore
#line 84 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                          task.Reward.Metal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 85 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                             if (task.Reward.Scrap != default)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                                ");
            __builder.OpenElement(71, "p");
            __builder.AddContent(72, "Scrap ");
            __builder.AddContent(73, 
#nullable restore
#line 88 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                          task.Reward.Scrap

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 89 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                             if (task.Reward.Ammunitionid != default)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "                                ");
            __builder.OpenElement(76, "p");
            __builder.AddContent(77, "Amunicja [");
            __builder.AddContent(78, 
#nullable restore
#line 92 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                              task.Reward.Ammunitionid

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(79, "]                     ");
            __builder.AddContent(80, 
#nullable restore
#line 92 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                                                                             task.Reward.AmmunitionQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 93 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                             if (task.Reward.Itemreward != default)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                 foreach (Itemreward itemreward in task.Reward.Itemreward)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "                                    ");
            __builder.OpenElement(83, "p");
            __builder.AddContent(84, "Przedmiot: ");
            __builder.AddContent(85, 
#nullable restore
#line 98 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                                   itemreward.Item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(86, " (");
            __builder.AddContent(87, 
#nullable restore
#line 98 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                                                          itemreward.Upgradelevel

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(88, " lvl)  [Szansa: ");
            __builder.AddContent(89, 
#nullable restore
#line 98 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                                                                                                   itemreward.Chance / 10

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(90, " %]");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 99 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                        ");
            __builder.OpenElement(94, "td");
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 103 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                             foreach (Taskquest taskquest in task.Taskquest)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "                                ");
            __builder.OpenElement(97, "p");
            __builder.AddContent(98, 
#nullable restore
#line 105 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                    taskquest.Questid

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(99, " => ");
            __builder.AddContent(100, 
#nullable restore
#line 105 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                                          taskquest.Quest.Questtype.Questtypename

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
#nullable restore
#line 107 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                 if (taskquest.Quest.Targetid != default)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "                                    ");
            __builder.OpenElement(103, "p");
            __builder.AddContent(104, "Cel: ");
            __builder.AddContent(105, 
#nullable restore
#line 109 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                             taskquest.Quest.Targetid

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
#nullable restore
#line 110 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "                                ");
            __builder.OpenElement(108, "p");
            __builder.AddMarkupContent(109, "Ilość: ");
            __builder.AddContent(110, 
#nullable restore
#line 112 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                           taskquest.Quest.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n");
#nullable restore
#line 114 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                 if (taskquest.Quest.Questmap != default)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                     foreach (Questmap questmap in taskquest.Quest.Questmap)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(112, "                                        ");
            __builder.OpenElement(113, "p");
            __builder.AddContent(114, "Na mapie: ");
            __builder.AddContent(115, 
#nullable restore
#line 118 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                                      questmap.Map.Mapname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n");
#nullable restore
#line 119 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                     
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(117, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n");
#nullable restore
#line 124 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(120, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n");
#nullable restore
#line 129 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\ListQuests.razor"
       
    private IEnumerable<Tasks> Tasks;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Tasks = await sessionStorage.GetItemAsync<IEnumerable<Tasks>>("allTasks");

            if (Tasks == null)
            {
                Tasks = await Utils.HttpGetAsync<IEnumerable<Tasks>>(Http, ApiTypeService.game, ApiService.GetTasks);
                Tasks = Tasks.OrderBy(o => o.Taskid).ThenBy(o => o.Level);
                await sessionStorage.SetItemAsync("allTasks", Tasks);
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
