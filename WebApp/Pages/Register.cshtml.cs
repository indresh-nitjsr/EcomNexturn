using CoreLogic.Models;
using CoreLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public User user { get; set; } = default!;

        public void OnGet()
        {
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid || user == null)
            {
                return Page();

            }

            UserService userService = new UserService();
            userService.AddUser(user);

            return RedirectToPage("./Products/Index");

        }
    }
}
