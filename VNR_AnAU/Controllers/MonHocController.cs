using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using VNR_AnAU.Models;

namespace VNR_AnAU.Controllers
{
    public class MonHocController : Controller
    {

        public VNR_InternShipContext _VNR_InternShipContext;

        public MonHocController(VNR_InternShipContext VNR_InternShipContext)
        {
           this._VNR_InternShipContext = VNR_InternShipContext;

        }


        [HttpGet]
        [Route("/MonHoc/DanhSachMonHoc/{IdAndTenKhoaHoc}")]
        public IActionResult DanhSachMonHoc(string IdAndTenKhoaHoc)
        {
            var splitString=IdAndTenKhoaHoc.Split('_');
            var idKhoaHoc = splitString[0];
            var tenKhoaHoc = splitString[1];
            var ListMonhoc = _VNR_InternShipContext.MonHoc.Where(x=>x.KhoaHocId==int.Parse(idKhoaHoc)).ToList();
            var ListModelViewMonHoc = new List<MonHocViewModel>();
            foreach(var monHoc in ListMonhoc)
            {
                ListModelViewMonHoc.Add (new MonHocViewModel(monHoc.TenMonHoc,tenKhoaHoc));
            }
          
            return View(ListModelViewMonHoc);
        }
    }
}
