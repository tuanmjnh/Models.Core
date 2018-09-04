namespace Models.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("groups")]
    public partial class Groups {
        [Dapper.Contrib.Extensions.Key]
        public long group_id { get; set; }

        [StringLength(256)]
        public string app_key { get; set; }

        [StringLength(512)]
        public string title { get; set; }

        [StringLength(1024)]//AllowHtml, 
        public string descriptions { get; set; }

        [StringLength(256)]
        public string parent_id { get; set; }

        [StringLength(512)]
        public string parents_id { get; set; }
        public int levels { get; set; }

        [StringLength(1024)]
        public string images { get; set; }

        [StringLength(128)]
        public string icons { get; set; }
        public int quantity { get; set; }

        [StringLength(64)]
        public string positions { get; set; }
        public int orders { get; set; }

        [StringLength(128)]
        public string created_by { get; set; }
        public DateTime? created_at { get; set; }

        [StringLength(128)]
        public string updated_by { get; set; }
        public DateTime? updated_at { get; set; }

        [StringLength(128)]
        public string deleted_by { get; set; }
        public DateTime? deleted_at { get; set; }
        public int flag { get; set; }
    }
}