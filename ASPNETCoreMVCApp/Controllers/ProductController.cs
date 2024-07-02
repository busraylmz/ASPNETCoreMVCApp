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

        //public ViewResult GetProducts()
        //{
        //    ViewResult result = View();
        //    return result;
        //}


        #endregion

        #region PartialViewResult
        //public PartialViewResult GetProducts()
        //{
        //    PartialViewResult partialViewResult = PartialView();
        //    return partialViewResult;
        //}
        #endregion

        #region JSONResult
        //public JsonResult GetProducts()
        //{

        //    JsonResult jsonResult = Json(new Product { Id = 5, Name = "Terlik", Quantity = 2 });
        //    return jsonResult;
        //}
        #endregion

        #region EmptyResult
        //public EmptyResult GetProducts()
        //{
        //    return new EmptyResult();
        //}
        #endregion

        #region ContentResult
        //public ContentResult GetProducts()
        //{
        //    ContentResult result = Content("busra....");

        //    return result;
        //}
        #endregion

        #region ActionResult
        //public ActionResult GetProducts()
        //{
        //    ActionResult result = Content("busra....");

        //    return result;
        //}
        #endregion

        #region IActionResult
        public IActionResult GetProducts()
        {
            IActionResult result = Json("busra....");

            return result;
        }
        #endregion
    }



}
