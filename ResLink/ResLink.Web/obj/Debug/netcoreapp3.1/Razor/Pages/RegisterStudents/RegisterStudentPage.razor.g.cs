#pragma checksum "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca44d115c104741acc010f972cff8e3417356586"
// <auto-generated/>
#pragma warning disable 1591
namespace ResLink.Web.Pages.RegisterStudents
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
    public partial class RegisterStudentPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                                    studentView

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                                                                OnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(10);
                __builder2.AddAttribute(11, "Text", "Student Number");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(13);
                __builder2.AddAttribute(14, "class", "form-control my-2");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                                                          studentView.StudentNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studentView.StudentNumber = __value, studentView.StudentNumber))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => studentView.StudentNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(19);
                __builder2.AddAttribute(20, "Text", "First Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(22);
                __builder2.AddAttribute(23, "class", "form-control my-2");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                                                          studentView.FirstNames

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studentView.FirstNames = __value, studentView.FirstNames))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => studentView.FirstNames));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(28);
                __builder2.AddAttribute(29, "Text", "Last Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(31);
                __builder2.AddAttribute(32, "class", "form-control my-2");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                                                          studentView.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studentView.LastName = __value, studentView.LastName))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => studentView.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(37);
                __builder2.AddAttribute(38, "Text", "Gender");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __Blazor.ResLink.Web.Pages.RegisterStudents.RegisterStudentPage.TypeInference.CreateInputSelect_0(__builder2, 40, 41, true, 42, "custom-select my-2", 43, 
#nullable restore
#line 19 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                                                                  studentView.Gender

#line default
#line hidden
#nullable disable
                , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studentView.Gender = __value, studentView.Gender)), 45, () => studentView.Gender, 46, (__builder3) => {
                    __builder3.AddMarkupContent(47, "\r\n\r\n");
#nullable restore
#line 21 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
     foreach (GenderViewModel gender in Enum.GetValues(typeof(GenderViewModel)))
    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(48, "        ");
                    __builder3.OpenElement(49, "option");
                    __builder3.AddAttribute(50, "value", 
#nullable restore
#line 23 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                        gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(51, " ");
                    __builder3.AddContent(52, 
#nullable restore
#line 23 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                                  gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(53, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\r\n");
#nullable restore
#line 24 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
    }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(55, "\r\n    ");
                }
                );
                __builder2.AddMarkupContent(56, "\r\n\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(57);
                __builder2.AddAttribute(58, "Text", "Role");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n    ");
                __Blazor.ResLink.Web.Pages.RegisterStudents.RegisterStudentPage.TypeInference.CreateInputSelect_1(__builder2, 60, 61, true, 62, "custom-select my-2", 63, 
#nullable restore
#line 29 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                                                                  studentView.Role

#line default
#line hidden
#nullable disable
                , 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studentView.Role = __value, studentView.Role)), 65, () => studentView.Role, 66, (__builder3) => {
                    __builder3.AddMarkupContent(67, "\r\n\r\n");
#nullable restore
#line 31 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
         foreach (StudentRoleViewModel role in Enum.GetValues(typeof(StudentRoleViewModel)))
    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(68, "    ");
                    __builder3.OpenElement(69, "option");
                    __builder3.AddAttribute(70, "value", 
#nullable restore
#line 33 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                    role

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(71, " ");
                    __builder3.AddContent(72, 
#nullable restore
#line 33 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                            role

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(73, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\r\n");
#nullable restore
#line 34 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
}

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(75, "\r\n    ");
                }
                );
                __builder2.AddMarkupContent(76, "\r\n\r\n\r\n");
#nullable restore
#line 39 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
     if (studentView.Role == StudentRoleViewModel.HouseCommittee)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(77, "        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(78);
                __builder2.AddAttribute(79, "Text", "House Committee Role: ");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n        ");
                __Blazor.ResLink.Web.Pages.RegisterStudents.RegisterStudentPage.TypeInference.CreateInputSelect_2(__builder2, 81, 82, "custom-select", 83, 
#nullable restore
#line 42 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                                                        studentView.HCRole

#line default
#line hidden
#nullable disable
                , 84, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studentView.HCRole = __value, studentView.HCRole)), 85, () => studentView.HCRole, 86, (__builder3) => {
                    __builder3.AddMarkupContent(87, "\r\n\r\n");
#nullable restore
#line 44 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
             foreach (HCRoleViewModel hcRole in Enum.GetValues(typeof(HCRoleViewModel)))
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(88, "                ");
                    __builder3.OpenElement(89, "option");
                    __builder3.AddAttribute(90, "value", 
#nullable restore
#line 46 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                                hcRole

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(91, " ");
                    __builder3.AddContent(92, 
#nullable restore
#line 46 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                                          hcRole

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(93, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(94, "\r\n");
#nullable restore
#line 47 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(95, "\r\n        ");
                }
                );
                __builder2.AddMarkupContent(96, "\r\n");
#nullable restore
#line 50 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"

    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(97, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(98);
                __builder2.AddAttribute(99, "Text", "Email");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(101);
                __builder2.AddAttribute(102, "class", "form-control my-2");
                __builder2.AddAttribute(103, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                                                          studentView.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(104, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studentView.Email = __value, studentView.Email))));
                __builder2.AddAttribute(105, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => studentView.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(106, "\r\n\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(107);
                __builder2.AddAttribute(108, "Text", "Set Password");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(109, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPassword>(110);
                __builder2.AddAttribute(111, "class", "form-control my-2");
                __builder2.AddAttribute(112, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                                                           studentView.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(113, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studentView.Password = __value, studentView.Password))));
                __builder2.AddAttribute(114, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => studentView.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\r\n\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(116);
                __builder2.AddAttribute(117, "class", "my-2");
                __builder2.AddAttribute(118, "Text", "Register");
                __builder2.AddAttribute(119, "Icon", "note_add");
                __builder2.AddAttribute(120, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 59 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
                                                                           ButtonType.Submit

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\r\n\r\n\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\RegisterStudents\RegisterStudentPage.razor"
 
    StudentViewModel studentView = new StudentViewModel();
    
    [Parameter]
    public GenderViewModel Gender { get; set; }
    
    [Parameter]
    public StudentRoleViewModel Role { get; set; }


    Student student = new Student();

    protected override void OnInitialized()
    {
        studentView.Gender = Gender;
        studentView.Role = Role;
    }

    private void OnSubmit()
    {
        DialogService.Close(student);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
namespace __Blazor.ResLink.Web.Pages.RegisterStudents.RegisterStudentPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "disabled", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "disabled", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591