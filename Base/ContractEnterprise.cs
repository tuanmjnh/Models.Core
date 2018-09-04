namespace Models.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("contract_enterprise")]
    public partial class ContractEnterprise {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public string contract_enterprise_id { get; set; }
        public string app_key { get; set; }
        public int local_id { get; set; }
        public int group_id { get; set; }
        public string contract_code { get; set; }
        public string customer_name { get; set; }
        public string customer_address { get; set; }
        public string tax_code { get; set; }
        public DateTime? start_at { get; set; }
        public DateTime? end_at { get; set; }
        public int quantity { get; set; }
        public string price { get; set; }
        public string details { get; set; }
        public string contents { get; set; }
        public string attach { get; set; }
        public string created_by { get; set; }
        public DateTime? created_at { get; set; }
        public string updated_by { get; set; }
        public DateTime? updated_at { get; set; }
        public string deleted_by { get; set; }
        public DateTime? deleted_at { get; set; }
        public int flag { get; set; }
    }
}