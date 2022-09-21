using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            var ext = Path.GetExtension(file.FileName);
            var allowedExtensions = new[] {
            ".Jpg", ".png", ".jpg", "jpeg"
        };
            if ((allowedExtensions.Contains(ext.ToLower())) && file.ContentLength > 0)
            {
                string _FileName = Path.GetFileName(file.FileName);
                string _path = Path.Combine(Server.MapPath(""), _FileName);
                file.SaveAs(_path);
                ViewBag.Message = "File Uploaded Successfully!!";
            }
            else
            {
                ViewBag.Message = "File must be .Jpg .png .jpg jpeg ";
            }
            
            return View();
          
        }
    }
}