namespace Models.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("navigation")]
    public partial class Navigation {
        [Dapper.Contrib.Extensions.Key]
        public int id { get; set; }
        public string dependent { get; set; }
        // public int parent_id { get; set; }
        // public string parents { get; set; }
        public int levels { get; set; }
        public string title { get; set; }
        public string icon { get; set; }
        public string image { get; set; }
        public string url { get; set; }
        public int orders { get; set; }
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