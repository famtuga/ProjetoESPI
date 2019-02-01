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
    public class HorariosController : Controller
    {
        private readonly HorariosBDContext _context;

        public HorariosController(HorariosBDContext context)
        {
            _context = context;
        }

        // GET: Horarios
        public IActionResult Index(string searchString, string sortOrder, bool sortAsc, int page = 1)
        {
            var horariosBDContext = _context.Horario.Include(d => d.TipoProva).ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                horariosBDContext = horariosBDContext.Where(s => s.Ano.ToString().ToLower().Contains(searchString.ToLower()) || s.NomeProva.ToLower().Contains(searchString.ToLower())).ToList();
            }

            switch (sortOrder)
            {
                case "NomeProva":
                    if (sortAsc)
                    {
                        horariosBDContext = horariosBDContext.OrderBy(d => d.NomeProva).ToList();
                    }
                    else
                    {
                        horariosBDContext = horariosBDContext.OrderByDescending(d => d.NomeProva).ToList();
                    }
                    break;
                case "Datainicio":
                    if (sortAsc)
                    {
                        horariosBDContext = horariosBDContext.OrderBy(d => d.Datainicio).ToList();
                    }
                    else
                    {
                        horariosBDContext = horariosBDContext.OrderByDescending(d => d.Datainicio).ToList();
                    }
                    break;
                case "DiaInteiro":
                    if (sortAsc)
                    {
                        horariosBDContext = horariosBDContext.OrderBy(d => d.DiaInteiro).ToList();
                    }
                    else
                    {
                        horariosBDContext = horariosBDContext.OrderByDescending(d => d.DiaInteiro).ToList();
                    }
                    break;
                case "Datafim":
                    if (sortAsc)
                    {
                        horariosBDContext = horariosBDContext.OrderBy(d => d.Datafim).ToList();
                    }
                    else
                    {
                        horariosBDContext = horariosBDContext.OrderByDescending(d => d.Datafim).ToList();
                    }
                    break;
                case "Descricao":
                    if (sortAsc)
                    {
                        horariosBDContext = horariosBDContext.OrderBy(d => d.TipoProva.Nome).ToList();
                    }
                    else
                    {
                        horariosBDContext = horariosBDContext.OrderByDescending(d => d.TipoProva.Nome).ToList();
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
            }

            var contagemItems = horariosBDContext.Count();

            var viewModel = new HorariosViewModel() { Horarios = horariosBDContext.Skip(PagingInfo.ItemsPerPage * (page - 1)).Take(PagingInfo.ItemsPerPage).ToList() };
            viewModel.PagingInfo.CurrentPage = page;
            viewModel.PagingInfo.TotalItems = contagemItems;
            viewModel.PagingInfo.Ascending = sortAsc;
            viewModel.PagingInfo.CurrentSort = sortOrder;
            viewModel.PagingInfo.CurrentFilter = searchString;
            return View(viewModel);

        }

        // GET: Horarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horario = await _context.Horario.Include(d => d.TipoProva)
                .FirstOrDefaultAsync(m => m.HorarioId == id);
            if (horario == null)
            {
                return NotFound();
            }

            return View(horario);
        }

        // GET: Horarios/Create
        public IActionResult Create()
        {
            ViewData["Disciplinas"] = new SelectList(_context.Disciplina, "Nome", "Nome");
            //ViewData["TipoProva"] = new SelectList(_context.TipoProva, "Descricao", "Descricao");
            ViewData["TipoProvaID"] = new SelectList(_context.TipoProva, "TipoProvaID", "Nome");


            return View();
        }

        // POST: Horarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HorarioId,NomeProva,Datainicio,DiaInteiro,Datafim,Descricao,Ano,TipoProvaID")] Horario horario)
        {
            if (ModelState.IsValid)
            {
                horario.TipoProva = _context.TipoProva.Find(horario.TipoProvaID);
                _context.Add(horario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Disciplinas"] = new SelectList(_context.Disciplina, "Nome", "Nome");
            ViewData["TipoProvaID"] = new SelectList(_context.TipoProva, "TipoProvaID", "Nome", horario.TipoProvaID);


            return View(horario);
        }

        // GET: Horarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horario = await _context.Horario.FindAsync(id);
            if (horario == null)
            {
                return NotFound();
            }

            ViewData["TipoProvaID"] = new SelectList(_context.TipoProva, "TipoProvaID", "Nome");
            return View(horario);
        }

        // POST: Horarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HorarioId,NomeProva,Datainicio,DiaInteiro,Datafim,Descricao,Ano,TipoProvaID")] Horario horario)
        {
            if (id != horario.HorarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    horario.TipoProva = _context.TipoProva.Find(horario.TipoProvaID);
                    _context.Update(horario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HorarioExists(horario.HorarioId))
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

            ViewData["TipoProvaID"] = new SelectList(_context.TipoProva, "TipoProvaID", "Nome", horario.TipoProvaID);
            return View(horario);
        }

        // GET: Horarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horario = await _context.Horario.Include(h=>h.TipoProva)
                .FirstOrDefaultAsync(m => m.HorarioId == id);
            if (horario == null)
            {
                return NotFound();
            }

            return View(horario);
        }

        // POST: Horarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var horario = await _context.Horario.FindAsync(id);
            _context.Horario.Remove(horario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HorarioExists(int id)
        {
            return _context.Horario.Any(e => e.HorarioId == id);
        }
    }
}
