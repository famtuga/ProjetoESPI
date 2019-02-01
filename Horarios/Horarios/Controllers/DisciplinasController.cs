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
    public class DisciplinasController : Controller
    {
        private readonly HorariosBDContext _context;

        public DisciplinasController(HorariosBDContext context)
        {
            _context = context;
        }

        // GET: Disciplinas
        public IActionResult Index(string searchString,string sortOrder, bool sortAsc, int page = 1)
        {
            var horariosBDContext = _context.Disciplina.Include(d => d.Professor).ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                horariosBDContext = horariosBDContext.Where(s => s.Nome.ToLower().Contains(searchString.ToLower())
                                       || s.Ano.ToString().ToLower().Contains(searchString.ToLower()) || s.Professor.Nome.ToLower().Contains(searchString.ToLower())).ToList();
            }

            switch (sortOrder)
            {
                case "Nome":
                    if (sortAsc)
                    {
                        horariosBDContext=horariosBDContext.OrderBy(d => d.Nome).ToList();
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
                case "Professor":
                    if (sortAsc)
                    {
                        horariosBDContext = horariosBDContext.OrderBy(d => d.Professor.Nome).ToList();
                    }
                    else
                    {
                        horariosBDContext = horariosBDContext.OrderByDescending(d => d.Professor.Nome).ToList();
                    }
                    break;
            }

            var contagemItems = horariosBDContext.Count();
            
            var viewModel = new DisciplinasViewModel() { Disciplinas = horariosBDContext.Skip(PagingInfo.ItemsPerPage * (page-1)).Take(PagingInfo.ItemsPerPage).ToList() };
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

            var disciplina = await _context.Disciplina
                .Include(d => d.Professor)
                .FirstOrDefaultAsync(m => m.DisciplinaId == id);
            if (disciplina == null)
            {
                return NotFound();
            }

            return View(disciplina);
        }

        // GET: Disciplinas/Create
        public IActionResult Create()
        {
            ViewData["ProfessorId"] = new SelectList(_context.Professor, "ProfessorId", "Nome");
            return View();
        }

        // POST: Disciplinas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DisciplinaId,Nome,Ano,Email,NumeroEstudante,EstadoEstudante,ProfessorId")] Disciplina disciplina)
        {
            if (ModelState.IsValid)
            {
                _context.Add(disciplina);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProfessorId"] = new SelectList(_context.Professor, "ProfessorId", "Nome", disciplina.ProfessorId);
            return View(disciplina);
        }

        // GET: Disciplinas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disciplina = await _context.Disciplina.FindAsync(id);
            if (disciplina == null)
            {
                return NotFound();
            }
            ViewData["ProfessorId"] = new SelectList(_context.Professor, "ProfessorId", "Nome", disciplina.ProfessorId);
            return View(disciplina);
        }

        // POST: Disciplinas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DisciplinaId,Nome,Ano,Email,NumeroEstudante,EstadoEstudante,ProfessorId")] Disciplina disciplina)
        {
            if (id != disciplina.DisciplinaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(disciplina);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DisciplinaExists(disciplina.DisciplinaId))
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

            ViewData["ProfessorId"] = new SelectList(_context.Professor, "ProfessorId", "Nome", disciplina.ProfessorId);
            return View(disciplina);
        }

        // GET: Disciplinas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disciplina = await _context.Disciplina
                .Include(d => d.Professor)
                .FirstOrDefaultAsync(m => m.DisciplinaId == id);
            if (disciplina == null)
            {
                return NotFound();
            }

            return View(disciplina);
        }

        // POST: Disciplinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var disciplina = await _context.Disciplina.FindAsync(id);
            _context.Disciplina.Remove(disciplina);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DisciplinaExists(int id)
        {
            return _context.Disciplina.Any(e => e.DisciplinaId == id);
        }
    }
}
