namespace Models.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("group_item")]
    public partial class GroupItem {
        [Dapper.Contrib.Extensions.Key]
        public int id { get; set; }
        public string app_key { get; set; }
        public int group_id { get; set; }
        public int item_id { get; set; }
        public string descs { get; set; }
        public string contents { get; set; }
        public int quantity { get; set; }
        public int orders { get; set; }
        public DateTime? start_at { get; set; }
        public DateTime? end_at { get; set; }
        public string created_by { get; set; }
        public DateTime? created_at { get; set; }
        public string updated_by { get; set; }
        public DateTime? updated_at { get; set; }
        public string deleted_by { get; set; }
        public DateTime? deleted_at { get; set; }
        public int flag { get; set; }
    }
}