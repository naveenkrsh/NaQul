#pragma checksum "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40ef91c599a12d0d932f755a5a4630daabafdc0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NaQul_Index), @"mvc.1.0.view", @"/Views/NaQul/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NaQul/Index.cshtml", typeof(AspNetCore.Views_NaQul_Index))]
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
#line 1 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/_ViewImports.cshtml"
using naqulClient;

#line default
#line hidden
#line 2 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/_ViewImports.cshtml"
using naqulClient.Models;

#line default
#line hidden
#line 1 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40ef91c599a12d0d932f755a5a4630daabafdc0b", @"/Views/NaQul/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d91f0a3f95e8311251d198314d8470b9f5eff0f", @"/Views/_ViewImports.cshtml")]
    public class Views_NaQul_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
  
    ViewData["Title"] = "NaQul Client";

#line default
#line hidden
            BeginContext(68, 193, true);
            WriteLiteral("<br>\r\n\r\n<nav class=\"navbar navbar-dark bg-dark fixed-top\">\r\n    <a class=\"navbar-brand\" href=\"#\">NaQul</a>\r\n    <div class=\"container\">\r\n             <div class=\"container\">\r\n                \r\n");
            EndContext();
#line 12 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
                 using (Html.BeginForm("GetData", "NaQul"))
                {

#line default
#line hidden
            BeginContext(341, 263, true);
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col"">
                            <input type=""text"" id=""txtQuery"" autocomplete=""off"" name=""text"" class=""form-control"" placeholder=""type query"" style=""width:100%"" data-provide=""typeahead""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 604, "\"", 623, 1);
#line 16 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
WriteAttributeValue("", 612, Model.Text, 612, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(624, 203, true);
            WriteLiteral(">\r\n                        </div>\r\n                        <div>\r\n                            <input type=\"submit\" class=\"btn btn-success\" />\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
            BeginContext(829, 384, true);
            WriteLiteral(@"                    <!-- <div class=""row"">
                        <div class=""col-md-8"">
                            <div class=""dropdown"">
                            </div>
                        </div>
                        <div>
                            <input type=""submit"" class=""btn btn-success"" />
                        </div>
                    </div> -->
");
            EndContext();
#line 32 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1232, 64, true);
            WriteLiteral("             </div>\r\n    </div>   \r\n</nav>\r\n\r\n<div class=\"\">\r\n\r\n");
            EndContext();
#line 39 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
     if (Model.Results.Count > 0)
    {
        

#line default
#line hidden
#line 41 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
         foreach (Result result in Model.Results)
        {

#line default
#line hidden
            BeginContext(1400, 55, true);
            WriteLiteral("            <div class=\"\">\r\n                <pre><code>");
            EndContext();
            BeginContext(1456, 12, false);
#line 44 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
                      Write(result.Query);

#line default
#line hidden
            EndContext();
            BeginContext(1468, 190, true);
            WriteLiteral("</code></pre>\r\n                <table class=\"table table-responsive  table-hover\" cellpadding=\"0\" cellspacing=\"0\">\r\n                    <thead class=\"thead-dark\">\r\n                    <tr>\r\n");
            EndContext();
#line 48 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
                         foreach (DataColumn column in result.Data.Columns)
                        {

#line default
#line hidden
            BeginContext(1762, 32, true);
            WriteLiteral("                            <th>");
            EndContext();
            BeginContext(1795, 17, false);
#line 50 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
                           Write(column.ColumnName);

#line default
#line hidden
            EndContext();
            BeginContext(1812, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
#line 51 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1846, 61, true);
            WriteLiteral("                    </tr>\r\n                        </thead>\r\n");
            EndContext();
#line 54 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
                     foreach (DataRow row in result.Data.Rows)
                    {

#line default
#line hidden
            BeginContext(1994, 30, true);
            WriteLiteral("                        <tr>\r\n");
            EndContext();
#line 57 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
                             foreach (DataColumn column in result.Data.Columns)
                            {

#line default
#line hidden
            BeginContext(2136, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(2173, 22, false);
#line 59 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
                               Write(row[column.ColumnName]);

#line default
#line hidden
            EndContext();
            BeginContext(2195, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 60 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2233, 31, true);
            WriteLiteral("                        </tr>\r\n");
            EndContext();
#line 62 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2287, 46, true);
            WriteLiteral("                </table>\r\n            </div>\r\n");
            EndContext();
#line 65 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
        }

#line default
#line hidden
#line 65 "/Users/naveensharma/gitlab/naqul/src/naqulClient/naqulClient/Views/NaQul/Index.cshtml"
         

    }

#line default
#line hidden
            BeginContext(2353, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2386, 2331, true);
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-3-typeahead/4.0.0/bootstrap3-typeahead.js""></script>
        
    <script>//  function(query) {
    //         return $.get(""http://localhost:5001/api/general?prefix=""+query);
    //         }
       var jsonData = [""Naveen"",""Sharma"",""Sachin"",""Nirav""];

    var productNames = [];
    $.each(jsonData, function(index, product) {
      productNames.push(product.name + ""#"" + product.image + ""#"" + product.id);
    });

    $.get(""https://localhost:5001/api/general"", function(data){
       // $(""#name"").typeahead({ source:data });


    $('#txtQuery').typeahead({
      source: data,
      highlighter: function(item) {
        //var parts = item.split('#'),
          html = '<div><div class=""typeahead-inner"" >';
        // html += '<div class=""item-img"" style=""background-image: url(' + parts[1] + ')""></div>';
        html += '<div class=""item-body"">';
        html += '<p class=""item-heading"">' +item + '</p>';
        html += ");
                WriteLiteral(@"'</div>';
        html += '</div></div>';

        var query = this.query;
        var reEscQuery = query.replace(/[\-\[\]\/\{\}\(\)\*\+\?\.\\\^\$\|]/g, ""\\$&"");
        var reQuery = new RegExp('(' + reEscQuery + ')', ""gi"");
        var jElem = $(html);
        var textNodes = $(jElem.find('*')).add(jElem).contents().filter(function() {
          return this.nodeType === 3;
        });
        textNodes.replaceWith(function() {
          return $(this).text().replace(reQuery, '<strong>$1</strong>');
        });

        return jElem.html();
      },
      updater: function(selectedName) {
        var name = selectedName;
        return name;
      }
    });
 },'json');


    //  $( document ).ready(function() {
    //     $('#txtQuery').typeahead({
    //         name: 'search',
    //         remote: {
    //         url: 'http://suggestqueries.google.com/complete/search?client=chrome&q=%QUERY',
    //         dataType: 'jsonp',
    //         cache: false,
    //         filt");
                WriteLiteral(@"er: function(parsedResponse){
    //             return (parsedResponse.length > 1) ? parsedResponse[1] : [] ;
    //         }
    //         }
    //     }).on('typeahead:selected', function(e){
    //         e.target.form.submit();
    //     });
    //     });</script>
");
                EndContext();
            }
            );
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
