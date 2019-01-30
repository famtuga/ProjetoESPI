using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Horarios.Data;
using Horarios.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Horarios.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly HorariosBDContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            HorariosBDContext context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage ="Campo Username inválido!")]
            [Display(Name = "Username")]
            public string Username { get; set; }

            [Required(ErrorMessage = "Campo Email inválido!")]
            [EmailAddress(ErrorMessage = "Campo Email inválido!")]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Campo Password inválido!")]
            [StringLength(100, ErrorMessage = "A {0} tem de ter no minimo {2} e no maximo {1} caracteres.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirmar password")]
            [Compare("Password", ErrorMessage = "A Password e confirmação da Password não são iguais.")]
            public string ConfirmPassword { get; set; }
            
            [Display(Name = "Tipo de Utilizador")]
            public string TipoUtilizador { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if(string.IsNullOrEmpty(Input.TipoUtilizador))
            {
                ModelState.AddModelError("TipoUtilizador", "Tipo de Utilizador invalido");
                return Page();
            }
            
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = Input.Username, Email = Input.Email, EmailConfirmed = true };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("Criado novo utilizador");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirme o seu email",
                        $"Por favor confirme a sua conta ao clicar <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>aqui</a>.");

                    switch (Input.TipoUtilizador.ToString())
                    {
                        case "Estudante":
                            _context.Estudante.Add(new Estudante() { Nome = Input.Username, Email = Input.Email });
                            await _userManager.AddToRoleAsync(user, "Estudante");
                            _context.SaveChanges();
                            break;
                        case "Professor":
                            _context.Professor.Add(new Professor() { Nome = Input.Username, Email = Input.Email });
                            await _userManager.AddToRoleAsync(user, "Professor");
                            _context.SaveChanges();
                            break;
                    }

                    // Faz login no novo user
                    //await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
