﻿namespace Models.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("contract_customer")]
    public partial class ContractCustomer {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public string contract_customer_id { get; set; }
        public string app_key { get; set; }
        public int donvi_id { get; set; }
        public string ma_gd { get; set; }
        public string ten_kh { get; set; }
        public string so_dt { get; set; }
        public string ma_tb { get; set; }
        public string attachs { get; set; }
        public string details { get; set; }
        public string created_by { get; set; }
        public DateTime? created_at { get; set; }
        public string updated_by { get; set; }
        public DateTime? updated_at { get; set; }
        public string deleted_by { get; set; }
        public DateTime? deleted_at { get; set; }
        public string cfm_notes { get; set; }
        public string cfm_by { get; set; }
        public DateTime? cfm_at { get; set; }
        public int account_number { get; set; }
        public int flag { get; set; }
        public int type_id { get; set; }
        public int thuebao_id { get; set; }
        public string so_gt { get; set; }
        public string mst { get; set; }
        public string stk { get; set; }
        public string diachi_kh { get; set; }
        public string diachi_tb { get; set; }
        public string diachi_ld { get; set; }
    }
}