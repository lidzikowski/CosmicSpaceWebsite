#pragma checksum "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ded464733c61d231d43ede329d73745f8691a843"
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
    public class QuestTypeModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
 if (Questtypes == null || Maps == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<div class=\"d-flex justify-content-center\">\r\n        <div class=\"spinner-border\" role=\"status\">\r\n            <span class=\"sr-only\">Loading...</span>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "overflow-auto");
            __builder.AddAttribute(5, "style", "max-height: 200px;");
            __builder.AddMarkupContent(6, "\r\n\r\n        ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-striped");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<thead>\r\n                <tr>\r\n                    <th scope=\"col\"></th>\r\n                    <th scope=\"col\">Cel zadania</th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n\r\n");
#nullable restore
#line 28 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                 foreach (Questtypes questtypes in Questtypes)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                    ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "td");
            __builder.AddMarkupContent(17, "\r\n                            ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "radio");
            __builder.AddAttribute(20, "name", "questtype");
            __builder.AddAttribute(21, "checked", 
#nullable restore
#line 34 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                                              QuestType?.Questtypeid == questtypes.Questtypeid

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                                                () => QuestType = questtypes

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.AddContent(27, 
#nullable restore
#line 39 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                             questtypes.Questtypename

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 42 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.AddContent(35, "    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "container");
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "row");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-sm");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.AddMarkupContent(45, "<label class=\"text-dark\">Mapy (Baza danych):</label>\r\n                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "overflow-auto");
            __builder.AddAttribute(48, "style", "max-height: 300px;");
            __builder.AddMarkupContent(49, "\r\n\r\n                    ");
            __builder.OpenElement(50, "table");
            __builder.AddAttribute(51, "class", "table table-striped");
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.AddMarkupContent(53, "<thead>\r\n                            <tr>\r\n                                <th scope=\"col\">Nazwa</th>\r\n                                <th scope=\"col\"></th>\r\n                            </tr>\r\n                        </thead>\r\n                        ");
            __builder.OpenElement(54, "tbody");
            __builder.AddMarkupContent(55, "\r\n\r\n");
#nullable restore
#line 64 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                             foreach (Maps map in Maps)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                                ");
            __builder.OpenElement(57, "tr");
            __builder.AddMarkupContent(58, "\r\n                                    ");
            __builder.OpenElement(59, "th");
            __builder.AddAttribute(60, "scope", "row");
            __builder.AddMarkupContent(61, "\r\n                                        ");
            __builder.OpenElement(62, "p");
            __builder.AddContent(63, "[");
            __builder.AddContent(64, 
#nullable restore
#line 68 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                                             map.Mapid

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(65, "] ");
            __builder.AddContent(66, 
#nullable restore
#line 68 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                                                         map.Mapname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n                                    ");
            __builder.OpenElement(69, "td");
            __builder.AddMarkupContent(70, "\r\n                                        ");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "class", "btn btn-warning");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                                                                                    e =>
                                        {
                                            SelectedMaps.Add(map);
                                            Maps.Remove(map);
                                        }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(74, "\r\n                                            Wybierz\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 81 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\r\n            ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "col-sm");
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.AddMarkupContent(86, "<label class=\"text-dark\">Lista wybranych map:</label>\r\n                ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "overflow-auto");
            __builder.AddAttribute(89, "style", "max-height: 300px;");
            __builder.AddMarkupContent(90, "\r\n\r\n                    ");
            __builder.OpenElement(91, "table");
            __builder.AddAttribute(92, "class", "table table-striped");
            __builder.AddMarkupContent(93, "\r\n                        ");
            __builder.AddMarkupContent(94, "<thead>\r\n                            <tr>\r\n                                <th scope=\"col\">Nazwa</th>\r\n                                <th scope=\"col\"></th>\r\n                            </tr>\r\n                        </thead>\r\n                        ");
            __builder.OpenElement(95, "tbody");
            __builder.AddMarkupContent(96, "\r\n\r\n");
#nullable restore
#line 102 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                             foreach (Maps map in SelectedMaps)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "                                ");
            __builder.OpenElement(98, "tr");
            __builder.AddMarkupContent(99, "\r\n                                    ");
            __builder.OpenElement(100, "th");
            __builder.AddAttribute(101, "scope", "row");
            __builder.AddMarkupContent(102, "\r\n                                        ");
            __builder.OpenElement(103, "p");
            __builder.AddContent(104, "[");
            __builder.AddContent(105, 
#nullable restore
#line 106 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                                             map.Mapid

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(106, "] ");
            __builder.AddContent(107, 
#nullable restore
#line 106 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                                                         map.Mapname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n\r\n                                    ");
            __builder.OpenElement(110, "td");
            __builder.AddMarkupContent(111, "\r\n                                        ");
            __builder.OpenElement(112, "button");
            __builder.AddAttribute(113, "class", "btn btn-danger");
            __builder.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                                                                                   e =>
                                        {
                                            Maps.Add(map);
                                            Maps = Maps.OrderBy(o => o.Mapid).ToList();
                                            SelectedMaps.Remove(map);
                                        }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(115, "\r\n                                            Usuń\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
#nullable restore
#line 120 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(119, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n");
            __builder.AddContent(126, "    ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "container");
            __builder.AddMarkupContent(129, "\r\n        ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "row");
            __builder.AddMarkupContent(132, "\r\n            ");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "col-sm");
            __builder.AddMarkupContent(135, "\r\n                ");
            __builder.AddMarkupContent(136, "<label class=\"text-dark\">Cel (Id z bazy):</label>\r\n                ");
            __builder.OpenElement(137, "input");
            __builder.AddAttribute(138, "type", "number");
            __builder.AddAttribute(139, "class", "text-dark");
            __builder.AddAttribute(140, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 135 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                                     TargetId

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(141, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TargetId = __value, TargetId, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n\r\n            ");
            __builder.OpenElement(144, "div");
            __builder.AddAttribute(145, "class", "col-sm");
            __builder.AddMarkupContent(146, "\r\n                ");
            __builder.AddMarkupContent(147, "<label class=\"text-dark\">Ilość:</label>\r\n                ");
            __builder.OpenElement(148, "input");
            __builder.AddAttribute(149, "type", "number");
            __builder.AddAttribute(150, "class", "text-dark");
            __builder.AddAttribute(151, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 141 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                                     Quantity

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(152, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Quantity = __value, Quantity, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n");
            __builder.AddContent(157, "    ");
            __builder.OpenElement(158, "button");
            __builder.AddAttribute(159, "class", "btn btn-light float-right my-3");
            __builder.AddAttribute(160, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 146 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
                                                             Dodaj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(161, "\r\n        Dodaj\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n");
#nullable restore
#line 149 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 151 "C:\Users\Lukasz\Documents\GitHub\CosmicSpaceWebsite\CosmicSpaceWebsite\Pages\QuestTypeModal.razor"
       
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
