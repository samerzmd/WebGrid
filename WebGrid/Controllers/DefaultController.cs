using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web.Mvc;
using WebGrid.Models;

namespace WebGrid.Controllers
{
    public class DefaultController : Controller
    {
        public List<GridModel> List=new List<GridModel>();

        public DefaultController()
        {
            for (var i =0; i < 100; i++)
            {
                List.Add(new GridModel { Title = "Title " + i, SubTitle = "SubTitle " + i });
            }
        }

        // GET: Default
        public ActionResult Index(int page=1,string sort = "Title" ,string sortdir= "ASC")
        {
            --page;
            var gridModels = new PagedList<GridModel>(7);
            var listItems = List;
            listItems = listItems.OrderBy(sort+" "+sortdir).ToList();
             listItems =listItems.Skip(page * gridModels.PageSize).Take(gridModels.PageSize).ToList();

            gridModels.Items.AddRange(listItems);
            gridModels.Count = List.Count;
            return View(gridModels);
            
        }
    }
   
}