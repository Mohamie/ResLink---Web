// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\mohau\Desktop\ResLink Web\ResLink---Web\ResLink\ResLink.Web\Pages\Auth\Register.razor"
       

    ResidenceViewModel residenceViewModel = new ResidenceViewModel();
    string managerRoleId = StudentRoleViewModel.Manager.ToString();

    protected override async Task OnInitializedAsync()
    {
        residenceViewModel.ResidenceGender = (await GenderRepository.GetGender()).ToList();
        residenceViewModel.Gender = residenceViewModel.ResidenceGender[0];
    }

    private async Task RegisterResidence()
    {

        //Save Manager User Account Details
        BackendlessUser savedMangerAccount = await ResLinkUserRegistration.RegisterUserAccount(residenceViewModel.Email, residenceViewModel.Password, 1);


        //check if user was successfully created
        if(savedMangerAccount != null)
        {
            //Save ResidenceManger to db
            ResidenceManager residenceManager = new ResidenceManager();

            residenceManager.ManagerFirstName = residenceViewModel.ManagerFirstName;
            residenceManager.ManagerLastName = residenceViewModel.ManagerLastName;

            residenceManager = await ResidenceManagerRepository.SaveResidenceManager(residenceManager);

            if(residenceManager != null)
            {

                try
                {
                    //relationship between ResidenceManager and ManagerAccount, meant to log SuperUser
                    object[] managerChild = new Object[] { savedMangerAccount };
                    await ResidenceManagerRepository.SetRelation(residenceManager, "managerAccount", managerChild);


                    //since Manager will be saved in db, create a residence to link a manager to
                    Residence newResidence = new Residence();
                    newResidence.ResidenceName = residenceViewModel.ResidenceName;

                    newResidence = await ResidenceRepository.SaveResidence(newResidence);

                    //check if residence was successfully inserted
                    if (newResidence != null)
                    {
                        //relationship between Residence and Gender, gender in which residence occupy
                        object[] residenceGenderChild = new object[] { residenceViewModel.Gender };
                        await ResidenceRepository.SetRelation(newResidence, "residenceGender", residenceGenderChild);

                        //relationship between Residence and Manager, residence has a manager
                        object[] resManagerChild = new object[] { residenceManager };
                        await ResidenceRepository.SetRelation(newResidence, "residenceManager", resManagerChild);

                        //finally create a relationship between ManagerAccount and residence
                        object[] resEnrolled = new object[] { newResidence };
                        await UserAccountRepository.SetRelation(savedMangerAccount, "residence", resEnrolled);

                        //clear fields
                        residenceViewModel = null;
                        //navigate to login page
                        navManager.NavigateTo("/auth/login");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }


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
