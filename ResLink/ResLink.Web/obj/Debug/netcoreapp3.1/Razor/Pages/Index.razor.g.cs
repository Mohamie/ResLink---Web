#pragma checksum "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8226febb6a369cb06beaf8f53074c8c3a79588a8"
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
#nullable restore
#line 8 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor"
 if (Announcements != null && Events != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-6 col-xl-3 mb-4");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card shadow border-left-primary py-2");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row align-items-center no-gutters");
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col mr-2");
            __builder.AddMarkupContent(18, "\r\n                            ");
            __builder.AddMarkupContent(19, "<div class=\"text-uppercase text-primary font-weight-bold text-xs mb-1\"><span>Announcements</span></div>\r\n                            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "text-dark font-weight-bold h5 mb-0");
            __builder.OpenElement(22, "span");
            __builder.AddContent(23, 
#nullable restore
#line 17 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor"
                                                                                   announcementsCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.AddMarkupContent(26, "<div class=\"col-auto\"><span class=\"oi oi-bell\" aria-hidden=\"true\"></span></div>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-md-6 col-xl-3 mb-4");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "card shadow border-left-success py-2");
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "card-body");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row align-items-center no-gutters");
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col mr-2");
            __builder.AddMarkupContent(45, "\r\n                            ");
            __builder.AddMarkupContent(46, "<div class=\"text-uppercase text-success font-weight-bold text-xs mb-1\"><span>Events </span></div>\r\n                            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "text-dark font-weight-bold h5 mb-0");
            __builder.OpenElement(49, "span");
            __builder.AddContent(50, 
#nullable restore
#line 30 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor"
                                                                                   eventsCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.AddMarkupContent(53, "<div class=\"col-auto\"><span class=\"oi oi-calendar\" aria-hidden=\"true\"></span></div>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "col-md-6 col-xl-3 mb-4");
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "card shadow border-left-success py-2");
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "card-body");
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "row align-items-center no-gutters");
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col mr-2");
            __builder.AddMarkupContent(72, "\r\n                            ");
            __builder.AddMarkupContent(73, "<div class=\"text-uppercase text-success font-weight-bold text-xs mb-1\"><span>Complaints</span></div>\r\n                            ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "text-dark font-weight-bold h5 mb-0");
            __builder.OpenElement(76, "span");
            __builder.AddContent(77, 
#nullable restore
#line 43 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor"
                                                                                   complaintCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.AddMarkupContent(80, "<div class=\"col-auto\"><span class=\"oi oi-audio-spectrum\" aria-hidden=\"true\"></span></div>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
            __builder.AddContent(86, "    ");
            __builder.OpenComponent<ResLink.Web.Pages.Announments.AnnouncementsList>(87);
            __builder.AddAttribute(88, "AnnouncementList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ResLink.BL.Models.Announcement>>(
#nullable restore
#line 52 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor"
                                         Announcements

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "IsDisplayOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor"
                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(90, "\r\n    ");
            __builder.OpenComponent<ResLink.Web.Pages.Events.EventsList>(91);
            __builder.AddAttribute(92, "Events", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ResLink.BL.Models.Event>>(
#nullable restore
#line 53 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor"
                        Events

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(93, "\r\n");
#nullable restore
#line 54 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(94, "    ");
            __builder.AddMarkupContent(95, "<div>Loading data please wait....</div>\r\n");
#nullable restore
#line 59 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Index.razor"
      

    int announcementsCount;
    int eventsCount;
    int complaintCount;

    public ResidenceManager Manager { get; set; }

    public HouseCommittee LoggedUser { get; set; }

    public List<Announcement> Announcements { get; set; }
    public List<Event> Events { get; set; }
    public List<Complaint> Complaints { get; set; }

    protected override async Task OnInitializedAsync()
    {

        var account = await UserAccountRepository.GetCurrentlyLoggedAccount();
        var userRole = (UserRole)account.GetProperty("userRole");


        if (userRole.RoleId == 0)//if Manager
        {
            Manager = await UserAccountRepository.GetLoggedManager();

            navManager.NavigateTo("/manager/register");

            return;
        }

        if (userRole.RoleId == 1)//if admin
        {
            LoggedUser = await UserAccountRepository.GetLoggedHouseCommittee();

            Announcements = (await AnnouncementRepository.GetAnnouncements() as List<Announcement>).ToList();
            Events = (await EventRepository.GetEvents() as List<Event>).ToList();
            Complaints = (await ComplaintRepository.getComplaints() as List<Complaint>).ToList();

            announcementsCount = Announcements.Count;
            eventsCount = Events.Count;
            complaintCount = Complaints.Count;
        }


    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BackendlessService backendlessService { get; set; }
    }
}
#pragma warning restore 1591
