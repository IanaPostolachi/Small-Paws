#pragma checksum "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f1aa6b7c152c2008cbb93890d0ef4999e702294"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAnimals")]
    public partial class ViewAnimals : ViewAnimalsRazor
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ViewAnimals</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddMarkupContent(2, "<tr><th>Age</th>\r\n        <th>Type of animal</th>\r\n        <th>Descripition</th></tr>");
#nullable restore
#line 12 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
     if (Animals != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
         foreach (var animal in Animals)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "tr");
            __builder.OpenElement(4, "td");
            __builder.AddContent(5, 
#nullable restore
#line 18 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
                     animal.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n                ");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 19 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
                     animal.AnimalType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 20 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
                     animal.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Vosta\OneDrive\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
