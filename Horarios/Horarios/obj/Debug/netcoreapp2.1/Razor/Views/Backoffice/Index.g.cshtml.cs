#pragma checksum "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Backoffice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bf49e9fc69c2370197d407c46ff0f38bf55ff2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Backoffice_Index), @"mvc.1.0.view", @"/Views/Backoffice/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Backoffice/Index.cshtml", typeof(AspNetCore.Views_Backoffice_Index))]
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
#line 1 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\_ViewImports.cshtml"
using Horarios;

#line default
#line hidden
#line 2 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\_ViewImports.cshtml"
using Horarios.Models;

#line default
#line hidden
#line 3 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\_ViewImports.cshtml"
using Horarios.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf49e9fc69c2370197d407c46ff0f38bf55ff2a", @"/Views/Backoffice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d29bd2f65bf33ae6b21504e261012503ee463161", @"/Views/_ViewImports.cshtml")]
    public class Views_Backoffice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Backoffice\Index.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(72, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Backoffice\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(113, 442, true);
            WriteLiteral(@"
<h2>Visualização das Provas</h2>
<div id=""calender""></div>



<link href=""//cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.min.css"" rel=""stylesheet"" />
<link href=""//cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.print.css"" rel=""stylesheet"" media=""print"" />
<link href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.47/css/bootstrap-datetimepicker.min.css"" rel=""stylesheet"" />
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(572, 4526, true);
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.18.1/moment.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.47/js/bootstrap-datetimepicker.min.js""></script>
    <script>
        $(document).ready(function () {
            var events = [];
            var selectedEvent = null;
            FetchEventAndRenderCalendar();
            function FetchEventAndRenderCalendar() {
                events = [];
                $.ajax({
                    type: ""GET"",
                    url: ""/backoffice/GetEvents"",
                    success: function (data) {
                        $.each(data, function (i, v) {
                            events.push({
                                eventID: v.horarioId,
                                title: v.nomeProva,
                                description: ");
                WriteLiteral(@"v.descricao,
                                start: moment(v.datainicio),
                                end: v.datafim != null ? moment(v.datafim) : null,
                                color: v.temaCor,
                                allDay: v.diaInteiro
                            });
                        })

                        GenerateCalender(events);
                    },
                    error: function (error) {
                        alert('failed');
                    }
                })
            }

            function GenerateCalender(events) {
                $('#calender').fullCalendar('destroy');
                $('#calender').fullCalendar({
                    contentHeight: 400,
                    defaultDate: new Date(),
                    timeFormat: 'h(:mm)a',
                    header: {
                        left: 'prev,next today',
                        center: 'title',
                        right: 'month,basicWeek,basicDay,agenda'");
                WriteLiteral(@"
                    },
                    eventLimit: true,
                    eventColor: '#378006',
                    events: events,
                    eventClick: function (calEvent, jsEvent, view) {
                        selectedEvent = calEvent.eventID;
                        $('#myModal #eventTitle').text(calEvent.title);
                        var $description = $('<div/>');
                        $description.append($('<p/>').html('<b>Start:</b>' + calEvent.start.format(""DD-MMM-YYYY HH:mm a"")));
                        if (calEvent.end != null) {
                            $description.append($('<p/>').html('<b>End:</b>' + calEvent.end.format(""DD-MMM-YYYY HH:mm a"")));
                        }
                        $description.append($('<p/>').html('<b>Description:</b>' + calEvent.description));
                        $('#myModal #pDetails').empty().html($description);

                        $('#myModal').modal();
                    },
                    selectabl");
                WriteLiteral(@"e: true,
                    select: function (start, end) {
                        selectedEvent = {
                            eventID: 0,
                            title: '',
                            description: '',
                            start: start,
                            end: end,
                            allDay: false,
                            color: ''
                        };
                        openAddEditForm();
                        $('#calendar').fullCalendar('unselect');
                    },
                    editable: true,
                    eventDrop: function (event) {
                        var data = {
                            EventID: event.HorarioId,
                            Subject: event.NomeProva,
                            Start: event.Datainicio.format('DD/MM/YYYY HH:mm A'),
                            End: event.Datafim != null ? event.Datafim.format('DD/MM/YYYY HH:mm A') : null,
                            Descript");
                WriteLiteral(@"ion: event.Descricao,
                            ThemeColor: event.TemaCor,
                            IsFullDay: event.DiaInteiro
                        };
                        SaveEvent(data);
                    }
                })
            }

         
            $('#dtp1,#dtp2').datetimepicker({
                format: 'DD/MM/YYYY HH:mm A'
            });

            
        })
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
