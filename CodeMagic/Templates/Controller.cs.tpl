/**
 * Auto Create By Code Magic {DateTime}
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using {NameSpace}.BLL;
using {NameSpace}.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace {NameSpace}.Web.Controllers
{
    public class {TableName}Controller : Controller
    {
		public class {TableName}ViewModel
		{
{ViewModel}
		}

        private readonly {BLL} {tableName}Bll = new {BLL}();

        public ActionResult Index()
        {
            ViewBag.{TableName}List = {tableName}Bll.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

		[HttpPost]
        public JsonResult Insert({TableName}ViewModel model)
		{
			try
            {
				{TableName}Model {tableName}Model = new {TableName}Model();
{Insert}
				{tableName}Bll.Insert({tableName}Model);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        public ActionResult Modify({Keys})
        {
            ViewBag.{TableName}Model = {tableName}Bll.GetModel({KeysParam});
            return View();
        }

		[HttpPost]
        public JsonResult Update({TableName}ViewModel model)
		{
			try
            {
				{TableName}Model {tableName}Model = {tableName}Bll.GetModel({ModifyKeysParam});
{Insert}
				{tableName}Bll.Insert({tableName}Model);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete({Keys})
        {
			try
            {
				{TableName}Model model = {tableName}Bll.GetModel({KeysParam});
				if (model != null)
				{
					{tableName}Bll.Delete({KeysParam});
				}
				else
				{
					return Json(new { code = 500, msg = "parms is null" });
				}
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
        }
    }
}
