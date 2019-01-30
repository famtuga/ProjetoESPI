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

namespace Horarios
{
    public class TipoProvasController : Controller
    {
        private readonly HorariosBDContext _context;

        public TipoProvasController(HorariosBDContext context)
        {
            _context = context;
        }

        // GET: TipoProvas
        public IActionResult Index(string searchString, string sortOrder, bool sortAsc, int page = 1)
        {
            var horariosBDContext = _context.TipoProva.ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                horariosBDContext = horariosBDContext.Where(s => s.Nome.ToLower().Contains(searchString.ToLower())).ToList();
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
                case "Descricao":
                    if (sortAsc)
                    {
                        horariosBDContext = horariosBDContext.OrderBy(d => d.Descricao).ToList();
                    }
                    else
                    {
                        horariosBDContext = horariosBDContext.OrderByDescending(d => d.Descricao).ToList();
                    }
                    break;
            }

            var contagemItems = horariosBDContext.Count();

            var viewModel = new TipoProvasViewModel() { TipoProvas = horariosBDContext.Skip(PagingInfo.ItemsPerPage * (page - 1)).Take(PagingInfo.ItemsPerPage).ToList() };
            viewModel.PagingInfo.CurrentPage = page;
            viewModel.PagingInfo.TotalItems = contagemItems;
            viewModel.PagingInfo.Ascending = sortAsc;
            viewModel.PagingInfo.CurrentSort = sortOrder;
            viewModel.PagingInfo.CurrentFilter = searchString;
            return View(viewModel);

        }

        // GET: TipoProvas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoProva = await _context.TipoProva
                .FirstOrDefaultAsync(m => m.TipoProvaID == id);
            if (tipoProva == null)
            {
                return NotFound();
            }

            return View(tipoProva);
        }

        // GET: TipoProvas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoProvas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipoProvaID,Nome,Descricao")] TipoProva tipoProva)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoProva);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoProva);
        }

        // GET: TipoProvas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoProva = await _context.TipoProva.FindAsync(id);
            if (tipoProva == null)
            {
                return NotFound();
            }
            return View(tipoProva);
        }

        // POST: TipoProvas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TipoProvaID,Nome,Descricao")] TipoProva tipoProva)
        {
            if (id != tipoProva.TipoProvaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoProva);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoProvaExists(tipoProva.TipoProvaID))
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
            return View(tipoProva);
        }

        // GET: TipoProvas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoProva = await _context.TipoProva
                .FirstOrDefaultAsync(m => m.TipoProvaID == id);
            if (tipoProva == null)
            {
                return NotFound();
            }

            return View(tipoProva);
        }

        // POST: TipoProvas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoProva = await _context.TipoProva.FindAsync(id);
            _context.TipoProva.Remove(tipoProva);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoProvaExists(int id)
        {
            return _context.TipoProva.Any(e => e.TipoProvaID == id);
        }
    }
}
