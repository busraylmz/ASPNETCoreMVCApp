using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVCApp.Controllers
{
    [NonController] // just for bussiness logic not for request
    public class CompaniesController : Controller
    {

        #region IActionResult
        public IActionResult GetCompanies()
        {
            X();
            IActionResult result = Json("busra....");

            return result;
        }
        #endregion

        [NonAction]
        public void X()
        {
            //just for bussiness logic not for request


        }

    }
}
