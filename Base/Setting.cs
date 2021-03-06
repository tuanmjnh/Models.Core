namespace Models.Core {
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;
    [Table("setting")]
    public partial class Setting {
        public Guid id { get; set; }

        [Required]
        [StringLength(255)]
        public string module_key { get; set; }

        [Required]
        [StringLength(255)]
        public string sub_key { get; set; }

        public string value { get; set; }

        public string sub_value { get; set; }

        [StringLength(2000)]
        public string desc { get; set; }

        public string extra { get; set; }

        [StringLength(128)]
        public string created_by { get; set; }

        public DateTime? created_at { get; set; }

        [StringLength(128)]
        public string updated_by { get; set; }

        public DateTime? updated_at { get; set; }

        public int? flag { get; set; }
    }
}