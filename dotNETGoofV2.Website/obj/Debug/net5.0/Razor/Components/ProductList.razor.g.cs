#pragma checksum "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf48ea1943f99208847c428fb7b83e49c90469c0"
// <auto-generated/>
#pragma warning disable 1591
namespace dotNETGoofV2.Website.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
using dotNETGoofV2.Website.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
using dotNetGoofV2.Website.Models;

#line default
#line hidden
#nullable disable
    public partial class ProductList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
#nullable restore
#line 8 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
     foreach (var product in ProductsService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-img");
            __builder.AddAttribute(6, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 11 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
                                                                 product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.OpenElement(10, "h5");
            __builder.AddAttribute(11, "class", "card-title");
#nullable restore
#line 13 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
__builder.AddContent(12, product.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-footer");
            __builder.OpenElement(16, "small");
            __builder.AddAttribute(17, "class", "text-muted");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
                                  (e => SelectProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "data-toggle", "modal");
            __builder.AddAttribute(21, "data-target", "#productModal");
            __builder.AddAttribute(22, "class", "btn btn-primary");
            __builder.AddMarkupContent(23, "\n                    More Info\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">");
#nullable restore
#line 31 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
 if (selectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "modal fade");
            __builder.AddAttribute(27, "id", "productModal");
            __builder.AddAttribute(28, "tabindex", "-1");
            __builder.AddAttribute(29, "role", "dialog");
            __builder.AddAttribute(30, "aria-labelledby", "productTitle");
            __builder.AddAttribute(31, "aria-hidden", "true");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(34, "role", "document");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "modal-content");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal-header");
            __builder.OpenElement(39, "h5");
            __builder.AddAttribute(40, "class", "modal-title");
            __builder.AddAttribute(41, "id", "productTitle");
#nullable restore
#line 37 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
__builder.AddContent(42, selectedProduct.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                    ");
            __builder.AddMarkupContent(44, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal-body");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "card");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "card-img");
            __builder.AddAttribute(52, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 44 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
                                                                             selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n                        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "card-body");
            __builder.OpenElement(56, "p");
            __builder.AddAttribute(57, "class", "card-text");
#nullable restore
#line 47 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
__builder.AddContent(58, selectedProduct.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n                ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "modal-footer");
#nullable restore
#line 52 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
                     if (voteCount == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(62, "<span>Be the first one to vote!</span>");
#nullable restore
#line 55 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "span");
#nullable restore
#line 58 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
__builder.AddContent(64, voteCount);

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, " ");
#nullable restore
#line 58 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
__builder.AddContent(66, voteLabel);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 59 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
                     for (int i = 0; i < 5; i++)
                    {
                        var currentStar = i;
                        if (i <= currentRating)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(67, "span");
            __builder.AddAttribute(68, "class", "fa-star fa checked");
            __builder.AddAttribute(69, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
                                                                       (e => SubmitRating(currentRating))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 67 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "span");
            __builder.AddAttribute(71, "class", "fa-star fa");
            __builder.AddAttribute(72, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
                                                               (e => SubmitRating(currentRating))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 71 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 78 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(73, "}\n\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "/Users/mattbrown/Desktop/Demo Progams/V1 Demo Programs/dotNET-ewok/dotNETGoofV2.Website/Components/ProductList.razor"
       
    Product selectedProduct;
    string selectedProductId;

    void SelectProduct(string productId)
    {
        selectedProductId = productId;
        selectedProduct = ProductsService.GetProducts().First(x => x.Id == productId);
        GetCurrentRating();
    }

    int currentRating = 0;
    int voteCount = 0;
    string voteLabel;

    void GetCurrentRating()
    {
        if (selectedProduct.Ratings == null)
        {
            currentRating = 0;
            voteCount = 0;
        }
        else
        {
            voteCount = selectedProduct.Ratings.Count();
            voteLabel = voteCount > 1 ? "Votes" : "Vote";
            currentRating = selectedProduct.Ratings.Sum() / voteCount;
        }

        System.Console.WriteLine($"Current rating for {selectedProduct.Id}: {currentRating}");
    }

    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Rating received for {selectedProduct.Id}: {rating}");
        ProductsService.AddRating(selectedProductId, rating);
        SelectProduct(selectedProductId);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductsService ProductsService { get; set; }
    }
}
#pragma warning restore 1591
