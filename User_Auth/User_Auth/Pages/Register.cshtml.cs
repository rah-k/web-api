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
    public class RegisterModel : PageModel
    {
       
        private readonly UserManager<IdentityUser> userManger;
        private readonly SignInManager<IdentityUser> signInManager;
        [BindProperty]
        public Register Model { get; set; }
        public RegisterModel(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            this.signInManager =signInManager;
            this.userManger = userManager;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if(ModelState.IsValid)
            {
                var user = new IdentityUser()
                {
                    UserName = Model.Email,
                    Email = Model.Email,
                    PhoneNumber=Model.PhoneNumber
                    

                };

                var result = await userManger.CreateAsync(user, Model.Password);
                if(result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToPage("Index");
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return Page();
        }
    }
}
