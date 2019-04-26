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
        public string group_id { get; set; }
        public int kieu_ld { get; set; }
        public string ma_hd { get; set; }
        public string ten_kh { get; set; }
        public string diachi_kh { get; set; }
        public string nguoi_dd { get; set; }
        public string sdt { get; set; }
        public string stk { get; set; }
        public string mst { get; set; }
        public string so_gt { get; set; }
        public string ngay_cap { get; set; }
        public string noi_cap { get; set; }
        public DateTime? ngay_bd { get; set; }
        public DateTime? ngay_kt { get; set; }
        public int so_luong { get; set; }
        public decimal don_gia { get; set; }
        public decimal vat { get; set; }
        public string tep_dk { get; set; }
        public string noidung { get; set; }
        public string ghichu { get; set; }
        public string created_by { get; set; }
        public string created_ip { get; set; }
        public DateTime? created_at { get; set; }
        public string updated_by { get; set; }
        public DateTime? updated_at { get; set; }
        public string updated_ip { get; set; }
        public string deleted_by { get; set; }
        public DateTime? deleted_at { get; set; }
        public string deleted_ip { get; set; }
        public int flag { get; set; }
    }
}