using CharityApp.Data;
using CharityApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityApp.Controllers
{
    public class MyAppData 
    {
        public static List<Category> Categories { get; set; }
    }
}
