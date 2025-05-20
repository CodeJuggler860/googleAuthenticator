using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoogleAuthentication.Models;
using GoogleAuthentication.Services;

namespace GoogleAuthentication.Controllers
{
    public class ScriptCheckController : Controller
    {
        // GET: ScriptCheck
        public ActionResult Index() => View(new ScriptInput());

        [HttpPost]
        public ActionResult Check(ScriptInput model)
        {
            if (MaliciousScriptDetector.IsMalicious(model.UserScript, out string pattern))
                model.Result = $"⚠ Unsafe! Matched pattern: {pattern}";
            else
                model.Result = "✅ Safe";

            return View("Index", model);
        }
    }
}