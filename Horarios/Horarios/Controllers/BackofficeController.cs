﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Horarios.Areas.Identity.Pages.Account;
using Horarios.Models;
using Horarios.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Horarios.Controllers
{
    public class BackofficeController : Controller
    {
        private readonly HorariosBDContext _context;

        public BackofficeController(HorariosBDContext dbcontext)
        {
            _context = dbcontext;
        }


        [Authorize(Roles = "Administrador, Professor, Estudante")]
        public IActionResult Index(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [Authorize]
        public IActionResult Marcacao(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [Authorize]
        public IActionResult Disciplinas(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public IActionResult Disciplinas([Bind("DisciplinaId,Nome,Ano,ProfessorId")] Disciplina disciplina, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                _context.Disciplina.Add(disciplina);
                _context.SaveChanges();
                return View();
            }

            return View();
        }

        public JsonResult GetEvents()
        {
           
                var events = _context.Horario.ToList();
                return Json( events);
            
        }



        [Authorize]
        [HttpPost]
        public JsonResult SaveEvent(Horario h)
        {
            var status = false;
           
           
                if (h.HorarioId > 0)
                {
                    //Update the event
                    var v = _context.Horario.Where(a => a.HorarioId == h.HorarioId).FirstOrDefault();
                    if (v != null)
                    {
                        v.NomeProva = h.NomeProva;
                        v.Datainicio = h.Datainicio;
                        v.Datafim =  h.Datafim;
                        v.TipoProvaID = h.TipoProvaID;
                        v.DiaInteiro = h.DiaInteiro;
                        v.Ano = h.Ano;
                    }
                }
                else
                {
                    _context.Horario.Add(h);
                }

                _context.SaveChanges();
                status = true;

           
            return Json( new { status = status } );
        }


        [Authorize]
        [HttpPost]
        public JsonResult DeleteEvent(int eventID)
        {
            var status = false;
          
            {
                var v = _context.Horario.Where(a => a.HorarioId == eventID).FirstOrDefault();
                if (v != null)
                {
                    _context.Horario.Remove(v);
                    _context.SaveChanges();
                    status = true;
                }
            }
            return Json( new { status = status } );
        }

       public JsonResult GetProfessores()
        {
            var t = _context.Professor.Select(p => new { p.ProfessorId, p.Nome }).ToList();
            return Json(t);
        }

       

   
        
            public async Task<IActionResult> MostrarEstudantes()
            {

                return View(await _context.Estudante.ToListAsync());
            }
       

        [Authorize]
        public IActionResult MostrarDisciplinas(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View(_context.Disciplina.Include(d=>d.Professor).ToList());
        }
    }
}