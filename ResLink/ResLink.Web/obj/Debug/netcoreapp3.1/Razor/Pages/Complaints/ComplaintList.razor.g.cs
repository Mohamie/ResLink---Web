#pragma checksum "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1415554c37cd7713a95c7af33b8c85c117a737a"
// <auto-generated/>
#pragma warning disable 1591
namespace ResLink.Web.Pages.Complaints
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
    public partial class ComplaintList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<Complaint>>(0);
            __builder.AddAttribute(1, "class", "shadow mt-3");
            __builder.AddAttribute(2, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                                                                   10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Complaint>>(
#nullable restore
#line 6 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                       complaints

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ColumnWidth", "200px");
            __builder.AddAttribute(8, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Complaint>>(10);
                __builder2.AddAttribute(11, "Property", "ComplaintTitle");
                __builder2.AddAttribute(12, "Title", "Title");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Complaint>>(14);
                __builder2.AddAttribute(15, "Property", "ComplaintDescription");
                __builder2.AddAttribute(16, "Title", "Description");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Complaint>>(18);
                __builder2.AddAttribute(19, "Property", "Student.FullNames");
                __builder2.AddAttribute(20, "Title", "Complaint From");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Complaint>>(22);
                __builder2.AddAttribute(23, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                                                        false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                                                                           false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                                                                                            false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 12 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                                                                                                              TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "Width", "100px");
                __builder2.AddAttribute(28, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Complaint>)((complaint) => (__builder3) => {
                    __builder3.AddMarkupContent(29, "\r\n\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(30);
                    __builder3.AddAttribute(31, "Icon", "published_with_changes");
                    __builder3.AddAttribute(32, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 16 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                                                  ButtonSize.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                                                                            (() => ChangeStatus(complaint))

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Complaint>>(36);
                __builder2.AddAttribute(37, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                                                        false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                                                                           false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                                                                                            false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 22 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                                                                                                              TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Width", "100px");
                __builder2.AddAttribute(42, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Complaint>)((complaint) => (__builder3) => {
                    __builder3.AddMarkupContent(43, "\r\n\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(44);
                    __builder3.AddAttribute(45, "Icon", "visibility");
                    __builder3.AddAttribute(46, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 26 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                                      ButtonSize.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
                                                                                (() => Details(complaint))

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Complaints\ComplaintList.razor"
 
    List<Complaint> complaints;
    List<ComplaintStatus> complaintStatuses;

    protected async override Task OnInitializedAsync()
    {
        complaints = (await ComplaintRepository.getComplaints()).ToList();
        complaintStatuses = (await ComplaintStatusRepository.GetComplaintStatus()).ToList();
    }

    async Task Details(Complaint complaint)
    {
        await DialogService.OpenAsync<ComplaintDetails>("Complaint Details", new Dictionary<string, object> { { "Complaint", complaint } }, new DialogOptions() { Width = "700px", Height = "800px" });
    }

    async Task ChangeStatus(Complaint complaint)
    {
        Complaint editComplaint = await DialogService.OpenAsync<ComplaintStatusPage>("Complaint Status", new Dictionary<string, object> { { "EditComplaint", complaint }, { "ComplaintStatuses", complaintStatuses } });

        if(editComplaint != null)
        {
            //Make An Update here
            object[] childObject = new object[] { editComplaint.ComplaintStatus };
            await ComplaintRepository.SetRelation(editComplaint, "complaintStatus", childObject);

            object[] childResovler = new object[] { await UserAccountRepository.GetLoggedHouseCommittee() };
            await ComplaintRepository.SetRelation(editComplaint, "resolver", childResovler);

            NotificationMessage message = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Complaint:", Detail = "Status Changed", Duration = 4000 };

            NotificationService.Notify(message);

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
