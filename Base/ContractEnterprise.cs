namespace Models.Core
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("contract_enterprise")]
    public partial class ContractEnterprise
    {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public string id { get; set; }
        public string app_key { get; set; }
        public int donvi_id { get; set; }
        public int group_id { get; set; }
        public int kieuld_id { get; set; }
        public string ma_hd { get; set; }
        public string ten_kh { get; set; }
        public string diachi_kh { get; set; }
        public string nguoi_dd { get; set; }
        public string sdt { get; set; }
        public string stk { get; set; }
        public string mst { get; set; }
        public string sgt { get; set; }
        public DateTime? ngay_cap { get; set; }
        public string noi_cap { get; set; }
        public DateTime? ngay_bd { get; set; }
        public DateTime? ngay_kt { get; set; }
        public int so_luong { get; set; }
        public decimal tien { get; set; }
        public decimal thue { get; set; }
        public string tep_dk { get; set; }
        public string noi_dung { get; set; }
        public string ghi_chu { get; set; }
        public string nguoi_tao { get; set; }
        public string ip_tao { get; set; }
        public DateTime? ngay_tao { get; set; }
        public string nguoi_cn { get; set; }
        public string ip_cn { get; set; }
        public DateTime? ngay_cn { get; set; }
        public string nguoi_xoa { get; set; }
        public string ip_xoa { get; set; }
        public DateTime? ngay_xoa { get; set; }
        public int trang_thai { get; set; }
        public string nguoi_gt { get; set; }
    }
}