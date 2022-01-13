using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using User_Auth.ViewModel;

namespace User_Auth.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;
        [BindProperty]
        public Login Model { get; set; }
        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var identity = await signInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RemainderMe, false);
                if (identity.Succeeded)
                {
                    if(returnUrl == null||returnUrl == "/")
                    {
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(returnUrl);
                    }

                }
                ModelState.AddModelError("", "Username or Password Incorrect");
            }
            return Page();
        }
    }
}
