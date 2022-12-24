namespace VNR_AnAU.Models
{
    public class KhoaHocViewModel
    {
        public int Id { get; set; }
        public string? TenKhoaHoc { get; set; }
        public KhoaHocViewModel(int id, string TenKhoaHoc)
        {
            this.Id = id;
            this.TenKhoaHoc= TenKhoaHoc;
        }
    }
}
