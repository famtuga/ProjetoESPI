using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestorHorario.Data;
using GestorHorario.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace GestorHorario.Controllers
{
    public class BackOfficeController : Controller
    {
        GestaoHorarioContext _context = new GestaoHorarioContext();
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Registar(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registar(RegisterViewModel model, string returnUrl = null)
        {

            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                //Adicionar Aluno na GestorHorarioDB
                var aluno = new Aluno { Nome = model.Nome, Email = model.Email, Ano = model.Ano };
                _context.Add(aluno);
                await _context.SaveChangesAsync();

                //Add 
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email, PhoneNumber="852145365" };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    //  _logger.LogInformation("User created a new account with password.");
                    _userManager.AddToRoleAsync(user, "Aluno").Wait();
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    // var callbackUrl = Url.EmailConfirmationLink(user.Id, code, Request.Scheme);
                    //  await _emailSender.SendEmailConfirmationAsync(model.Email, callbackUrl);

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    // _logger.LogInformation("User created a new account with password.");
                    return RedirectToAction(returnUrl);
                }
                AddErrors(result);

            }

            // If we got this far, something failed, redisplay form
            return View(model);

        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
    }



}

