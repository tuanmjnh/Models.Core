namespace Models.Core
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("kehoach_tb")]
    public partial class Kehoach_TB
    {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public string id { get; set; }
        public int donvi_id { get; set; }
        public int nhom_kh { get; set; }
        public int thuebao_id { get; set; }
        public string ma_tb { get; set; }
        public string ten_tb { get; set; }
        public string diachi_tb { get; set; }
        public string so_dt { get; set; }
        public string ma_nd { get; set; }
        public int thang_bd { get; set; }
        public int thang_kt { get; set; }
        public string ghichu { get; set; }
        public string ip_nhap { get; set; }
        public string nguoi_nhap { get; set; }
        public DateTime? ngay_nhap { get; set; }
        public string ip_cn { get; set; }
        public string nguoi_cn { get; set; }
        public DateTime? ngay_cn { get; set; }
        public int trang_thai { get; set; }
    }
}