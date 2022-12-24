using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VNR_AnAU.Models;

namespace VNR_AnAU.Controllers
{
    public class KhoaHocController : Controller
    {
       
        public VNR_InternShipContext _VNR_InternShipContext;

        public KhoaHocController(VNR_InternShipContext VNR_InternShipContext)
        {

            _VNR_InternShipContext = VNR_InternShipContext;
        }

        public IActionResult Index()
        {

            var data = _VNR_InternShipContext.KhoaHoc.ToList();
            var ListkhoahocViewModel = new List<KhoaHocViewModel>();
            foreach (var c in data)
            {
                var khoahocviewModel = new KhoaHocViewModel(c.Id, c.TenKhoaHoc);
                ListkhoahocViewModel.Add(khoahocviewModel);
            }
            return View(ListkhoahocViewModel);
       
          
        }

    }
}