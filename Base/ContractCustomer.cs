namespace Models.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("contract_customer")]
    public partial class ContractCustomer {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public string id { get; set; }
        public long hdkh_id { get; set; }
        public long app_key { get; set; }
        public string descs { get; set; }
        public string created_by { get; set; }
        public DateTime? created_at { get; set; }
        public string updated_by { get; set; }
        public DateTime? updated_at { get; set; }
        public string deleted_by { get; set; }
        public DateTime? deleted_at { get; set; }
        public int flag { get; set; }
    }
}