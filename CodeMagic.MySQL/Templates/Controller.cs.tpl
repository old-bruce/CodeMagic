using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using {NameSpace}.DataAccess.Model;
using {NameSpace}.DataAccess;

namespace {NameSpace}.Controllers
{
    public class {Table}Controller : Controller
    {
        private AppDb Db;

        public {Table}Controller(AppDb db)
        {
            this.Db = db;
        }

        public async Task<IActionResult> Index()
        {
            await Db.OpenAsync();
            var query = new {Table}Query(Db);
            ViewBag.result =  await query.FindOneAsync(1);
            return View();
        }
    }
}
