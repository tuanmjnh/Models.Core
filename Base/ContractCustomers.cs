﻿namespace Models.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("contract_customer")]
    public partial class ContractCustomers {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public string cc_id { get; set; }
        public long hdkh_id { get; set; }
        public long khachhang_id { get; set; }
        public string app_key { get; set; }
        public string ma_gd { get; set; }
        public string ten_kh { get; set; }
        public string diachi_kh { get; set; }
        public string so_dt { get; set; }
        public string so_gt { get; set; }
        public string mst { get; set; }
        public string stk { get; set; }
        public string nguoi_cn { get; set; }
        public DateTime ngay_cn { get; set; }
        public int donvi_id { get; set; }
        public int loaihd_id { get; set; }
        public int loaikh_id { get; set; }
        public string attach { get; set; }
        public string details { get; set; }
        public string created_by { get; set; }
        public DateTime? created_at { get; set; }
        public string updated_by { get; set; }
        public DateTime? updated_at { get; set; }
        public string deleted_by { get; set; }
        public DateTime? deleted_at { get; set; }
        public int flag { get; set; }
        public string ten_dv { get; set; }
        public string ten_loaihd { get; set; }
        public string ten_loaikh { get; set; }
    }
}