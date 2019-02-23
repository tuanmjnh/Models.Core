namespace Models.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("language_items")]
    public partial class LanguageItems {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public long id { get; set; }
        public string lang_code { get; set; }
        // public string lang_data { get; set; }
        public string module_code { get; set; }
        public string key { get; set; }
        public string value { get; set; }
        // public int orders { get; set; }
        // public string created_by { get; set; }
        // public DateTime? created_at { get; set; }
        // public string updated_by { get; set; }
        // public DateTime? updated_at { get; set; }
        // public string deleted_by { get; set; }
        // public DateTime? deleted_at { get; set; }
        // public int flag { get; set; }
    }
    public partial class LanguageItemsReturn {
        public string module { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }
}