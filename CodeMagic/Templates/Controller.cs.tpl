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

namespace {NameSpace}.Controllers
{
    public class {TableName}Controller : Controller
    {
        private {BLL} {tableName}Bll = new {BLL}();

        public ActionResult Index()
        {
            ViewBag.{TableName}List = {tableName}Bll.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Modify(int {id})
        {
            ViewBag.{TableName}Model = {tableName}Bll.GetModel({id});
            return View();
        }

        [HttpPost]
        public JsonResult Save()
        {
            try
            {
                if (string.IsNullOrEmpty(Request.Params["{id}"]))
                {
                    Insert();
                }
                else
                {
                    Update();
                }
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
            return Json(new { code = 200 });
        }

        private void Insert()
        {
            {TableName}Model model = new {TableName}Model();
            {Insert}
            {tableName}Bll.Insert(model);
        }

        private void Update()
        {
            int {tableName}ID = int.Parse(Request.Params["{id}"]);
            {TableName}Model model = {tableName}Bll.GetModel({id});
            {Update}
            {tableName}Bll.Update(model);
        }

        [HttpPost]
        public JsonResult Delete(int {id})
        {
            {TableName}Model model = {tableName}Bll.GetModel({id});
            if (model != null)
            {
                {tableName}Bll.Delete(model.{id});
            }
            else
            {
                return Json(new { code = 500, msg = "{id} is null" });
            }
            return Json(new { code = 200 });
        }
    }
}