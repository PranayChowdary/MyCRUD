using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCRUD.Models;

namespace MyCRUD.Models
{
    public class FileController : Controller
    {
        private userDBContext db = new userDBContext();
        // GET: File
        public ActionResult Index(int id)
        {
            var fileToRetrieve = db.FileData.Find(id);
            return File(fileToRetrieve.Content,fileToRetrieve.ContentType);
        }
    }
}