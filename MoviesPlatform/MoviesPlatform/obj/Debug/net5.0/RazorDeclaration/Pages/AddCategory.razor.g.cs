// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MoviesPlatform.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using MoviesPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using MoviesPlatform.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using CoreActions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addcategory")]
    public partial class AddCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "c:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\Pages\AddCategory.razor"
       

    private Category category;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        category = new Category();

    }

    private void OnValidSubmit()
    {
        AddCategoryUseCase.Execute(category);
        NavigationManager.NavigateTo("/categories");
    }

    private void OnCancel()
    {
        NavigationManager.NavigateTo("/categories");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IAddCategoryUseCase AddCategoryUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
