#pragma checksum "E:\Documents\DevCodeCamp\Projects\ChickenTinderss\ChickenTinder\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "591bf0d25fb21d52ab92a25b4f24d5364bd463c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Documents\DevCodeCamp\Projects\ChickenTinderss\ChickenTinder\Views\_ViewImports.cshtml"
using ChickenTinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Documents\DevCodeCamp\Projects\ChickenTinderss\ChickenTinder\Views\_ViewImports.cshtml"
using ChickenTinder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"591bf0d25fb21d52ab92a25b4f24d5364bd463c3", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"087902d9418ed09ee3b9e11689d967730aa3a6ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Documents\DevCodeCamp\Projects\ChickenTinderss\ChickenTinder\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "591bf0d25fb21d52ab92a25b4f24d5364bd463c33566", async() => {
                WriteLiteral(@"
    <title>Place Autocomplete Address Form</title>
    <meta name=""viewport"" content=""initial-scale=1.0, user-scalable=no"">
    <meta charset=""utf-8"">
    <style>
         /* Always set the map height explicitly to define the size of the div
        * element that contains the map. */
         #map {
             height: 100%;
         }
         /* Optional: Makes the sample page fill the window. */
         html, body {
             height: 100%;
             margin: 0;
             padding: 0;
         }
    </style>
    <link type=""text/css"" rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto:300,400,500"">
    <style>
        #locationField, #controls {
            position: relative;
            width: 480px;
        }

        #autocomplete {
            position: absolute;
            top: 0px;
            left: 0px;
            width: 99%;
        }

        .label {
            text-align: right;
            font-weight: bold;
            width: 10");
                WriteLiteral(@"0px;
            color: #303030;
            font-family: ""Roboto"";
        }

        #address {
            border: 1px solid #000090;
            background-color: #f0f9ff;
            width: 480px;
            padding-right: 2px;
        }

            #address td {
                font-size: 10pt;
            }

        .field {
            width: 99%;
        }

        .slimField {
            width: 80px;
        }

        .wideField {
            width: 200px;
        }

        #locationField {
            height: 20px;
            margin-bottom: 2px;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "591bf0d25fb21d52ab92a25b4f24d5364bd463c36232", async() => {
                WriteLiteral(@"
    <div id=""locationField"">
        <input id=""autocomplete""
               placeholder=""Enter your address""
               onFocus=""geolocate()""
               type=""text"" />
    </div>

    <!-- Note: The address components in this sample are typical. You might need to adjust them for
               the locations relevant to your app. For more information, see
         https://developers.google.com/maps/documentation/javascript/examples/places-autocomplete-addressform
    -->

    <table id=""address"">
        <tr>
            <td class=""label"">Street address</td>
            <td class=""slimField""><input class=""field"" id=""street_number"" disabled=""true"" /></td>
            <td class=""wideField"" colspan=""2""><input class=""field"" id=""route"" disabled=""true"" /></td>
        </tr>
        <tr>
            <td class=""label"">City</td>
            <td class=""wideField"" colspan=""3""><input class=""field"" id=""locality"" disabled=""true"" /></td>
        </tr>
        <tr>
            <td class=""labe");
                WriteLiteral(@"l"">State</td>
            <td class=""slimField""><input class=""field"" id=""administrative_area_level_1"" disabled=""true"" /></td>
            <td class=""label"">Zip code</td>
            <td class=""wideField""><input class=""field"" id=""postal_code"" disabled=""true"" /></td>
        </tr>
        <tr>
            <td class=""label"">Country</td>
            <td class=""wideField"" colspan=""3""><input class=""field"" id=""country"" disabled=""true"" /></td>
        </tr>
    </table>

    <script>
        // This sample uses the Autocomplete widget to help the user select a
        // place, then it retrieves the address components associated with that
        // place, and then it populates the form fields with those details.
        // This sample requires the Places library. Include the libraries=places
        // parameter when you first load the API. For example:
        // <script
        // src=""https://maps.googleapis.com/maps/api/js?key=YOUR_API_KEY&libraries=places&key=AIzaSyDYOfNHmliUkVdFosGSTqEhV4Sb-f");
                WriteLiteral(@"HpepQ"">

        var placeSearch, autocomplete;

        var componentForm = {
            street_number: 'short_name',
            route: 'long_name',
            locality: 'long_name',
            administrative_area_level_1: 'short_name',
            country: 'long_name',
            postal_code: 'short_name'
        };

        function initAutocomplete() {
            // Create the autocomplete object, restricting the search predictions to
            // geographical location types.
            autocomplete = new google.maps.places.Autocomplete(
                document.getElementById('autocomplete'), { types: ['geocode'] });

            // Avoid paying for data that you don't need by restricting the set of
            // place fields that are returned to just the address components.
            autocomplete.setFields(['address_component']);

            // When the user selects an address from the drop-down, populate the
            // address fields in the form.
            au");
                WriteLiteral(@"tocomplete.addListener('place_changed', fillInAddress);
        }

        function fillInAddress() {
            // Get the place details from the autocomplete object.
            var place = autocomplete.getPlace();

            for (var component in componentForm) {
                document.getElementById(component).value = '';
                document.getElementById(component).disabled = false;
            }

            // Get each component of the address from the place details,
            // and then fill-in the corresponding field on the form.
            for (var i = 0; i < place.address_components.length; i++) {
                var addressType = place.address_components[i].types[0];
                if (componentForm[addressType]) {
                    var val = place.address_components[i][componentForm[addressType]];
                    document.getElementById(addressType).value = val;
                }
            }
        }

        // Bias the autocomplete object to the u");
                WriteLiteral(@"ser's geographical location,
        // as supplied by the browser's 'navigator.geolocation' object.
        function geolocate() {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(function (position) {
                    var geolocation = {
                        lat: position.coords.latitude,
                        lng: position.coords.longitude
                    };
                    var circle = new google.maps.Circle(
                        { center: geolocation, radius: position.coords.accuracy });
                    autocomplete.setBounds(circle.getBounds());
                });
            }
        }
    </script>
    <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyDYOfNHmliUkVdFosGSTqEhV4Sb-fHpepQ&libraries=places&callback=initAutocomplete""
            async defer></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
