#pragma checksum "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\Pages\Auth\Logout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d6d5cda4264c1119a7384e8a135a0be9c008d85"
// <auto-generated/>
#pragma warning disable 1591
namespace ResLink.Web.Pages.Auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.BL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.DAL.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web.Pages.Announments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web.Pages.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web.Pages.RegisterStudents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.DL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using BackendlessAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    public partial class Logout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\Pages\Auth\Logout.razor"
 if (CurrentlyLoggedUser != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h3");
            __builder.AddMarkupContent(1, "\r\n        Hello ");
            __builder.AddContent(2, 
#nullable restore
#line 9 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\Pages\Auth\Logout.razor"
               CurrentlyLoggedUser.Email

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "span");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(5);
            __builder.AddAttribute(6, "Text", "Logout");
            __builder.AddAttribute(7, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 11 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\Pages\Auth\Logout.razor"
                                                     ButtonStyle.Info

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\Pages\Auth\Logout.razor"
                                                                              LogoutUser

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\Pages\Auth\Logout.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\Pages\Auth\Logout.razor"
 
    public BackendlessUser CurrentlyLoggedUser { get; set; }

    protected override void OnInitialized()
    {
        CurrentlyLoggedUser = Backendless.UserService.CurrentUser;
    }

    private async Task LogoutUser()
    {
        await ResLinkUserLogin.LogoutUser();
        NotificationMessage message = new NotificationMessage
        {
            Severity = NotificationSeverity.Info,
            Detail = "Successfully logged out",
            Duration = 4000
        };

        NotificationService.Notify(message);

        NavigationManager.NavigateTo("/auth/login");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BackendlessService backendlessService { get; set; }
    }
}
#pragma warning restore 1591
