using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9
{
    public class TestController : Controller
    {
        [HttpGet("/wtf")]
        public async Task<IActionResult> WTF()
        {
             var x = TempData.ContainsKey("SomeKey");
            await Task.Run(() => throw new Exception("error"));
            return Content("this will never hit.");
        }
    }
}
