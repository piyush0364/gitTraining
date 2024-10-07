using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using WebAppMVCGit.Models;

namespace WebAppMVCGit.Controllers
{
    public class EmpController : Controller
    {
        List<Emp> _emps = new List<Emp>()
        {
            new Emp(){EId=1,EName="Sam Dicosta",EDesign="Developer",EDOJ=new DateTime(day:4,month:02,year:2020)},
               new Emp(){EId=1,EName="Sam Dicosta",EDesign="Developer",EDOJ=new DateTime(day:4,month:02,year:2020)},
                new Emp(){EId=1,EName="Sam Dicosta",EDesign="Developer",EDOJ=new DateTime(day:4,month:02,year:2020)},
                 new Emp(){EId=1,EName="Sam Dicosta",EDesign="Developer",EDOJ=new DateTime(day:4,month:02,year:2020)}

        };
        public IActionResult Index()
        {
            return View(_emps);
        }
    }
}
