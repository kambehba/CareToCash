#pragma checksum "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1df0efb658f43b4475a22df69880773672ba52e1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 8 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#line 9 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 72 "C:\Users\Kam\Documents\GitHub\CareToCash\CareToCash\Pages\Index.razor"
      

    private string _selectedUser = "";

    private int _selectdUserId = 0;
    private string ff =string.Empty;
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


        UpdateCares_NotAssigned();
        UpdateCares_Assigned();
        UpdateCares_Completed();

        

        ff = _charges[0].charge;
        StateHasChanged();
    }

    private void UpdateCares_NotAssigned()
    {
        _cares_NotAssigned.Clear();
        foreach(var item in _cares)
        {
            if(item.status == 1)
            {
                _cares_NotAssigned.Add(item);
            }
        }
    }

    private void UpdateCares_Assigned()
    {
        _cares_Assigned.Clear();
        foreach(var item in _cares)
        {
            if(item.status == 2)
            {
                _cares_Assigned.Add(item);
            }
        }
    }

    private void UpdateCares_Completed()
    {
        _cares_Completed.Clear();
        foreach(var item in _cares)
        {
            if(item.status == 3)
            {
                _cares_Completed.Add(item);
            }
        }
    }

    private void GetUserById()
    {
        var h = _users.Where(x => x.id == _selectdUserId).FirstOrDefault();
        _selectedUser = h.name;
        ff = h.cash.ToString();

    }



#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
