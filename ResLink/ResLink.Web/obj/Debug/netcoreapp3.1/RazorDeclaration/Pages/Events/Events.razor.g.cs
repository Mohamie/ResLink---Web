#pragma checksum "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\Events.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e201e6cf9b2dd3da78ff044aa5493195bca1143d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/events")]
    public partial class Events : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\user-pc\Documents\Academics\WIL\Projects\ResLink---Web\ResLink---Web\ResLink\ResLink.Web\Pages\Events\Events.razor"
       

    RadzenScheduler<Event> scheduler;

    Dictionary<DateTime, string> _events = new Dictionary<DateTime, string>();

    List<Event> eventList;


    protected override async Task OnInitializedAsync()
    {
        eventList = await EventRepository.GetEvents() as List<Event>;
    }


    async Task OnSlotSelect(SchedulerSlotSelectEventArgs args)
    {

        await AddNewEvent(args);
    }

    async Task AddNewEvent(SchedulerSlotSelectEventArgs args = null)
    {

        DateTime date = new DateTime();

        //This should be a ViewModel
        EventViewModel eventViewModel = await DialogService.OpenAsync<AddEventPage>("Add Event",
            new Dictionary<string, object> { { "EventStartTime", (args != null) ? args.Start : date.Date }, { "EventEndTime", (args != null) ? args.End : date.Date } });

        //Todo: Extract ViewModel to Model, save data and add relationships, event category and authur of the event
        if (eventViewModel != null)
        {
            //Convert ViewModel to Model
            Event _event = new Event(); //Data Model

            _event.EventTitle = eventViewModel.EventTitle;
            _event.EventDescription = eventViewModel.EventDescription;
            _event.EventStartTime = eventViewModel.StartDate;
            _event.EventEndTime = eventViewModel.EndDate;

            //Save Model(Event) to db
            _event = await EventRepository.SaveEvent(_event);


            // check if Model was saved, if so, create a relationship between HC and Event(the authur of the event)
            if (_event != null)
            {
                object[] childObject = new object[] { await UserAccountRepository.GetLoggedHouseCommittee() };
                await EventRepository.SetRelation(_event, "hc", childObject);

                eventList = null;
                eventList = await EventRepository.GetEvents() as List<Event>;

                NotificationMessage message = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Event:", Detail = "Added Successfuly", Duration = 4000 };

                NotificationService.Notify(message);
            }

            // Either call the Reload method or reassign the Data property of the Scheduler
            await scheduler.Reload();
        }
    }

    async Task OnEventSelect(SchedulerAppointmentSelectEventArgs<Event> args)
    {

        //Consider code reusability for this one

        //This should be a ViewModel
        Event editedEvent = await DialogService.OpenAsync<EditEventPage>("Edit Event", new Dictionary<string, object> { { "Event", args.Data } });

        //Todo: Extract ViewModel to Model, save data and add relationships, event category and authur of the event
        if (editedEvent != null)
        {
            await EventRepository.SaveEvent(editedEvent);
        }

        await scheduler.Reload();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
