#pragma checksum "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e32cbc2e132aa10fb65e9ae4baa6497bdae05146"
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
#line 10 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#line 11 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/main")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.AddMarkupContent(3, "<h1 class=\"g0\">Care To Cash</h1>\r\n\r\n    ");
            __builder.AddMarkupContent(4, "<h3 class=\"g1\">Select Member:</h3>\r\n\r\n    ");
            __builder.OpenElement(5, "select");
            __builder.AddAttribute(6, "class", "g2");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 23 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                              _selectdUserId

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _selectdUserId = __value, _selectdUserId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(9, "\r\n\r\n");
#line 25 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
         for (int i = 0; i < _users.Count; i++)
        {

#line default
#line hidden
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", 
#line 27 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                            _users[i].id

#line default
#line hidden
            );
            __builder.AddContent(13, 
#line 27 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                                           _users[i].name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#line 28 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
        }

#line default
#line hidden
            __builder.AddContent(15, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n    ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "g3 btn-info");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 31 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                                          GetUserById

#line default
#line hidden
            ));
            __builder.AddContent(20, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n    ");
            __builder.OpenElement(22, "h1");
            __builder.AddAttribute(23, "class", "g4" + " " + (
#line 33 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                   showhide

#line default
#line hidden
            ));
            __builder.AddContent(24, 
#line 33 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                              _selectedUser

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddContent(25, " ");
            __builder.OpenElement(26, "h1");
            __builder.AddAttribute(27, "class", "g5");
            __builder.AddContent(28, 
#line 33 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                                                                 ff

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n    ");
            __builder.OpenElement(30, "h3");
            __builder.AddAttribute(31, "class", "g6" + " " + (
#line 35 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                   showhide

#line default
#line hidden
            ));
            __builder.AddContent(32, "Cares Avilable:");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "g7" + " " + (
#line 36 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                    showhide

#line default
#line hidden
            ));
            __builder.AddMarkupContent(36, "\r\n\r\n");
#line 38 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
         for (int i = 0; i < _cares_NotAssigned.Count; i++)
        {

#line default
#line hidden
            __builder.AddContent(37, "            ");
            __builder.AddMarkupContent(38, "<button class=\"btn-success\">Add</button>\r\n            ");
            __builder.OpenElement(39, "label");
            __builder.AddContent(40, 
#line 41 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                    _cares_NotAssigned[i].care

#line default
#line hidden
            );
            __builder.AddContent(41, "  $ ");
            __builder.AddContent(42, 
#line 41 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                                                   _cares_NotAssigned[i].careValue

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            <br> <hr>\r\n");
#line 43 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
        }

#line default
#line hidden
            __builder.AddMarkupContent(44, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n    ");
            __builder.OpenElement(46, "h3");
            __builder.AddAttribute(47, "class", "g8" + " " + (
#line 48 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                   showhide

#line default
#line hidden
            ));
            __builder.AddContent(48, "Cares Assigned:");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "g9" + " " + (
#line 49 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                    showhide

#line default
#line hidden
            ));
            __builder.AddMarkupContent(52, "\r\n\r\n");
#line 51 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
         for (int i = 0; i < _cares_Assigned.Count; i++)
        {

#line default
#line hidden
            __builder.AddContent(53, "            ");
            __builder.AddMarkupContent(54, "<button class=\"btn-success\">Remove</button>\r\n            ");
            __builder.OpenElement(55, "label");
            __builder.AddContent(56, 
#line 54 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                    _cares_Assigned[i].care

#line default
#line hidden
            );
            __builder.AddContent(57, ": $ ");
            __builder.AddContent(58, 
#line 54 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                                                _cares_Assigned[i].careValue

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            <br> <hr>\r\n");
#line 56 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
        }

#line default
#line hidden
            __builder.AddContent(60, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n    ");
            __builder.OpenElement(62, "h3");
            __builder.AddAttribute(63, "class", "g10" + " " + (
#line 59 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                    showhide

#line default
#line hidden
            ));
            __builder.AddContent(64, "Cares Completed:");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "g11" + " " + (
#line 60 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                     showhide

#line default
#line hidden
            ));
            __builder.AddMarkupContent(68, "\r\n\r\n");
#line 62 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
         for (int i = 0; i < _cares_Completed.Count; i++)
        {


#line default
#line hidden
            __builder.AddContent(69, "            ");
            __builder.OpenElement(70, "label");
            __builder.AddContent(71, 
#line 65 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                    _cares_Completed[i].care

#line default
#line hidden
            );
            __builder.AddContent(72, ": $ ");
            __builder.AddContent(73, 
#line 65 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                                                 _cares_Completed[i].careValue

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            <br> <hr>\r\n");
#line 67 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
        }

#line default
#line hidden
            __builder.AddContent(75, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n    ");
            __builder.OpenElement(77, "h3");
            __builder.AddAttribute(78, "class", "g12" + " " + (
#line 70 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                    showhide

#line default
#line hidden
            ));
            __builder.AddContent(79, "CHARGES:");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n    ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "g13" + " " + (
#line 71 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                     showhide

#line default
#line hidden
            ));
            __builder.AddMarkupContent(83, "\r\n\r\n");
#line 73 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
         for (int i = 0; i < _charges.Count; i++)
        {

#line default
#line hidden
            __builder.AddContent(84, "            ");
            __builder.OpenElement(85, "label");
            __builder.AddContent(86, 
#line 75 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                    _charges[i].charge

#line default
#line hidden
            );
            __builder.AddContent(87, ": $ ");
            __builder.AddContent(88, 
#line 75 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
                                           _charges[i].ChargeValue

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            <br> <hr>\r\n");
#line 77 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
        }

#line default
#line hidden
            __builder.AddContent(90, "        ");
            __builder.AddContent(91, 
#line 78 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
         temp2

#line default
#line hidden
            );
            __builder.AddMarkupContent(92, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 84 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
      

    private string temp = string.Empty;

    private string temp2 = string.Empty;

    private string showhide = "hide";

    private string _selectedUser = "";

    private int _selectdUserId = 0;
    private string ff = string.Empty;
    private List<string> ew = new List<string>();
    private List<User> _users;
    private List<Charge> _charges;
    private List<Care> _cares;
    private List<Care> _cares_NotAssigned;
    private List<Care> _cares_Assigned;
    private List<Care> _cares_Completed;

    protected override async Task OnInitializedAsync()
    {
        // _users = new List<User>();
        await RefreshCustomerList();
        //  await GetChargesById(0);
    }

    private void dothis2(string h)
    {
        _selectedUser = h;
    }

    private async Task RefreshCustomerList()
    {
        _users = new List<User>();
        _charges = new List<Charge>();
        _cares = new List<Care>();

        _cares_NotAssigned = new List<Care>();
        _cares_Assigned = new List<Care>();
        _cares_Completed = new List<Care>();

        _users = await Http.GetJsonAsync<List<User>>("https://us-central1-dazzling-torch-8270.cloudfunctions.net/appFunctions/getUsers");
        _charges = await Http.GetJsonAsync<List<Charge>>("https://us-central1-dazzling-torch-8270.cloudfunctions.net/appFunctions/getCharges");
        _cares = await Http.GetJsonAsync<List<Care>>("https://us-central1-dazzling-torch-8270.cloudfunctions.net/appFunctions/getCares");



        //temp = await Http.GetStringAsync("https://us-central1-dazzling-torch-8270.cloudfunctions.net/appFunctions/createUser/?email=kamparsen@yahoo.com&password=123456");
        //temp2 = await Http.GetStringAsync("https://us-central1-dazzling-torch-8270.cloudfunctions.net/appFunctions/getUserByEmail/?email=kamparsen@yahoo.com");

        UpdateCares_NotAssigned();
        UpdateCares_Assigned();
        UpdateCares_Completed();



        // ff = _charges[0].charge;
        StateHasChanged();
    }

    private void UpdateCares_NotAssigned()
    {
        _cares_NotAssigned.Clear();
        foreach (var item in _cares)
        {
            if (item.status == 1)
            {
                _cares_NotAssigned.Add(item);
            }
        }
    }

    private void UpdateCares_Assigned()
    {
        _cares_Assigned.Clear();
        foreach (var item in _cares)
        {
            if (item.status == 2)
            {
                _cares_Assigned.Add(item);
            }
        }
    }

    private void UpdateCares_Completed()
    {
        _cares_Completed.Clear();
        foreach (var item in _cares)
        {
            if (item.status == 3)
            {
                _cares_Completed.Add(item);
            }
        }
    }

    private void GetUserById()
    {

        var h = _users.Where(x => x.id == _selectdUserId).FirstOrDefault();
        _selectedUser = h.name;
        ff = "$" + h.cash.ToString();

        showhide = "show";

    }





#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
