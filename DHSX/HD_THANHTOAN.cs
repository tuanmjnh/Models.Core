namespace Models.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("HD_THANHTOAN")]
    public partial class HD_THANHTOAN {
        // [Dapper.Contrib.Extensions.Key]
        public long hdtb_id { get; set; }
        public int hdtt_id { get; set; }
        public int thanhtoan_id { get; set; }
        public string ma_tt { get; set; }
        public string ten_tt { get; set; }
        public string diachi_tt { get; set; }
        public string matb_dd { get; set; }
        public string mst { get; set; }
        public string stk { get; set; }
        public int hdkh_id { get; set; }
        public int donvi_id { get; set; }
        public int httt_id { get; set; }
        public int nganhang_id { get; set; }
        public string so_dt { get; set; }
        public string email { get; set; }
        public string diachi_ct { get; set; }
        public string dv_qhns { get; set; }
        public string machuong { get; set; }
        public string mn_kt { get; set; }
        public string ma_ndkt { get; set; }
        public string mn_nsnn { get; set; }
        public int tien_dm { get; set; }
        public int tuyenthu_id { get; set; }
        public string ghichu { get; set; }
        public string diachi_bc { get; set; }
        public string may_cn { get; set; }
        public DateTime ngay_cn { get; set; }
        public string nguoi_cn { get; set; }
        public int hdmig_id { get; set; }
        public int hddt_id { get; set; }
        public string ip_cn { get; set; }
        public string chu_tk { get; set; }
        public int hdtt_id_hni { get; set; }
    }
}