#pragma checksum "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\Pages\Announcements.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "884f1bd9929f30e043bfbfc4086c892f73a1f9eb"
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
#line 1 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.BL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\_Imports.razor"
using ResLink.DAL.Repositories;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/announcements")]
    public partial class Announcements : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\Pages\Announcements.razor"
                  announcement

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\Pages\Announcements.razor"
                                               AddAnnouncement

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(4);
                __builder2.AddAttribute(5, "class", "mb-5");
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenFieldset>(7);
                    __builder3.AddAttribute(8, "Text", "Make Announcement");
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(10, "div");
                        __builder4.AddAttribute(11, "class", "row my-3");
                        __builder4.OpenElement(12, "div");
                        __builder4.AddAttribute(13, "class", "col-md-4 align-items-center d-flex");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenLabel>(14);
                        __builder4.AddAttribute(15, "Text", "Announcement Title");
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(16, "\r\n                ");
                        __builder4.OpenElement(17, "div");
                        __builder4.AddAttribute(18, "class", "col-md-8");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(19);
                        __builder4.AddAttribute(20, "style", "width: 100%;");
                        __builder4.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\Pages\Announcements.razor"
                                                announcement.AnnouncementTitle

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => announcement.AnnouncementTitle = __value, announcement.AnnouncementTitle))));
                        __builder4.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => announcement.AnnouncementTitle));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(24, "\r\n            ");
                        __builder4.OpenElement(25, "div");
                        __builder4.AddAttribute(26, "class", "row my-3");
                        __builder4.OpenElement(27, "div");
                        __builder4.AddAttribute(28, "class", "col-md-4 align-items-center d-flex");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenLabel>(29);
                        __builder4.AddAttribute(30, "Text", "Announcement Description");
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(31, "\r\n                ");
                        __builder4.OpenElement(32, "div");
                        __builder4.AddAttribute(33, "class", "col-md-8");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextArea>(34);
                        __builder4.AddAttribute(35, "style", "width: 100%;");
                        __builder4.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\Pages\Announcements.razor"
                                                 announcement.AnnouncementDescription

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => announcement.AnnouncementDescription = __value, announcement.AnnouncementDescription))));
                        __builder4.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => announcement.AnnouncementDescription));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(39, "\r\n            \r\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(40);
                        __builder4.AddAttribute(41, "class", "my-3");
                        __builder4.AddAttribute(42, "type", "submit");
                        __builder4.AddAttribute(43, "Text", "Save");
                        __builder4.AddAttribute(44, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 24 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\Pages\Announcements.razor"
                                                                              Radzen.ButtonStyle.Info

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n\r\n");
            __builder.OpenComponent<ResLink.Web.Pages.AnnouncementsList>(46);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\Pages\Announcements.razor"
       
    Announcement announcement = new Announcement();

    private void AddAnnouncement()
    {

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
