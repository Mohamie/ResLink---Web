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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\mohau\Documents\IT\3rd Year\WIL\Phase 3\ResLink Web App GitHub\ResLink---Web\ResLink\ResLink.Web\Pages\Auth\Login.razor"
 
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }

    }

    User user = new User();

    private void LoginUser()
    {

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
