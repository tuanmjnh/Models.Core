namespace Models.Core
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("kehoach_th")]
    public partial class Kehoach_TH
    {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public string id { get; set; }
        public string kehoachtb_id { get; set; }
        public string ma_nd { get; set; }
        public DateTime? ngay_th { get; set; }
        public int ket_qua { get; set; }
        public string lydo { get; set; }
        public string de_xuat { get; set; }
        public string ghichu { get; set; }
        public string ip_cn { get; set; }
        public string nguoi_cn { get; set; }
        public DateTime? ngay_cn { get; set; }
    }
}