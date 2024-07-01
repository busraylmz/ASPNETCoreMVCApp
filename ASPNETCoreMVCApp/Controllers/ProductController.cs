using ASPNETCoreMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVCApp.Controllers
{
    public class ProductController : Controller
    {

        #region ViewResult
        //render view file (.cshtml) as response 
        //base ViewResult_ViewStart.cshtml
        //public ViewResult GetProducts()
        //{
        //    ViewResult result = View();
        //    return result;
        //}

        #endregion

        #region PartialViewResult
        //public PartialViewResult GetProducts()
        //{
            //render view file (.cshtml) as response 
            //use Ajax teq client base
            //PartialViewResult result = PartialView();
            //return result;
        //}

        #endregion

        #region JsonResult
        public JsonResult GetProducts()
        {
            JsonResult jsonResult = Json(new Product
            {
                Id = 1,
                ProductName = "pen",
                Quantity = 2
            }) ;
            return jsonResult;
        }

        #endregion
        //public IActionResult GetProducts()
        //{
        //    return View();
        //}
    }
}
