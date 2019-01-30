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
    public class HorarioDisciplinasController : Controller
    {
        private readonly HorariosBDContext _context;

        public HorarioDisciplinasController(HorariosBDContext context)
        {
            _context = context;
        }

        // GET: HorarioDisciplinas
        public async Task<IActionResult> Index()
        {
            var horariosBDContext = _context.HorarioDisciplina.Include(h => h.Disciplina).Include(h => h.Horario);
            return View(await horariosBDContext.ToListAsync());
        }

        // GET: HorarioDisciplinas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horarioDisciplina = await _context.HorarioDisciplina
                .Include(h => h.Disciplina)
                .Include(h => h.Horario)
                .FirstOrDefaultAsync(m => m.HorarioId == id);
            if (horarioDisciplina == null)
            {
                return NotFound();
            }

            return View(horarioDisciplina);
        }

        // GET: HorarioDisciplinas/Create
        public IActionResult Create()
        {
            ViewData["HorarioId"] = new SelectList(_context.Disciplina, "DisciplinaId", "DisciplinaId");
            ViewData["DisciplinaId"] = new SelectList(_context.Horario, "HorarioId", "HorarioId");
            return View();
        }

        // POST: HorarioDisciplinas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HorarioId,DisciplinaId")] HorarioDisciplina horarioDisciplina)
        {
            if (ModelState.IsValid)
            {
                _context.Add(horarioDisciplina);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HorarioId"] = new SelectList(_context.Disciplina, "DisciplinaId", "DisciplinaId", horarioDisciplina.HorarioId);
            ViewData["DisciplinaId"] = new SelectList(_context.Horario, "HorarioId", "HorarioId", horarioDisciplina.DisciplinaId);
            return View(horarioDisciplina);
        }

        // GET: HorarioDisciplinas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horarioDisciplina = await _context.HorarioDisciplina.FindAsync(id);
            if (horarioDisciplina == null)
            {
                return NotFound();
            }
            ViewData["HorarioId"] = new SelectList(_context.Disciplina, "DisciplinaId", "DisciplinaId", horarioDisciplina.HorarioId);
            ViewData["DisciplinaId"] = new SelectList(_context.Horario, "HorarioId", "HorarioId", horarioDisciplina.DisciplinaId);
            return View(horarioDisciplina);
        }

        // POST: HorarioDisciplinas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HorarioId,DisciplinaId")] HorarioDisciplina horarioDisciplina)
        {
            if (id != horarioDisciplina.HorarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(horarioDisciplina);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HorarioDisciplinaExists(horarioDisciplina.HorarioId))
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
            ViewData["HorarioId"] = new SelectList(_context.Disciplina, "DisciplinaId", "DisciplinaId", horarioDisciplina.HorarioId);
            ViewData["DisciplinaId"] = new SelectList(_context.Horario, "HorarioId", "HorarioId", horarioDisciplina.DisciplinaId);
            return View(horarioDisciplina);
        }

        // GET: HorarioDisciplinas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horarioDisciplina = await _context.HorarioDisciplina
                .Include(h => h.Disciplina)
                .Include(h => h.Horario)
                .FirstOrDefaultAsync(m => m.HorarioId == id);
            if (horarioDisciplina == null)
            {
                return NotFound();
            }

            return View(horarioDisciplina);
        }

        // POST: HorarioDisciplinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var horarioDisciplina = await _context.HorarioDisciplina.FindAsync(id);
            _context.HorarioDisciplina.Remove(horarioDisciplina);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HorarioDisciplinaExists(int id)
        {
            return _context.HorarioDisciplina.Any(e => e.HorarioId == id);
        }
    }
}
