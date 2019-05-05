namespace Models.Core
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("app_key")]
    public partial class APP_KEY
    {
        [Dapper.Contrib.Extensions.Key]
        public string app_key { get; set; }
        public string title { get; set; }
        public int flag { get; set; }
    }
}