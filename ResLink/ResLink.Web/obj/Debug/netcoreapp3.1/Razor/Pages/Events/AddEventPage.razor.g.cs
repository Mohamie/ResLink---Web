#pragma checksum "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\AddEventPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1adb5f946a209d990282131419170da9879172cd"
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
    public partial class AddEventPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\AddEventPage.razor"
                                    _event

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\AddEventPage.razor"
                                                           OnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row");
                __builder2.AddAttribute(8, "style", "margin-bottom: 16px");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-3");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(13);
                __builder2.AddAttribute(14, "Text", "Title");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col");
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(20);
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "Name", "EventTitle");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\AddEventPage.razor"
                                                              _event.EventTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _event.EventTitle = __value, _event.EventTitle))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _event.EventTitle));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "row");
                __builder2.AddAttribute(31, "style", "margin-bottom: 16px");
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-3");
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(36);
                __builder2.AddAttribute(37, "Text", "Start Date");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "col");
                __builder2.AddMarkupContent(42, "\r\n            ");
                __Blazor.ResLink.Web.Pages.Events.AddEventPage.TypeInference.CreateRadzenDatePicker_0(__builder2, 43, 44, 
#nullable restore
#line 18 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\AddEventPage.razor"
                                                                             true

#line default
#line hidden
#nullable disable
                , 45, 
#nullable restore
#line 18 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\AddEventPage.razor"
                                            _event.EventStartTime

#line default
#line hidden
#nullable disable
                , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _event.EventStartTime = __value, _event.EventStartTime)), 47, () => _event.EventStartTime);
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "row");
                __builder2.AddAttribute(53, "style", "margin-bottom: 16px");
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "col-3");
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(58);
                __builder2.AddAttribute(59, "Text", "End Time");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "col");
                __builder2.AddMarkupContent(64, "\r\n            ");
                __Blazor.ResLink.Web.Pages.Events.AddEventPage.TypeInference.CreateRadzenDatePicker_1(__builder2, 65, 66, 
#nullable restore
#line 26 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\AddEventPage.razor"
                                                                           true

#line default
#line hidden
#nullable disable
                , 67, 
#nullable restore
#line 26 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\AddEventPage.razor"
                                            _event.EventEndTime

#line default
#line hidden
#nullable disable
                , 68, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _event.EventEndTime = __value, _event.EventEndTime)), 69, () => _event.EventEndTime);
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n    ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "row");
                __builder2.AddAttribute(75, "style", "margin-bottom: 16px");
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "col-3");
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(80);
                __builder2.AddAttribute(81, "Text", "Event Description");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n        ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "col");
                __builder2.AddMarkupContent(86, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextArea>(87);
                __builder2.AddAttribute(88, "class", "form-control");
                __builder2.AddAttribute(89, "Style", "min-height: 80px;");
                __builder2.AddAttribute(90, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\AddEventPage.razor"
                                                                                         _event.EventDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _event.EventDescription = __value, _event.EventDescription))));
                __builder2.AddAttribute(92, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _event.EventDescription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n    ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "row");
                __builder2.AddMarkupContent(98, "\r\n        <div class=\"col-md-3\"></div>\r\n        ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "col-6");
                __builder2.AddMarkupContent(101, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(102);
                __builder2.AddAttribute(103, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 40 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\AddEventPage.razor"
                                      ButtonType.Submit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(104, "Text", "Save");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n        <div class=\"col-md-3\"></div>\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\AddEventPage.razor"
       

    [Parameter]
    public DateTime EventStartTime { get; set; }

    [Parameter]
    public DateTime EventEndTime { get; set; }


    Event _event = new Event();

    protected override void OnParametersSet()
    {
        _event.EventStartTime = EventStartTime;        
        _event.EventEndTime = EventEndTime;        
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
namespace __Blazor.ResLink.Web.Pages.Events.AddEventPage
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