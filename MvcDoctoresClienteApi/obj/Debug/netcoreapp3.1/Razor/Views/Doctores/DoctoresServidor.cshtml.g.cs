#pragma checksum "C:\Users\Serra\Desktop\MvcDoctoresClienteApi\MvcDoctoresClienteApi\Views\Doctores\DoctoresServidor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14a02c7aeaf4523c03bc63e136dd696e545690af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctores_DoctoresServidor), @"mvc.1.0.view", @"/Views/Doctores/DoctoresServidor.cshtml")]
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
#line 1 "C:\Users\Serra\Desktop\MvcDoctoresClienteApi\MvcDoctoresClienteApi\Views\_ViewImports.cshtml"
using MvcDoctoresClienteApi;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14a02c7aeaf4523c03bc63e136dd696e545690af", @"/Views/Doctores/DoctoresServidor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7e313096722fccb51fcad7776e2a1bfa306f0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctores_DoctoresServidor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcDoctoresClienteApi.Models.Doctor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Serra\Desktop\MvcDoctoresClienteApi\MvcDoctoresClienteApi\Views\Doctores\DoctoresServidor.cshtml"
  
    ViewData["Title"] = "DoctoresServidor";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Serra\Desktop\MvcDoctoresClienteApi\MvcDoctoresClienteApi\Views\Doctores\DoctoresServidor.cshtml"
   
    List<String> especialidades = ViewData["ESPECIALIDADES"] as List<String>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Doctores Api Servidor C#</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a02c7aeaf4523c03bc63e136dd696e545690af4221", async() => {
                WriteLiteral("\r\n    <label>Seleccione una especialidad: </label>\r\n    <select name=\"especialidad\">\r\n");
#nullable restore
#line 16 "C:\Users\Serra\Desktop\MvcDoctoresClienteApi\MvcDoctoresClienteApi\Views\Doctores\DoctoresServidor.cshtml"
         foreach (String espe in especialidades)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a02c7aeaf4523c03bc63e136dd696e545690af4864", async() => {
#nullable restore
#line 18 "C:\Users\Serra\Desktop\MvcDoctoresClienteApi\MvcDoctoresClienteApi\Views\Doctores\DoctoresServidor.cshtml"
                             Write(espe);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\Serra\Desktop\MvcDoctoresClienteApi\MvcDoctoresClienteApi\Views\Doctores\DoctoresServidor.cshtml"
               WriteLiteral(espe);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\Serra\Desktop\MvcDoctoresClienteApi\MvcDoctoresClienteApi\Views\Doctores\DoctoresServidor.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select>\r\n    <button type=\"submit\" class=\"btn btn-outline-info\">\r\n        Mostrar doctores\r\n    </button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table table-bordered table-danger\">\r\n    <thead>\r\n        <tr>\r\n            <th>Apellido</th>\r\n            <th>Especialidad</th>\r\n            <th>Salario</th>\r\n            <th>Hospital</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\Serra\Desktop\MvcDoctoresClienteApi\MvcDoctoresClienteApi\Views\Doctores\DoctoresServidor.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Serra\Desktop\MvcDoctoresClienteApi\MvcDoctoresClienteApi\Views\Doctores\DoctoresServidor.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdDoctor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Serra\Desktop\MvcDoctoresClienteApi\MvcDoctoresClienteApi\Views\Doctores\DoctoresServidor.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Serra\Desktop\MvcDoctoresClienteApi\MvcDoctoresClienteApi\Views\Doctores\DoctoresServidor.cshtml"
           Write(Html.DisplayFor(modelItem => item.Especialidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Serra\Desktop\MvcDoctoresClienteApi\MvcDoctoresClienteApi\Views\Doctores\DoctoresServidor.cshtml"
           Write(Html.DisplayFor(modelItem => item.Salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\Serra\Desktop\MvcDoctoresClienteApi\MvcDoctoresClienteApi\Views\Doctores\DoctoresServidor.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hospital));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\Serra\Desktop\MvcDoctoresClienteApi\MvcDoctoresClienteApi\Views\Doctores\DoctoresServidor.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcDoctoresClienteApi.Models.Doctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
