#pragma checksum "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7329f1b12e02b79a55c4b90fbfff0e65fc851f26"
// <auto-generated/>
#pragma warning disable 1591
namespace ResLink.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.BL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.DAL.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web.Pages.Announments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web.Pages.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web.Pages.RegisterStudents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web.Pages.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.DL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using BackendlessAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-6 col-xl-3 mb-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card shadow border-left-primary py-2");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row align-items-center no-gutters");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col mr-2");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.AddMarkupContent(18, "<div class=\"text-uppercase text-primary font-weight-bold text-xs mb-1\"><span>Announcements</span></div>\r\n                        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "text-dark font-weight-bold h5 mb-0");
            __builder.OpenElement(21, "span");
            __builder.AddContent(22, 
#nullable restore
#line 10 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor"
                                                                               announcementsCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.AddMarkupContent(25, "<div class=\"col-auto\"><span class=\"oi oi-bell\" aria-hidden=\"true\"></span></div>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-md-6 col-xl-3 mb-4");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "card shadow border-left-success py-2");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "card-body");
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "row align-items-center no-gutters");
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col mr-2");
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.AddMarkupContent(45, "<div class=\"text-uppercase text-success font-weight-bold text-xs mb-1\"><span>Events </span></div>\r\n                        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "text-dark font-weight-bold h5 mb-0");
            __builder.OpenElement(48, "span");
            __builder.AddContent(49, 
#nullable restore
#line 23 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor"
                                                                               eventsCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.AddMarkupContent(52, "<div class=\"col-auto\"><span class=\"oi oi-calendar\" aria-hidden=\"true\"></span></div>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.AddMarkupContent(57, @"<div class=""col-md-6 col-xl-3 mb-4"">
        <div class=""card shadow border-left-info py-2"">
            <div class=""card-body"">
                <div class=""row align-items-center no-gutters"">
                    <div class=""col mr-2"">
                        <div class=""text-uppercase text-info font-weight-bold text-xs mb-1""><span>Registered Student</span></div>
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col-auto"">
                                <div class=""text-dark font-weight-bold h5 mb-0 mr-3""><span>0</span></div>
                            </div>
                     
                        </div>
                    </div>
                    <div class=""col-auto""><span class=""oi oi-people"" aria-hidden=""true""></span></div>
                </div>
            </div>
        </div>
    </div>
    ");
            __builder.AddMarkupContent(58, @"<div class=""col-md-6 col-xl-3 mb-4"">
        <div class=""card shadow border-left-warning py-2"">
            <div class=""card-body"">
                <div class=""row align-items-center no-gutters"">
                    <div class=""col mr-2"">
                        <div class=""text-uppercase text-warning font-weight-bold text-xs mb-1""><span>Registred Admins</span></div>
                        <div class=""text-dark font-weight-bold h5 mb-0""><span>0</span></div>
                    </div>
                    <div class=""col-auto""><i class=""fas fa-comments fa-2x text-gray-300""></i></div>
                </div>
            </div>
        </div>
    </div>
");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<ResLink.Web.Pages.Announments.AnnouncementsList>(60);
            __builder.AddAttribute(61, "IsDisplayOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 65 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor"
                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(62, "\r\n\r\n");
            __builder.OpenComponent<ResLink.Web.Pages.Events.EventsList>(63);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor"
       

    int announcementsCount;
    int eventsCount;
    int complaintsCount;

    protected override async Task OnInitializedAsync()
    {
        announcementsCount = (await AnnouncementRepository.GetAnnouncements() as List<Announcement>).Count;
        eventsCount = (await EventRepository.GetEvents() as List<Event>).Count;
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
