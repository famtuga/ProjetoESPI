using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Horarios.Data;
using Horarios.Models;

namespace Horarios.Controllers
{
    public class EstudanteDisciplinasController : Controller
    {
        private readonly HorariosBDContext _context;

        public EstudanteDisciplinasController(HorariosBDContext context)
        {
            _context = context;
        }

        // GET: EstudanteDisciplinas
        public async Task<IActionResult> Index()
        {
            var horariosBDContext = _context.EstudanteDisciplina.Include(e => e.Disciplina);
            return View(await horariosBDContext.ToListAsync());
        }

        // GET: EstudanteDisciplinas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudanteDisciplina = await _context.EstudanteDisciplina
                .Include(e => e.Disciplina)
                .FirstOrDefaultAsync(m => m.EstudanteId == id);
            if (estudanteDisciplina == null)
            {
                return NotFound();
            }

            return View(estudanteDisciplina);
        }

        // GET: EstudanteDisciplinas/Create
        public IActionResult Create()
        {
            ViewData["EstudanteId"] = new SelectList(_context.Disciplina, "DisciplinaId", "DisciplinaId");
            return View();
        }

        // POST: EstudanteDisciplinas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EstudanteId,DisciplinaId")] EstudanteDisciplina estudanteDisciplina)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estudanteDisciplina);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EstudanteId"] = new SelectList(_context.Disciplina, "DisciplinaId", "DisciplinaId", estudanteDisciplina.EstudanteId);
            return View(estudanteDisciplina);
        }

        // GET: EstudanteDisciplinas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudanteDisciplina = await _context.EstudanteDisciplina.FindAsync(id);
            if (estudanteDisciplina == null)
            {
                return NotFound();
            }
            ViewData["EstudanteId"] = new SelectList(_context.Disciplina, "DisciplinaId", "DisciplinaId", estudanteDisciplina.EstudanteId);
            return View(estudanteDisciplina);
        }

        // POST: EstudanteDisciplinas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EstudanteId,DisciplinaId")] EstudanteDisciplina estudanteDisciplina)
        {
            if (id != estudanteDisciplina.EstudanteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estudanteDisciplina);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstudanteDisciplinaExists(estudanteDisciplina.EstudanteId))
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
            ViewData["EstudanteId"] = new SelectList(_context.Disciplina, "DisciplinaId", "DisciplinaId", estudanteDisciplina.EstudanteId);
            return View(estudanteDisciplina);
        }

        // GET: EstudanteDisciplinas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudanteDisciplina = await _context.EstudanteDisciplina
                .Include(e => e.Disciplina)
                .FirstOrDefaultAsync(m => m.EstudanteId == id);
            if (estudanteDisciplina == null)
            {
                return NotFound();
            }

            return View(estudanteDisciplina);
        }

        // POST: EstudanteDisciplinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estudanteDisciplina = await _context.EstudanteDisciplina.FindAsync(id);
            _context.EstudanteDisciplina.Remove(estudanteDisciplina);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstudanteDisciplinaExists(int id)
        {
            return _context.EstudanteDisciplina.Any(e => e.EstudanteId == id);
        }
    }
}
