namespace Models.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("contract_customer")]
    public partial class ContractCustomer {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public string contract_customer_id { get; set; }
        public string app_key { get; set; }
        public int local_id { get; set; }
        public string contract_code { get; set; }
        public string customer_name { get; set; }
        public string customer_address { get; set; }
        public string customer_phone { get; set; }
        public string accounts { get; set; }
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
    }
}