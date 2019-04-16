namespace Models.Core
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("HD_THUEBAO")]
    public partial class HD_THUEBAO
    {
        // [Dapper.Contrib.Extensions.Key]
        public long hdtb_id { get; set; }
        public long thuebao_id { get; set; }
        public string ma_tb { get; set; }
        public string ten_tb { get; set; }
        public string diachi_tb { get; set; }
        public int hdtb_cha_id { get; set; }
        public long hdkh_id { get; set; }
        public long hdtt_id { get; set; }
        public int kieuld_id { get; set; }
        public int tthd_id { get; set; }
        public int loaitb_id { get; set; }
        public int doituong_id { get; set; }
        public int dichvuvt_id { get; set; }
        public int donvi_id { get; set; }
        public DateTime ngay_ht { get; set; }
        public DateTime ngay_tt { get; set; }
        public int soluong { get; set; }
        public int ketquaks { get; set; }
        public int sync_status { get; set; }
        public int tbhd_pl { get; set; }
        public string diachi_ld { get; set; }
        public DateTime ngay_sn { get; set; }
        public int status { get; set; }
        public int kieu_tb { get; set; }
        public int donvi_dau_id { get; set; }
        public int donvi_cuoi_id { get; set; }
        public string email { get; set; }
        public DateTime ngay_ins { get; set; }
        public DateTime ngay_kh { get; set; }
        public int mucuoctb_id { get; set; }
        public int mucuoc_tb { get; set; }
        public int thuebao_cha_id { get; set; }
        public string ghichu { get; set; }
        public int quytrinh_id { get; set; }
        public string may_cn { get; set; }
        public DateTime ngay_cn { get; set; }
        public string nguoi_cn { get; set; }
        public int chunhom { get; set; }
        public int nhomtb_id { get; set; }
        public int goi_id { get; set; }
        public string ip_cn { get; set; }
        public int so_pl { get; set; }
        public int chuyenmang { get; set; }
        public int bangke_id { get; set; }
        public int goikt_id { get; set; }
        public int chitieu_tg { get; set; }
        public DateTime thoigian_ck { get; set; }
        public string ip_kh { get; set; }
        public int lan_ks { get; set; }
        public DateTime tg_thue_den { get; set; }
        public DateTime tg_thue_tu { get; set; }
        public string nguoi_kh { get; set; }
        public int tientrinhtc_id { get; set; }
        public string ma_dhvip { get; set; }
        public int sothang_ck { get; set; }
        public DateTime ngay_ktck { get; set; }
        public int hdtb_id_hni { get; set; }
        public DateTime ngay_hh_td { get; set; }
        public int sync_stb { get; set; }
        public int nhacc_cu_id { get; set; }
        public int doituong_ct_id { get; set; }
        public int htcm_id { get; set; }
        public string ten_dt { get; set; }
        public string ten_dvvt { get; set; }
        public string loaihinh_tb { get; set; }
        public string ten_dv { get; set; }
    }
}