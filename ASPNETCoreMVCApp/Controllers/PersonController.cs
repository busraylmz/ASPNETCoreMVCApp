﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVCApp.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult GetPerson()
        {
            return View();
        }
    }
}
