#pragma checksum "F:\SmallPaws\Small paws\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "924f10e936906965455aacb4973c99587294e2ca"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\SmallPaws\Small paws\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\SmallPaws\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\SmallPaws\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\SmallPaws\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\SmallPaws\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\SmallPaws\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\SmallPaws\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\SmallPaws\Small paws\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\SmallPaws\Small paws\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\SmallPaws\Small paws\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-ocnk4r8tjs");
#nullable restore
#line 4 "F:\SmallPaws\Small paws\Client\Shared\MainLayout.razor"
     if (1 == 2)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-ocnk4r8tjs");
            __builder.OpenComponent<Client.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "main");
            __builder.AddAttribute(9, "b-ocnk4r8tjs");
            __builder.AddMarkupContent(10, "<div class=\"top-row px-4\" b-ocnk4r8tjs><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-ocnk4r8tjs>About</a></div>\r\n\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "content px-4");
            __builder.AddAttribute(13, "b-ocnk4r8tjs");
            __builder.AddContent(14, 
#nullable restore
#line 16 "F:\SmallPaws\Small paws\Client\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "F:\SmallPaws\Small paws\Client\Shared\MainLayout.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "main");
            __builder.AddAttribute(17, "b-ocnk4r8tjs");
            __builder.AddContent(18, 
#nullable restore
#line 21 "F:\SmallPaws\Small paws\Client\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\r\n      ");
            __builder.OpenElement(20, "Login");
            __builder.AddAttribute(21, "b-ocnk4r8tjs");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591