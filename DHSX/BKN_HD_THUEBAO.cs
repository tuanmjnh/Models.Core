namespace Models.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("BKN_HD_THUEBAO")]
    public partial class BKN_HD_THUEBAO {
        // [Dapper.Contrib.Extensions.Key]
        public string ma_gd { get; set; }
        public long thuebao_id { get; set; }
        public string ma_tb { get; set; }
        public int loaitb_id { get; set; }
        public int dichvuvt_id { get; set; }
        public int donvi_id { get; set; }
        public string ten_kh { get; set; }
        public string diachi_kh { get; set; }
        public string diachi_tb { get; set; }
        public string diachi_ld { get; set; }
        public string so_dt { get; set; }
        public string so_gt { get; set; }
        public string mst { get; set; }
        public string stk { get; set; }
        public string nguoi_cn { get; set; }
        public DateTime ngay_cn { get; set; }
        public DateTime ngay_tt { get; set; }
        public DateTime ngay_ht { get; set; }
        public int kieuld_id { get; set; }
        public string ten_kieuld { get; set; }
        public int tthd_id { get; set; }
        public string trangthai_hd { get; set; }

    }
}