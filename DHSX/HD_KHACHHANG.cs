namespace Models.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("HD_KHACHHANG")]
    public partial class HD_KHACHHANG {
        // [Dapper.Contrib.Extensions.Key]
        public long hdkh_id { get; set; }
        public string ma_gd { get; set; }
        public string ma_hd { get; set; }
        public string ma_kh { get; set; }
        public long khachhang_id { get; set; }
        public string ten_kh { get; set; }
        public string diachi_kh { get; set; }
        public string nguoi_dd { get; set; }
        public string chucdanh_dd { get; set; }
        public string so_dt { get; set; }
        public string so_fax { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public DateTime ngay_sn { get; set; }
        public DateTime ngaylap_hd { get; set; }
        public string so_gt { get; set; }
        public DateTime ngaycap { get; set; }
        public string noicap { get; set; }
        public string ghichu { get; set; }
        public int donvi_id { get; set; }
        public int loaigt_id { get; set; }
        public int nhanvien_id { get; set; }
        public int khlon_id { get; set; }
        public int loaihd_id { get; set; }
        public int bosungtb_id { get; set; }
        public int kh_kt3 { get; set; }
        public string mst_kh { get; set; }
        public string hokhau { get; set; }
        public int loaikh_id { get; set; }
        public string noicap_hk { get; set; }
        public DateTime ngay_hk { get; set; }
        public int gioitinh { get; set; }
        public int dantoc_id { get; set; }
        public int quoctich_id { get; set; }
        public int nganhnghe_id { get; set; }
        public string diachi_ndd { get; set; }
        public DateTime ngayhethan_gt { get; set; }
        public string mst { get; set; }
        public string stk { get; set; }
        public int nganhang_id { get; set; }
        public DateTime ngay_yc { get; set; }
        public string dactrung { get; set; }
        public int ctv_id { get; set; }
        public int tnc1_id { get; set; }
        public int tnc2_id { get; set; }
        public int tnc3_id { get; set; }
        public string may_cn { get; set; }
        public DateTime ngay_cn { get; set; }
        public string nguoi_cn { get; set; }
        public string ip_cn { get; set; }
        public int so_pl { get; set; }
        public long hdkh_cha_id { get; set; }
        public int kieuhd_id { get; set; }
        public int kh_tiemnang { get; set; }
        public int yeucau_id { get; set; }
        public int httthi_id { get; set; }
        public int phanloaikh_id { get; set; }
        public string nguoilap_hd { get; set; }
        public int loainc_id { get; set; }
        public int nhanviengt_id { get; set; }
        public int mucdo_id { get; set; }
        public int tbtl_id { get; set; }
        public int kenhtn_id { get; set; }
    }
}