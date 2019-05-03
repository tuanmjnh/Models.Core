namespace Models.Core
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("db_donvi")]
    public partial class DBDonvi
    {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public int ma_dvi { get; set; }
        public int donvi_id { get; set; }
        public int donvi_ql_id { get; set; }
        public string ma_dv { get; set; }
        public string ten_dv { get; set; }
        public string ten_dv_ql { get; set; }
        public string sdt { get; set; }
        public string stk { get; set; }
    }
}