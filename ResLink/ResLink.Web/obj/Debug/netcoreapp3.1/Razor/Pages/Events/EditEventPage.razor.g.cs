#pragma checksum "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EditEventPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eb880e565547842d78b7d97d9d070c0f11284cd"
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
    public partial class EditEventPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EditEventPage.razor"
                                    _event

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EditEventPage.razor"
                                                           OnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddAttribute(10, "style", "margin-bottom: 16px");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-3");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(15);
                __builder2.AddAttribute(16, "Text", "Title");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col");
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(22);
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "Name", "EventTitle");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EditEventPage.razor"
                                                              _event.EventTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _event.EventTitle = __value, _event.EventTitle))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _event.EventTitle));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "row");
                __builder2.AddAttribute(33, "style", "margin-bottom: 16px");
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-md-3");
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(38);
                __builder2.AddAttribute(39, "Text", "Start Date");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col");
                __builder2.AddMarkupContent(44, "\r\n            ");
                __Blazor.ResLink.Web.Pages.Events.EditEventPage.TypeInference.CreateRadzenDatePicker_0(__builder2, 45, 46, 
#nullable restore
#line 20 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EditEventPage.razor"
                                                                             true

#line default
#line hidden
#nullable disable
                , 47, 
#nullable restore
#line 20 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EditEventPage.razor"
                                            _event.EventStartTime

#line default
#line hidden
#nullable disable
                , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _event.EventStartTime = __value, _event.EventStartTime)), 49, () => _event.EventStartTime);
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "row");
                __builder2.AddAttribute(55, "style", "margin-bottom: 16px");
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col-md-3");
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(60);
                __builder2.AddAttribute(61, "Text", "End Time");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col");
                __builder2.AddMarkupContent(66, "\r\n            ");
                __Blazor.ResLink.Web.Pages.Events.EditEventPage.TypeInference.CreateRadzenDatePicker_1(__builder2, 67, 68, 
#nullable restore
#line 28 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EditEventPage.razor"
                                                                           true

#line default
#line hidden
#nullable disable
                , 69, 
#nullable restore
#line 28 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EditEventPage.razor"
                                            _event.EventEndTime

#line default
#line hidden
#nullable disable
                , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _event.EventEndTime = __value, _event.EventEndTime)), 71, () => _event.EventEndTime);
                __builder2.AddMarkupContent(72, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n    ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "row");
                __builder2.AddAttribute(77, "style", "margin-bottom: 16px");
                __builder2.AddMarkupContent(78, "\r\n        ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "col-3");
                __builder2.AddMarkupContent(81, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(82);
                __builder2.AddAttribute(83, "Text", "Description");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n        ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "col");
                __builder2.AddMarkupContent(88, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextArea>(89);
                __builder2.AddAttribute(90, "class", "form-control");
                __builder2.AddAttribute(91, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EditEventPage.razor"
                                                               _event.EventDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _event.EventDescription = __value, _event.EventDescription))));
                __builder2.AddAttribute(93, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _event.EventDescription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n    ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "row");
                __builder2.AddMarkupContent(99, "\r\n        <div class=\"col-md-3\"></div>\r\n        ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "col-6");
                __builder2.AddMarkupContent(102, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(103);
                __builder2.AddAttribute(104, "class", "form-control");
                __builder2.AddAttribute(105, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 42 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EditEventPage.razor"
                                                           ButtonType.Submit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(106, "Text", "Save");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n        <div class=\"col-md-3\"></div>\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\EditEventPage.razor"
       

    //Todo: Create EventViewModel for this layout, Add Validations 

    [Parameter]
    public Event Event { get; set; }


    Event _event = new Event();

    protected override void OnParametersSet()
    {
        _event = Event;
    }

    private void OnSubmit()
    {
        DialogService.Close(_event);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
namespace __Blazor.ResLink.Web.Pages.Events.EditEventPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDatePicker_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ShowTime", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ShowTime", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
