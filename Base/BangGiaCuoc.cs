namespace Models.Core {
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("BangGiaCuoc")]
    public partial class BangGiaCuoc {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public long id { get; set; }

        [StringLength(128)]
        public string tenGoi { get; set; }

        [StringLength(128)]
        public string profile { get; set; }

        public int? tocDo { get; set; }

        public decimal? gia { get; set; }

        [StringLength(128)]
        public string kieu { get; set; }

        public int? kieuID { get; set; }

        public int? goicuocId { get; set; }

        public int? TichhopId { get; set; }

        [StringLength(10)]
        public string isLuuLuong { get; set; }

        public int? isTichHop { get; set; }

        [StringLength(1000)]
        public string ghichu { get; set; }
    }
}