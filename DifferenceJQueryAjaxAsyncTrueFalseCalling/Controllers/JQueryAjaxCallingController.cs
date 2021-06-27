using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DifferenceJQueryAjaxAsyncTrueFalseCalling.Controllers
{
    public class JQueryAjaxCallingController : Controller
    {
        [HttpPost]
        public IActionResult Response1()
        {
            Thread.Sleep(2000);  // Wait 2 Second
           
            return Json(
               new
               {
                   message = "1st Response- Success!!!"
               }
           );
        }

        [HttpPost]
        public IActionResult Response2()
        {
            return Json(
               new
               {
                   message = "2nd Response- Success!!!"
               }
           );
        }
    }
}
