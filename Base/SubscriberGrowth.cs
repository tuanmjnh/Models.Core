namespace Models.Core {
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;
    [Table("subscriber_growth")]
    public partial class SubscriberGrowth {
        public Guid id { get; set; }

        [StringLength(150)]
        public string contract_id { get; set; }

        [StringLength(150)]
        public string services_id { get; set; }

        [StringLength(150)]
        public string account { get; set; }

        public string technician { get; set; }

        public string collaborator { get; set; }

        [StringLength(150)]
        public string package { get; set; }

        [StringLength(150)]
        public string customer_name { get; set; }

        public string customer_address { get; set; }

        [StringLength(150)]
        public string phone { get; set; }

        [StringLength(150)]
        public string created_by { get; set; }

        public DateTime? created_at { get; set; }

        [StringLength(150)]
        public string updated_by { get; set; }

        public DateTime? updated_at { get; set; }

        public int? flag { get; set; }
    }
}