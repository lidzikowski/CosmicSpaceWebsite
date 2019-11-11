#pragma checksum "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa773526f84e93334a64a7111dcc29495bcac8db"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public class QuestTypeModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 153 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
       
    [CascadingParameter]
    ModalParameters Parameters { get; set; }

    private IEnumerable<Questtypes> Questtypes;
    private List<Maps> Maps;

    public Questtypes QuestType;
    public string TargetId;
    public string Quantity;
    private List<Maps> SelectedMaps = new List<Maps>();

    protected override async Task OnInitializedAsync()
    {
        Questtypes = await Utils.HttpGetAsync<IEnumerable<Questtypes>>(Http, ApiTypeService.game, ApiService.GetQuestTypes);
        Maps = await Utils.HttpGetAsync<List<Maps>>(Http, ApiTypeService.game, ApiService.GetMaps);
    }

    private async Task Dodaj()
    {
        long.TryParse(TargetId, out long targetId);

        QuestTypes[] targetRequired = new QuestTypes[]
        {
            QuestTypes.ZabijNPC,
            QuestTypes.ZabijGracz,
            QuestTypes.ZbierzSurowiec,
            QuestTypes.PrzejdzNaMape
        };

        if (QuestType != null && long.TryParse(Quantity, out long quantity))
        {
            if (targetRequired.Any(o => (byte)o == QuestType.Questtypeid) && targetId < 1)
            {
                toastService.ShowError("Target jest wymagany do tego typu zadania.");
                return;
            }

            if (await Utils.HttpGetAsync<bool>(Http, ApiTypeService.game, ApiService.AddQuestTypes, new Dictionary<string, object>()
        {
            { "questTypeId", QuestType.Questtypeid },
            { "targetId", targetId > 0 ? targetId :(long?)null },
            { "quantity", quantity },
            { "selectedMaps", DllUtils.SerializeObject(SelectedMaps) },
        }))
            {
                toastService.ShowSuccess("Dodano zadanie.");
                ModalService.Close(ModalResult.Ok(new object()));
            }
            else
            {
                toastService.ShowError("Błąd api.");
            }
        }
        else
        {
            toastService.ShowError("Błąd podczas walidacji.");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService ModalService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
