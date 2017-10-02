using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcore_vervoort_kobe.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspnetcore_vervoort_kobe.Controllers
{
    [Route("/books")]
    public class BookController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            /*var model = new BookListViewModel();
            model.Books = new List<BookDetailModel>();
            model.Books.Add(new BookDetailModel{
                Author = "blablabla",
                Title = "lalalaa",
                ISBN = "1284239842390482",
                CreatedOn = new DateTime(2001, 09, 11),
            });
			model.Books.Add(new BookDetailModel
			{
				Author = "sflksjdklf",
				Title = "lalsfsdfalaa",
				ISBN = "128324433249842390482",
				CreatedOn = new DateTime(2003, 01, 13),
			});*/
            var model = new BookDictionaryViewModel();
			model.Books = new Dictionary<int, BookDetailModel>()
			{
				{1, new BookDetailModel{ID = 1, Author = "Khaled Hosseini", Title = "The Kite Runner", ISBN = "1-57322-245-3", CreatedOn = new DateTime(2003, 5, 29)}},
				{2, new BookDetailModel{ID = 2, Author = "Jonathan Franzen", Title = "Freedom", ISBN = "0-374-15846-0", CreatedOn = new DateTime(2010, 8, 31)}},
				{3, new BookDetailModel{ID = 3, Author = "Jack Kerouac", Title = "On the Road", ISBN = "0-374-15846-0", CreatedOn = new DateTime(1957, 9, 5)}},
			};

            return View(model);
        }

        [HttpGet("/books/{id}")]
        public IActionResult Detail([FromRoute]int id)
        {
            if (id == 0)
            {
                return new NotFoundResult();
            }

            ViewData["id"] = id;



            return View();
        }
    }
}
