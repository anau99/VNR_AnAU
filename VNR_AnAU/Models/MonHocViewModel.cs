using System.ComponentModel.DataAnnotations.Schema;

namespace VNR_AnAU.Models
{
    public class MonHocViewModel
    {
        //yêu cầu chỉ view TenMonHoc và TenKhoaHoc  
        public string? TenMonHoc { get; set; }
        // dùng để lấy dữ liệu từ Page Khóa học Index khi đó chỉ cần tách chuỗi và
        // không cần truy cập DB để lấy tên khóa học của môn học đó
        public string TenKhoaHoc { get; set; } 
        public MonHocViewModel(string TenMonHoc,string TenKhoaHoc) 
        { 
            this.TenMonHoc = TenMonHoc;
            this.TenKhoaHoc = TenKhoaHoc;
        }
    }
}
