#pragma checksum "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\Pages\CategoriesComp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa97fd55888cbb7cc4881f3762d4788862595b93"
// <auto-generated/>
#pragma warning disable 1591
namespace MoviesPlatform.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using MoviesPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using MoviesPlatform.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\_Imports.razor"
using CoreActions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories")]
    public partial class CategoriesComp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Categories Management</h3>");
#nullable restore
#line 6 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\Pages\CategoriesComp.razor"
 if (categories != null)
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "<thead><tr><th>Name</th>\r\n                <th>Description</th></tr></thead>\r\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 17 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\Pages\CategoriesComp.razor"
             foreach (var category in categories)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 20 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\Pages\CategoriesComp.razor"
                         category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                    ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 21 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\Pages\CategoriesComp.razor"
                         category.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\Pages\CategoriesComp.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\Pages\CategoriesComp.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Public\back-end-movies\MoviesPlatform\MoviesPlatform\Pages\CategoriesComp.razor"
       
    private List<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        categories = ViewCategory.Execute()?.ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IViewCategory ViewCategory { get; set; }
    }
}
#pragma warning restore 1591
