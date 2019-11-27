#pragma checksum "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67aabca8b3b08f5228026a58c026978b2a128ba7"
// <auto-generated/>
#pragma warning disable 1591
namespace CareToCash.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 2 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\_Imports.razor"
using CareToCash;

#line default
#line hidden
#line 7 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\_Imports.razor"
using CareToCash.Shared;

#line default
#line hidden
#line 4 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
using System.Net.Http;

#line default
#line hidden
#line 5 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
using Services;

#line default
#line hidden
#line 6 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
using Models;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n\r\n        ");
            __builder.AddMarkupContent(3, "<h1 class=\"g0\">Care To Cash</h1>\r\n\r\n        ");
            __builder.AddMarkupContent(4, "<label class=\"g1\">Select Member:</label>\r\n\r\n        ");
            __builder.OpenElement(5, "select");
            __builder.AddAttribute(6, "class", "g2");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 19 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                                  _selectdUserId

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _selectdUserId = __value, _selectdUserId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(9, "\r\n\r\n");
#line 21 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
             for (int i = 0; i < _users.Count; i++)
            {

#line default
#line hidden
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", 
#line 23 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                                _users[i].Name

#line default
#line hidden
            );
            __builder.AddContent(13, 
#line 23 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                                                 _users[i].Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#line 24 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
            }

#line default
#line hidden
            __builder.AddContent(15, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n        ");
            __builder.AddMarkupContent(17, "<h1 class=\"g3\">Rustin:</h1> ");
            __builder.AddMarkupContent(18, "<h1 class=\"g4\">$80</h1>\r\n\r\n        ");
            __builder.AddMarkupContent(19, "<h3 class=\"g5\">Cares:</h3>\r\n        ");
            __builder.AddMarkupContent(20, "<div class=\"g6\">\r\n            <label>sadasdasd</label>\r\n        </div>\r\n\r\n       \r\n\r\n        ");
            __builder.AddMarkupContent(21, "<h3 class=\"g7\">Charges:</h3>\r\n        ");
            __builder.AddMarkupContent(22, "<div class=\"g8\">\r\n            <label>sadasdasd</label>\r\n        </div>\r\n\r\n      \r\n\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 48 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
      
    private int _selectdUserId = 0;
    private List<User> _users;

    protected override async Task OnInitializedAsync()
    {
        _users = new List<User>();
        await RefreshCustomerList();
    }



    private async Task RefreshCustomerList()
    {
        _users = new List<User>();
        _users = await Http.GetJsonAsync<List<User>>("https://us-central1-dazzling-torch-8270.cloudfunctions.net/getUsers");

        StateHasChanged();
    }


    private async Task AddUser()
    {
       var user = new User() { Id = 1, Name = "Bersum", Cash = 25 };
       await Http.PostJsonAsync("https://us-central1-dazzling-torch-8270.cloudfunctions.net/addUser", user);
    }



#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
