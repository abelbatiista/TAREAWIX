#pragma checksum "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4bbc4e1de3010e387ba0cc768b9bf5e5a543d5e"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\_Imports.razor"
using Blazor.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\_Imports.razor"
using Blazor.DataS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/formulario")]
    public partial class Formulario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Formulario</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "tr");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddMarkupContent(5, "<th>Cedula: </th>\r\n        ");
            __builder.OpenElement(6, "td");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "");
            __builder.AddAttribute(10, "placeholder", "Cedula...");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
                                               persona.Cedula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.Cedula = __value, persona.Cedula));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.AddMarkupContent(17, "<th>Nombre: </th>\r\n        ");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "text");
            __builder.AddAttribute(21, "class", "");
            __builder.AddAttribute(22, "placeholder", "Nombre...");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
                                               persona.Nombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.Nombre = __value, persona.Nombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.AddMarkupContent(29, "<th>Apellido: </th>\r\n        ");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "class", "");
            __builder.AddAttribute(34, "placeholder", "Apellido...");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
                                               persona.Apellido

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.Apellido = __value, persona.Apellido));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.AddMarkupContent(41, "<th>Teléfono: </th>\r\n        ");
            __builder.OpenElement(42, "td");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "");
            __builder.AddAttribute(45, "class", "");
            __builder.AddAttribute(46, "placeholder", "Teléfono...");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
                                           persona.Telefono

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.Telefono = __value, persona.Telefono));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.OpenElement(51, "tr");
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.AddMarkupContent(53, "<th>Correo: </th>\r\n        ");
            __builder.OpenElement(54, "td");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "type", "email");
            __builder.AddAttribute(57, "class", "");
            __builder.AddAttribute(58, "placeholder", "Correo Electrónico...");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
                                                persona.Correo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.Correo = __value, persona.Correo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.OpenElement(63, "tr");
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.AddMarkupContent(65, "<th>Fecha Nacimiento: </th>\r\n        ");
            __builder.OpenElement(66, "td");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "type", "date");
            __builder.AddAttribute(69, "class", "");
            __builder.AddAttribute(70, "placeholder", "Fecha de Nacimiento...");
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
                                               fecha

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fecha = __value, fecha, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n    ");
            __builder.OpenElement(75, "tr");
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.AddMarkupContent(77, "<th>Tipo Sangre: </th>\r\n        ");
            __builder.OpenElement(78, "td");
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "type", "text");
            __builder.AddAttribute(81, "class", "");
            __builder.AddAttribute(82, "placeholder", "Tipo de Sangre...");
            __builder.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
                                               persona.Sangre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.Sangre = __value, persona.Sangre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n    ");
            __builder.OpenElement(87, "tr");
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.AddMarkupContent(89, "<th>Provincia: </th>\r\n        ");
            __builder.OpenElement(90, "td");
            __builder.OpenElement(91, "input");
            __builder.AddAttribute(92, "type", "text");
            __builder.AddAttribute(93, "class", "");
            __builder.AddAttribute(94, "placeholder", "Provincia...");
            __builder.AddAttribute(95, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
                                               persona.Provincia

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.Provincia = __value, persona.Provincia));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.OpenElement(99, "tr");
            __builder.AddMarkupContent(100, "\r\n        ");
            __builder.AddMarkupContent(101, "<th>Dirección: </th>\r\n        ");
            __builder.OpenElement(102, "td");
            __builder.OpenElement(103, "input");
            __builder.AddAttribute(104, "type", "text");
            __builder.AddAttribute(105, "class", "");
            __builder.AddAttribute(106, "placeholder", "Dirección...");
            __builder.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
                                               persona.Direccion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.Direccion = __value, persona.Direccion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n    ");
            __builder.OpenElement(111, "tr");
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.AddMarkupContent(113, "<th>Latitud: </th>\r\n        ");
            __builder.OpenElement(114, "td");
            __builder.OpenElement(115, "input");
            __builder.AddAttribute(116, "type", "number");
            __builder.AddAttribute(117, "class", "");
            __builder.AddAttribute(118, "placeholder", "Latitud...");
            __builder.AddAttribute(119, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
                                                 persona.Latitud

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(120, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.Latitud = __value, persona.Latitud, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n    ");
            __builder.OpenElement(123, "tr");
            __builder.AddMarkupContent(124, "\r\n        ");
            __builder.AddMarkupContent(125, "<th>Longitud: </th>\r\n        ");
            __builder.OpenElement(126, "td");
            __builder.OpenElement(127, "input");
            __builder.AddAttribute(128, "type", "number");
            __builder.AddAttribute(129, "class", "");
            __builder.AddAttribute(130, "placeholder", "Longitud...");
            __builder.AddAttribute(131, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
                                                 persona.Longitud

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(132, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.Longitud = __value, persona.Longitud, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n    ");
            __builder.OpenElement(135, "tr");
            __builder.AddMarkupContent(136, "\r\n        ");
            __builder.AddMarkupContent(137, "<th>Covid: </th>\r\n        ");
            __builder.OpenElement(138, "td");
            __builder.OpenElement(139, "input");
            __builder.AddAttribute(140, "type", "text");
            __builder.AddAttribute(141, "class", "");
            __builder.AddAttribute(142, "placeholder", "Indique si le ha dado covid...");
            __builder.AddAttribute(143, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
                                               persona.Covid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(144, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.Covid = __value, persona.Covid));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n    ");
            __builder.OpenElement(147, "tr");
            __builder.AddMarkupContent(148, "\r\n        ");
            __builder.AddMarkupContent(149, "<th>Justificación: </th>\r\n        ");
            __builder.OpenElement(150, "td");
            __builder.OpenElement(151, "input");
            __builder.AddAttribute(152, "type", "text");
            __builder.AddAttribute(153, "class", "");
            __builder.AddAttribute(154, "placeholder", "Justifique...");
            __builder.AddAttribute(155, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
                                               persona.Justificacion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(156, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => persona.Justificacion = __value, persona.Justificacion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n    ");
            __builder.OpenElement(159, "tr");
            __builder.AddMarkupContent(160, "\r\n        ");
            __builder.OpenElement(161, "button");
            __builder.AddAttribute(162, "type", "button");
            __builder.AddAttribute(163, "class", "btn btn-success");
            __builder.AddAttribute(164, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
                                                                Insercion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(165, "Enviar");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n    ");
            __builder.OpenElement(168, "span");
            __builder.AddAttribute(169, "style", "font-weight:bold;font-size:28px;color:#c00;");
            __builder.AddContent(170, 
#nullable restore
#line 62 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
                                                               Mensaje

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n\r\n");
            __builder.AddMarkupContent(173, "<footer>\r\n    <a href=\"acercade\">Acerca de</a>\r\n</footer>");
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO WIX - HOSTING\II. APLICACIÓN\Blazor\Blazor\Pages\Formulario.razor"
       

    DateTime fecha = new DateTime();

    CPersona persona = new CPersona();
    CPersona_BD persona_bd = new CPersona_BD();

    private string Mensaje { get; set; } = "";

    private void EnviarCorreo(string correo_para)
    {
        try
        {
            using (MailMessage correo = new MailMessage())
            {
                correo.From = new MailAddress("abelrodrqz@gmail.com");
                correo.To.Add(correo_para);
                correo.Subject = "VACUNAS RD - #VACUNATE";
                correo.Body = "<h1>VACUNAS</h1><p>Nos complace informarle que usted está aceptado para ser vacunado.</p>";
                correo.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new System.Net.NetworkCredential("abelrodrqz@gmail.com", "abel06032001");
                    smtp.EnableSsl = true;
                    smtp.Send(correo);
                    Mensaje = "Enviado";
                }
            }
        }
        catch (Exception ex)
        {

            Mensaje = ex.Message;
        }
    }

    private void Insercion()
    {
        persona.Fecha = fecha.ToString("yyyyMMdd");
        persona_bd.Insertar(persona.Cedula, persona.Nombre, persona.Apellido, persona.Telefono, persona.Correo, persona.Fecha, persona.Sangre, persona.Provincia, persona.Direccion, persona.Latitud, persona.Longitud, persona.Covid, persona.Justificacion);
        EnviarCorreo(persona.Correo);
        persona.Cedula = "";
        persona.Nombre = "";
        persona.Apellido = "";
        persona.Telefono = "";
        persona.Correo = "";
        persona.Fecha = "";
        persona.Sangre = "";
        persona.Provincia = "";
        persona.Direccion = "";
        persona.Latitud = "";
        persona.Longitud = "";
        persona.Covid = "";
        persona.Justificacion = "";
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
