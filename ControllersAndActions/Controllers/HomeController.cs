using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()//Action Method  
        {
            ViewData["data1"] = "View Data";
            ViewBag.data2 = "View Bag";

            TempData["data3"] = "temp Data";
            

            TempData["data4"] = new List<string>()
            {
               "Cricket","Football","Hockey"
            };

            //ViewBag.data1 = "Mubarakpur";
            //ViewBag.data2 = 24;
            //ViewBag.data3 = DateTime.Now.ToShortDateString();

            //string[] arr = { "Yash", "Rashid", "Zain" };
            //ViewBag.data4 = arr;

            //ViewBag.data5 = new List<string>()
            //{
            //    "Cricket","Football","Hockey"           

            //};
            //ViewData["myName"] = "waqar+Hashim";
            //ViewData["data1"] = "jk silk";
            //ViewData["data2"] = 25;
            //ViewData["data3"] = DateTime.Now.ToLongDateString();

            //string[] arr = { "Yash", "Rashid", "Zain" };
            //ViewData["data4"] = arr;

            //ViewData["data5"] = new List<string>()
            //{
            //    "Cricket","Football","Hockey"

            //}; 

            TempData.Keep();
            return View();
        }

        public IActionResult About()//Action Method  
        {
            return View();
        }

        public IActionResult Contact()//Action Method  
        {
            return View();
        }

        public string Display()//Action Method  
        {
            return "Welcome To My VS";
        }

        public int  DisplayId(int id)//Action Method  
        {
            return id;
        }
    }
}
     