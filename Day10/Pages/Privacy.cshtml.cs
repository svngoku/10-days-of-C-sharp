using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Day10.Pages
{
    public class PrivacyModel : PageModel
    {
        public void OnGet()
        {
            
        }

        public string toString()
        {
            return "Simple text message";
        }
    }
}