using CharityApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityApp.Controllers
{
    public class MyAppData : BaseController
    {
        public MyAppData(ApplicationDbContext context) : base(context)
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
