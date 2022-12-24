using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VNR_AnAU.Models
{
    public class VNR_InternShipContext : DbContext
    {

        public VNR_InternShipContext()
        {

        }
        public VNR_InternShipContext(DbContextOptions<VNR_InternShipContext> options) : base(options)
        {
        }

        public  DbSet<KhoaHoc> KhoaHoc { get; set; }
        public  DbSet<MonHoc> MonHoc { get; set; }

       
    }
}
