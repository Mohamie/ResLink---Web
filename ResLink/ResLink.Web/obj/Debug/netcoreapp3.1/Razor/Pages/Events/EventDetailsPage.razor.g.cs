#pragma checksum "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EventDetailsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bcc5d9ef13b9bb11494b3cf124dbfed7211be1e"
// <auto-generated/>
#pragma warning disable 1591
namespace ResLink.Web.Pages.Events
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
    public partial class EventDetailsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-striped table-bordered table-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "tr");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddMarkupContent(5, "<th>HC Name</th>\r\n        ");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 4 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EventDetailsPage.razor"
             Event.Coordinator.Student.FullNames

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(8, " ");
            __builder.AddContent(9, 
#nullable restore
#line 4 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EventDetailsPage.razor"
                                                  Event.Coordinator.Student.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.AddMarkupContent(14, "<th>HC Role</th>\r\n        ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 9 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EventDetailsPage.razor"
             Event.Coordinator.HcRole.HcRoleName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n\r\n    ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.AddMarkupContent(21, "<th>HC\'s Room No</th>\r\n        ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 15 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EventDetailsPage.razor"
             Event.Coordinator.Student.RoomNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(24, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n    ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.AddMarkupContent(29, "<th>HC\'s PhoneNumber</th>\r\n        ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 20 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EventDetailsPage.razor"
             Event.Coordinator.Student.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n    ");
            __builder.AddMarkupContent(35, "<tr>\r\n        <th>Event Category</th>\r\n        <td class=\"text-danger\">Not Yet Implemented</td>\r\n    </tr>\r\n\r\n    ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.AddMarkupContent(38, "<th>Date Created</th>\r\n        ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 30 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EventDetailsPage.razor"
             Event.DateCreated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n\r\n    ");
            __builder.OpenElement(43, "tr");
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.AddMarkupContent(45, "<th>Event Title</th>\r\n        ");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "class", "text-success");
            __builder.AddContent(48, 
#nullable restore
#line 36 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EventDetailsPage.razor"
                                  Event.EventTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    \r\n    ");
            __builder.OpenElement(51, "tr");
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.AddMarkupContent(53, "<th>Event Start Date</th>\r\n        ");
            __builder.OpenElement(54, "td");
            __builder.AddAttribute(55, "class", "text-warning");
            __builder.AddContent(56, 
#nullable restore
#line 41 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EventDetailsPage.razor"
                                  Event.EventStartTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    \r\n    ");
            __builder.OpenElement(59, "tr");
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.AddMarkupContent(61, "<th>Event End Date</th>\r\n        ");
            __builder.OpenElement(62, "td");
            __builder.AddAttribute(63, "class", "text-warning");
            __builder.AddContent(64, 
#nullable restore
#line 46 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EventDetailsPage.razor"
                                  Event.EventEndTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n    ");
            __builder.OpenElement(67, "tr");
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.AddMarkupContent(69, "<th>Event Description</th>\r\n        ");
            __builder.OpenElement(70, "td");
            __builder.AddAttribute(71, "class", "text-info");
            __builder.AddContent(72, 
#nullable restore
#line 51 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EventDetailsPage.razor"
                               Event.EventDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EventDetailsPage.razor"
       

    [Parameter]
    public Event Event { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591