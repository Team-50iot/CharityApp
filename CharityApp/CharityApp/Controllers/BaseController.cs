using CharityApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using CharityApp.Models;


namespace CharityApp.Controllers
{
    public abstract class BaseController : Controller
    {
        protected ApplicationDbContext _context;



        protected BaseController(ApplicationDbContext context)
        {
            _context = context;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            ViewBag.Categories = _context.Categories.ToList();

            base.OnActionExecuted(context);
        }

    }
}
