#pragma checksum "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Announments\Announcements.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847eb3ac85de8848011d3d15a7d4f592db4c8dcc"
// <auto-generated/>
#pragma warning disable 1591
namespace ResLink.Web.Pages.Announments
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/announcements")]
    public partial class Announcements : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(0);
            __builder.AddAttribute(1, "class", "my-4");
            __builder.AddAttribute(2, "Text", "Add Announcement");
            __builder.AddAttribute(3, "Icon", "add_circle_outline");
            __builder.AddAttribute(4, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Announments\Announcements.razor"
                                                                                    (() => AddAnnouncement())

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Announments\Announcements.razor"
 if (announcement == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenComponent<ResLink.Web.Pages.Announments.AnnouncementsList>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 11 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Announments\Announcements.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenComponent<ResLink.Web.Pages.Announments.AnnouncementsList>(10);
            __builder.AddAttribute(11, "Announcement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ResLink.BL.Models.Announcement>(
#nullable restore
#line 15 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Announments\Announcements.razor"
                                     announcement

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 16 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Announments\Announcements.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Announments\Announcements.razor"
 
    Announcement announcement;

    async Task AddAnnouncement()
    {
        announcement = await DialogService.OpenAsync<AddAnnouncementPage>("Add Announcement");

        if(announcement != null)
        {
            await AnnouncementRepository.SaveAnnouncement(announcement);
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
