#pragma checksum "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08cc0cef54c3a874286a8e3427a3d862cb2b6b87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_TraerUno), @"mvc.1.0.view", @"/Views/Empleado/TraerUno.cshtml")]
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
#line 1 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\_ViewImports.cshtml"
using SistemaWebEmpleado;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\_ViewImports.cshtml"
using SistemaWebEmpleado.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08cc0cef54c3a874286a8e3427a3d862cb2b6b87", @"/Views/Empleado/TraerUno.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f823a925010fb25de88789b5de61ed34f0c1bd9c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Empleado_TraerUno : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaWebEmpleado.Models.Empleado>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml"
  
    ViewData["Title"] = "TraerUno";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("sidebar", async() => {
                WriteLiteral("\r\n    Administracion de empleados\r\n");
            }
            );
            WriteLiteral("\r\n<h1>\"");
#nullable restore
#line 10 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml"
Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" \"");
#nullable restore
#line 10 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml"
                Write(Model.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</h1>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 13 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml"
Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 17 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml"
Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n    ");
#nullable restore
#line 18 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml"
Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 22 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml"
Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n    ");
#nullable restore
#line 23 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml"
Write(Html.DisplayFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 27 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml"
Write(Html.DisplayNameFor(model => model.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n    ");
#nullable restore
#line 28 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml"
Write(Html.DisplayFor(model => model.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 32 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml"
Write(Html.DisplayNameFor(model => model.Legajo));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n    ");
#nullable restore
#line 33 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml"
Write(Html.DisplayFor(model => model.Legajo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 37 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml"
Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n    ");
#nullable restore
#line 38 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml"
Write(Html.DisplayFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 42 "C:\Users\Lucía\Downloads\Accenture\bootcamp\C#\MVC_Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\TraerUno.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaWebEmpleado.Models.Empleado> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591