﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace SyncfusionWebApplication22.Controllers
{
    public partial class DropDownButtonController : Controller
    {
        //
        // GET: /DropdownButtonDefault/
        public ActionResult DropDownButtonFeatures()
        {
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Cut"
            });
            items.Add(new
            {
                text = "Copy"
            });
            items.Add(new
            {
                text = "Paste"
            });
            ViewBag.items = items;
            return View();
        }
    }
}
