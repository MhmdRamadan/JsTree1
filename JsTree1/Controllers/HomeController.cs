using JsTree1.Data;
using JsTree1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JsTree1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected ApplicationDbContext _webSiteContext;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext webSiteContext)
        {
            _logger = logger;
            this._webSiteContext = webSiteContext;
        }

        public IActionResult GetJsTree()
        {
            return View();
        }
        public bool CreateJsTree(string name,int num,string NodePath)
        {
            Categories categories = new Categories();
            categories.Name = name;
            categories.num = num;
            categories.Path= NodePath;
            _webSiteContext.Categories.Add(categories);
            _webSiteContext.SaveChanges();
            return true;
        }

        public bool EditJsTree(string name, int num, string NodePath)
        {
            string OldPath = "";
            if (NodePath.Contains('/'))
            {
                OldPath = NodePath.Substring(0, NodePath.LastIndexOf('/'));
            }
               
            var category = _webSiteContext.Categories.Where(n => n.Path.Contains(OldPath) && n.num== num).FirstOrDefault();
            category.Path = NodePath;
            _webSiteContext.Entry(category).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            _webSiteContext.SaveChanges();
            return true;
        }


    }
}
