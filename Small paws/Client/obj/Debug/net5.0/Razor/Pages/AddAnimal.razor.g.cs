#pragma checksum "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\Pages\AddAnimal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61b629f46c99517f7f03e5f760d3a1698455ee02"
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
#line 1 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAnimal")]
    public partial class AddAnimal : AddAnimalRazor
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<span class=\"title\" b-41e580qbhe><b b-41e580qbhe>Add new animal</b></span>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "top-side");
            __builder.AddAttribute(3, "b-41e580qbhe");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "picture-div");
            __builder.AddAttribute(6, "b-41e580qbhe");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "class", "picture");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 14 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\Pages\AddAnimal.razor"
                                   ShownImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "alt", "Upload photo");
            __builder.AddAttribute(11, "b-41e580qbhe");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\t\t");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(13);
            __builder.AddAttribute(14, "class", "picture");
            __builder.AddAttribute(15, "src", "photo_picture.png");
            __builder.AddAttribute(16, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\Pages\AddAnimal.razor"
                                                                      UploadImage

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "alt", "image of uploaded animal");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\t");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "right-side");
            __builder.AddAttribute(21, "b-41e580qbhe");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "b-41e580qbhe");
            __builder.OpenElement(24, "tr");
            __builder.AddAttribute(25, "b-41e580qbhe");
            __builder.AddMarkupContent(26, "<td b-41e580qbhe><b b-41e580qbhe>Animal type</b></td>\r\n\t\t\t\t");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "b-41e580qbhe");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "class", "input");
            __builder.AddAttribute(31, "type", "text");
            __builder.AddAttribute(32, "placeholder", "Type animal\'s type");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\Pages\AddAnimal.razor"
                                                                                             AnimalType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AnimalType = __value, AnimalType));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(35, "b-41e580qbhe");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\t\t\t");
            __builder.OpenElement(37, "tr");
            __builder.AddAttribute(38, "b-41e580qbhe");
            __builder.AddMarkupContent(39, "<td b-41e580qbhe><b b-41e580qbhe>Age</b></td>\r\n\t\t\t\t");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "b-41e580qbhe");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "class", "input");
            __builder.AddAttribute(44, "type", "text");
            __builder.AddAttribute(45, "placeholder", "Type animal\'s age");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\Pages\AddAnimal.razor"
                                                                                            Age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Age = __value, Age));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(48, "b-41e580qbhe");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\t\t\t");
            __builder.OpenElement(50, "tr");
            __builder.AddAttribute(51, "b-41e580qbhe");
            __builder.AddMarkupContent(52, "<td b-41e580qbhe><b b-41e580qbhe>Washed</b></td>\r\n\t\t\t\t");
            __builder.OpenElement(53, "td");
            __builder.AddAttribute(54, "b-41e580qbhe");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "b-41e580qbhe");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "radio");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\Pages\AddAnimal.razor"
                                                      SetWashedToTrue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "b-41e580qbhe");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, " Yes\r\n\t\t\t\t\t\t");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "type", "radio");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\Pages\AddAnimal.razor"
                                                      SetWashedToFalse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "b-41e580qbhe");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, " No\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\t\t\t");
            __builder.OpenElement(68, "tr");
            __builder.AddAttribute(69, "b-41e580qbhe");
            __builder.AddMarkupContent(70, "<td b-41e580qbhe><b b-41e580qbhe>Fed</b></td>\r\n\t\t\t\t");
            __builder.OpenElement(71, "td");
            __builder.AddAttribute(72, "b-41e580qbhe");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "b-41e580qbhe");
            __builder.OpenElement(75, "input");
            __builder.AddAttribute(76, "type", "radio");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\Pages\AddAnimal.razor"
                                                      SetFedToTrue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "b-41e580qbhe");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, " Yes\r\n\t\t\t\t\t\t");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "type", "radio");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\Pages\AddAnimal.razor"
                                                      SetFedToFalse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "b-41e580qbhe");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, " No\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\t\t\t");
            __builder.OpenElement(86, "tr");
            __builder.AddAttribute(87, "b-41e580qbhe");
            __builder.AddMarkupContent(88, "<td b-41e580qbhe><b b-41e580qbhe>Vaccinated</b></td>\r\n\t\t\t\t");
            __builder.OpenElement(89, "td");
            __builder.AddAttribute(90, "b-41e580qbhe");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "b-41e580qbhe");
            __builder.OpenElement(93, "input");
            __builder.AddAttribute(94, "type", "radio");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\Pages\AddAnimal.razor"
                                                      SetVaccinatedToTrue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "b-41e580qbhe");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, " Yes\r\n\t\t\t\t\t\t");
            __builder.OpenElement(98, "input");
            __builder.AddAttribute(99, "type", "radio");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\Pages\AddAnimal.razor"
                                                      SetVaccinatedToFalse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "b-41e580qbhe");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, " No\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "bot-side");
            __builder.AddAttribute(106, "b-41e580qbhe");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "description-div");
            __builder.AddAttribute(109, "b-41e580qbhe");
            __builder.AddMarkupContent(110, "<text class=\"description-text\" b-41e580qbhe><b b-41e580qbhe>Description: </b></text>\r\n    \t");
            __builder.OpenElement(111, "textarea");
            __builder.AddAttribute(112, "class", "description-area");
            __builder.AddAttribute(113, "placeholder", "Type animal\'s description");
            __builder.AddAttribute(114, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\Pages\AddAnimal.razor"
                                                                                          Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(115, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Description = __value, Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(116, "b-41e580qbhe");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n\t");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "wrap-login-btn");
            __builder.AddAttribute(120, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\Iana Postolachi\GitHub\Small-paws-project\Small paws\Client\Pages\AddAnimal.razor"
                                          SaveAnimal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "b-41e580qbhe");
            __builder.AddMarkupContent(122, "<div class=\"login-bgbtn\" b-41e580qbhe></div>\r\n\t\t");
            __builder.AddMarkupContent(123, "<button class=\"login-btn\" b-41e580qbhe>\r\n\t\t\tSave\r\n\t\t</button>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591