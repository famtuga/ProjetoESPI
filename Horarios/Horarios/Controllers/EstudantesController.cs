using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Horarios.Data;
using Horarios.Models;
using Horarios.Models.ViewModels;

namespace Horarios.Controllers
{
    public class EstudantesController : Controller
    {
        private readonly HorariosBDContext _context;

        public EstudantesController(HorariosBDContext context)
        {
            _context = context;
        }

        // GET: Disciplinas
        public IActionResult Index(string searchString, string sortOrder, bool sortAsc, int page = 1)
        {
            var horariosBDContext = _context.Estudante.Include(d => d.EstudanteDisciplina).ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                horariosBDContext = horariosBDContext.Where(s => s.Nome.ToLower().Contains(searchString.ToLower())
                                       || s.Email.ToLower().Contains(searchString.ToLower())).ToList();
            }

            switch (sortOrder)
            {
                case "Nome":
                    if (sortAsc)
                    {
                        horariosBDContext = horariosBDContext.OrderBy(d => d.Nome).ToList();
                    }
                    else
                    {
                        horariosBDContext = horariosBDContext.OrderByDescending(d => d.Nome).ToList();
                    }
                    break;
                case "Ano":
                    if (sortAsc)
                    {
                        horariosBDContext = horariosBDContext.OrderBy(d => d.Ano).ToList();
                    }
                    else
                    {
                        horariosBDContext = horariosBDContext.OrderByDescending(d => d.Ano).ToList();
                    }
                    break;
                case "Email":
                    if (sortAsc)
                    {
                        horariosBDContext = horariosBDContext.OrderBy(d => d.Email).ToList();
                    }
                    else
                    {
                        horariosBDContext = horariosBDContext.OrderByDescending(d => d.Email).ToList();
                    }
                    break;
                case "NumeroEstudante":
                    if (sortAsc)
                    {
                        horariosBDContext = horariosBDContext.OrderBy(d => d.NumeroEstudante).ToList();
                    }
                    else
                    {
                        horariosBDContext = horariosBDContext.OrderByDescending(d => d.NumeroEstudante).ToList();
                    }
                    break;
                case "EstadoEstudante":
                    if (sortAsc)
                    {
                        horariosBDContext = horariosBDContext.OrderBy(d => d.EstadoEstudante).ToList();
                    }
                    else
                    {
                        horariosBDContext = horariosBDContext.OrderByDescending(d => d.EstadoEstudante).ToList();
                    }
                    break;
            }

            var contagemItems = horariosBDContext.Count();

            var viewModel = new EstudantesViewModel() { Estudantes = horariosBDContext.Skip(PagingInfo.ItemsPerPage * (page - 1)).Take(PagingInfo.ItemsPerPage).ToList() };
            viewModel.PagingInfo.CurrentPage = page;
            viewModel.PagingInfo.TotalItems = contagemItems;
            viewModel.PagingInfo.Ascending = sortAsc;
            viewModel.PagingInfo.CurrentSort = sortOrder;
            viewModel.PagingInfo.CurrentFilter = searchString;
            return View(viewModel);

        }

        // GET: Disciplinas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudante = await _context
                .Estudante.Include(d => d.EstudanteDisciplina)
                .FirstOrDefaultAsync(m => m.EstudanteId == id);
            if (estudante == null)
            {
                return NotFound();
            }

            return View(estudante);
        }

        // GET: Disciplinas/Create
        public IActionResult Create()
        {
            //Trocar por estado disciplina
            ViewData["DisciplinaId"] = new SelectList(_context.Professor, "DisciplinaId", "Nome");
            return View();
        }

        // POST: Disciplinas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Trocar para os campos do estudante, nao incluir EstudanteDisciplina 
        public async Task<IActionResult> Create([Bind("DisciplinaId,Nome,Ano,ProfessorId")] Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                _context.Estudante.Add(estudante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            //Trocar por estado disciplina
            ViewData["DisciplinaId"] = new SelectList(_context.Professor, "DisciplinaId", "Nome", estudante.EstudanteId);
            return View(estudante);
        }

        // GET: Disciplinas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudante = await _context.Estudante.FindAsync(id);
            if (estudante == null)
            {
                return NotFound();
            }
            //Trocar por estado disciplina
            ViewData["DisciplinaId"] = new SelectList(_context.Professor, "DisciplinaId", "Nome", estudante.EstudanteId);
            return View(estudante);
        }

        // POST: Disciplinas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Trocar para os campos do estudante (os do bind), nao incluir EstudanteDisciplina 
        public async Task<IActionResult> Edit(int id, [Bind("EstudanteId,Nome,Ano,ProfessorId")] Estudante estudante)
        {
            if (id != estudante.EstudanteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Estudante.Update(estudante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstudanteExists(estudante.EstudanteId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //Trocar por estado disciplina
            ViewData["DisciplinaId"] = new SelectList(_context.Professor, "DisciplinaId", "Nome", estudante.EstudanteId);
            return View(estudante);
        }

        // GET: Disciplinas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudante = await _context.Estudante
                .Include(d => d.EstudanteDisciplina)
                .FirstOrDefaultAsync(m => m.EstudanteId == id);
            if (estudante == null)
            {
                return NotFound();
            }

            return View(estudante);
        }

        // POST: Disciplinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estudante = await _context.Estudante.FindAsync(id);
            _context.Estudante.Remove(estudante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstudanteExists(int id)
        {
            return _context.Estudante.Any(e => e.EstudanteId == id);
        }
    }
}
